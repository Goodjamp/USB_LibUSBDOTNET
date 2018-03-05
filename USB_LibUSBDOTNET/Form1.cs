using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;


//-------USB--------------
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;

namespace USB_LibUSBDOTNET
{
    

    public partial class Form1 : Form
    {
        //delegate for show Rx data in Form thread
        private delegate void showUSBData(byte[] data_array, int dataSize);
        private String USB_DEV;
        private static UsbDevice MyUsbDevice;
        private UsbRegDeviceList allDevices;
        private IUsbDevice wholeUsbDevice;
        private UsbEndpointReader reader;
        private UsbEndpointWriter writer;
        // size selected endpoin Rx buffer
        private int rxBuferSize;
        // size selected endpoin Tx buffer
        private int txBuferSize;



        public Form1()
        {
            InitializeComponent();
            allDevices = UsbDevice.AllDevices;

        }


        private void buttonTakeUSBDev_Click(object sender, EventArgs e)
        {
            int dev_count;
            int num_dev;

            clearAllfield();

            allDevices = UsbDevice.AllDevices;  // get all usb devises
            if (allDevices.Count == 0)  // if no device
            {
                listBoxDeviceDescription.Items.Add("no device");
                return;
            }
            //show all  fide device vid_pid
            for(dev_count = 0; dev_count<allDevices.Count; dev_count++)
            {   
                try
                {
                   // .allDevices[dev_count].Open(out MyUsbDevice);
                    listBoxDeviceDescription.Items.Add("dev №: " + (dev_count + 1).ToString());
                   // MyUsbDevice.Close();
                    
                }
                catch
                {
                    listBoxDeviceDescription.Items.Clear();
                    listBoxDeviceDescription.Items.Add("OPEN ERROR");
                }
            }
         
        }



        //@brief Defaulte lable text seating
        private void clearAllfield() 
        {
            lableDeviceVID.Text = "-";
            lableDevicePID.Text = "-";
            lableProducte.Text = "-";
            lableManufacture.Text = "-";
            lableSerial.Text = "-";
            listBoxDeviceDescription.Items.Clear();
        }

        //@brief Selected device for showing -----CONFIGURATION DESCRIPTION--------- 
        private void listBoxDeviceDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seldevice = listBoxDeviceDescription.SelectedIndex;
            // ---------open sel device------------

                try
                {
                    allDevices[seldevice].Open(out MyUsbDevice);
                    lableDeviceVID.Text = MyUsbDevice.Info.Descriptor.VendorID.ToString();
                    lableDevicePID.Text = MyUsbDevice.Info.Descriptor.ProductID.ToString();
                    lableProducte.Text = MyUsbDevice.Info.ProductString;
                    lableManufacture.Text = MyUsbDevice.Info.ManufacturerString;
                    lableSerial.Text = MyUsbDevice.Info.SerialString;
                    MyUsbDevice.Close();

                }
                catch
                {
                    listBoxDeviceDescription.Items.Clear();
                    listBoxDeviceDescription.Items.Add("OPEN ERROR");
                    return;
                }
                this.buttonOpen.Enabled = true;
        }

        // @brief open selected USB device
        //
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int seldevice = listBoxDeviceDescription.SelectedIndex;
            int numEndPoints;
            int cnt;
            // ---------open sel device------------

            try
            {
                allDevices[seldevice].Open(out MyUsbDevice);
            }
            catch
            {
                listBoxDeviceDescription.Items.Clear();
                listBoxDeviceDescription.Items.Add("OPEN ERROR");
            }

            // Configure selected USB device for read/write operation
            // Configs -> InterfaceInfoList -> EndPointsInfoList -> Descriptor
            // Get number read data from endpoint 0x81
            numEndPoints = MyUsbDevice.Configs[0].InterfaceInfoList[0].Descriptor.EndpointCount;
            for (cnt = 0; cnt < (numEndPoints); cnt++) 
            {
                if (MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.EndpointID == 0x81) 
                {
                    rxBuferSize = MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.MaxPacketSize;
                }
                if(MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.EndpointID == 0x01)
                {
                    txBuferSize =  MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.MaxPacketSize;
                }
                
            }
            wholeUsbDevice = MyUsbDevice as IUsbDevice;
            // Select config #1
            wholeUsbDevice.SetConfiguration(1);
            // Claim interface #0.
            wholeUsbDevice.ClaimInterface(0);
            // open write endpoint 1.
            
            writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01);
            // open read endpoint 1.
            reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);
            //Set Rx Callbac function
            //reader.DataReceived += (OnRxEndPointData);
            //reader.DataReceivedEnabled = true;
            Thread myThread = new Thread(readUSB); //Создаем новый объект потока (Thread)
            myThread.Start(); //запускаем поток

      }

      private void readUSB()
      {  
            byte[] buffReadPolling = new byte[rxBuferSize];
            int rxLength;
            ErrorCode reazRead;
            while (true) 
            {
                reazRead = reader.Read(buffReadPolling, 50, out rxLength);
                if (rxLength != 0)
                {
                    showUSBRx(buffReadPolling, rxLength);
                }
            }

        }

        //@brief Callback function for receive data from selected USB device/configuration/interface/endpoint
        //
        private void OnRxEndPointData(object sender, EndpointDataEventArgs e)
        {
            byte[] my = new byte[e.Count];
            Array.Copy(e.Buffer, my, e.Count);

           // Invoke(new Action(() => Text += (my[2].ToString() + ";")));
            showUSBRx(my, e.Count);
        }

        //@brief Show USB Rx data
        //
        public void showUSBRx(byte[] data_array, int dataSize)
        {
            int cnt;
            string rxString = "Read: " + DateTime.Now.ToString("hh:mm:ss:fff") + " - ";
            if (listBoxRxEP1.InvokeRequired)
            {
                showUSBData d = showUSBRx;
                Invoke(d, data_array, dataSize);
            }
            else 
            {
                for (cnt = 0; cnt < dataSize; cnt++) 
                {
                    rxString += Convert.ToString(data_array[cnt], 16) + "  ";
                }
                listBoxRxEP1.Items.Insert(0, rxString);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxRxEP1.Items.Clear();
        }


        private void commandErrorMessage()
        {
            MessageBox.Show("Should be use only HEX wit space or coma deviceder",
                           "ERROR",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1);       
        }

        private void openDeviceError()
        {
            MessageBox.Show("Please, selected device with support MCS",
                           "ERROR",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1);
        }


        //@brief Send comand to USB device
        //
        private void sendUSB(byte[] message, int messageSize) 
        {
            int numDataTx;
            ErrorCode rezTx;
            rezTx = writer.Write(message, 2000, out numDataTx);
        }


        private UInt32 converStringToHex(string inString, int offset, ref byte[] inByte, int length)
        {

            UInt32 k = 0;
            char[] charSeparators = new char[] { ' ', ',' };
            string[] numeric = inString.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (numeric.Length == 0)
            {
                return 0;
            }
            foreach (var numer in numeric)
            {
                if (numer.Length != 2)
                {
                    commandErrorMessage();
                    return 0;
                }

                if (!Byte.TryParse(numer, System.Globalization.NumberStyles.HexNumber, null as IFormatProvider, out inByte[offset + k]))
                {
                    commandErrorMessage();
                    return 0;
                }
                
                k++;
                if (k >= length)
                {
                    return k;
                }
            }
            return k;
        
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
           byte[] buffTx = new byte[txBuferSize];
           if (0 < converStringToHex(textBoxSend.Text, 0, ref buffTx, buffTx.Length) )
           {
               sendUSB(buffTx, buffTx.Length);
           }
        }

        private void instalDev_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("install-filter-win.exe");
            }
            catch
            { 
            }           
        }


        private void buttonWR_Send_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[64];
            UInt32 numReg;
            //I2C Address
            if (0 == converStringToHex(comboBoxWR_DevAdres.Text, 5, ref command, 1) )
            {
                return;
            }
            //Data Field
            if (0 == (numReg = converStringToHex(textBoxWR_Data.Text, 10, ref command, 64)) )
            {
                return;
            }
            //Reg
            if (0 == converStringToHex(textBoxWR_Reg.Text, 8, ref command, 1) )
            {
                return;
            }

            command[0] = Convert.ToByte((numReg + 7) << 1);
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x0;
            command[4] = 0x1;
            command[6] = Convert.ToByte(numReg);

            

            sendUSB(command, command.Length);

        }

        private void buttonRR_Send_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[64];
            //I2C Address
            if (0 == converStringToHex(comboBoxRR_DevAdres.Text, 4, ref command, 1) )
            {
                return;
            }
            //Reg
            if (0 == converStringToHex(textBoxRR_Num.Text, 5, ref command, 1) )
            {
                return;
            }

            if (0 == converStringToHex(textBoxRR_Reg.Text, 7, ref command, 1) )
            {
                return;
            }
            command[0] = 0x0C;
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x01;

            sendUSB(command, command.Length);
        }

        private void buttonRF_Send_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[64];
            command[0] = 0x02;
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x02;

            sendUSB(command, command.Length);
        }

    }
}
