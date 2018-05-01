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
        private int txBuferSize;
        private usbHID myUSBHID;


        public Form1()
        {
            InitializeComponent();
            //allDevices = UsbDevice.AllDevices;
            comboBoxMemTarget.SelectedIndex = 2;
            myUSBHID = new usbHID();
        }


        private void buttonTakeUSBDev_Click(object sender, EventArgs e)
        {
            int dev_count;
            int num_dev = myUSBHID.usbGetNumberOfDevices();

            clearAllfield();

            if (num_dev == 0)  // if no device
            {
                listBoxDeviceDescription.Items.Add("no device");
                return;
            }
            //show all  fide device vid_pid
            for (dev_count = 0; dev_count < num_dev; dev_count++)
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
            string sellVID        = " ";
            string sellPID         = " ";
            string sellProdName    = " ";
            string sellManufacture = " ";
            if (!myUSBHID.usbGetDeviceInformation(listBoxDeviceDescription.SelectedIndex, ref sellVID, ref sellPID, ref sellProdName, ref sellManufacture))
            {
                listBoxDeviceDescription.Items.Clear();
                listBoxDeviceDescription.Items.Add("OPEN ERROR");
                return;
            }
            // Update infirmation
            lableDeviceVID.Text   = sellVID;
            lableDevicePID.Text   = sellPID;
            lableProducte.Text    = sellProdName;
            lableManufacture.Text = sellManufacture;
            // Update interface activity
            this.buttonOpen.Enabled = true;
        }


        // @brief open selected USB device
        //
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int seldevice = listBoxDeviceDescription.SelectedIndex;
            if(myUSBHID.usbOpenHIDInterface(listBoxDeviceDescription.SelectedIndex, showUSBRx))
            {
                this.buttonOpen.Enabled = false;
                this.buttonCloseInterface.Enabled = true;
            }
        }


        private void buttonCloseInterface_Click(object sender, EventArgs e)
        {
            if (myUSBHID.libUSBCloseEP())
            {
                this.buttonOpen.Enabled = true;
                this.buttonCloseInterface.Enabled = false;
            }
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
            if (0 < converStringToHex(textBoxSend.Text, 0, ref buffTx, buffTx.Length))
            {
                myUSBHID.usbSend(buffTx, buffTx.Length);
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
            if (0 == converStringToHex(comboBoxWR_DevAdres.Text, 5, ref command, 1))
            {
                return;
            }
            //Data Field
            if (0 == (numReg = converStringToHex(textBoxWR_Data.Text, 10, ref command, 64)))
            {
                return;
            }
            //Reg
            if (0 == converStringToHex(textBoxWR_Reg.Text, 8, ref command, 2))
            {
                return;
            }

            command[0] = Convert.ToByte((numReg + 7) << 1);
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x0;
            command[4] = Convert.ToByte(comboBoxMemTarget.SelectedIndex);
            command[6] = Convert.ToByte(numReg);



            myUSBHID.usbSend(command, command.Length);

        }


        private void buttonRR_Send_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[64];
            //I2C Address
            if (0 == converStringToHex(comboBoxRR_DevAdres.Text, 4, ref command, 1))
            {
                return;
            }
            //Reg
            if (0 == converStringToHex(textBoxRR_Num.Text, 5, ref command, 2))
            {
                return;
            }

            if (0 == converStringToHex(textBoxRR_Reg.Text, 7, ref command, 2))
            {
                return;
            }
            command[0] = 0x0C;
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x01;

            myUSBHID.usbSend(command, command.Length);
        }


        private void buttonRF_Send_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[64];
            command[0] = 0x02;
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x02;

            myUSBHID.usbSend(command, command.Length);
        }

        private void button_Mute_Click(object sender, EventArgs e)
        {
            setMuteState(true);
        }


        private void button_UnMute_Click(object sender, EventArgs e)
        {
            setMuteState(false);
        }

        private void setMuteState(bool mutState)
        {
            byte[] command = new byte[64];
            command[0] = 0x06;
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x04;
            command[4] = 0x00;
            command[5] = (mutState) ? (Convert.ToByte(1)) : (Convert.ToByte(0));

            myUSBHID.usbSend(command, command.Length);
        }


        private void button_GetMute_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[64];
            command[0] = 0x02;
            command[1] = 0x00;
            command[2] = 0x01;
            command[3] = 0x05;

            myUSBHID.usbSend(command, command.Length);
        }
    }
}
