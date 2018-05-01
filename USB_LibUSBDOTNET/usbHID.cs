using System;
using System.Collections.Generic;
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
    class usbHID
    {
        public delegate void showUSBData(byte[] data_array, int dataSize);

        private showUSBData libUSBRxCallback;

        private static UsbDevice MyUsbDevice;
        private UsbRegDeviceList allDevices;
        private IUsbDevice wholeUsbDevice;
        private UsbEndpointReader reader;
        private UsbEndpointWriter writer;
        // size selected endpoin Rx buffer
        private int rxBuferSize;
        // size selected endpoin Tx buffer
        private int txBuferSize;
        Thread readLibUSBThread;

        public int usbGetNumberOfDevices()
        {
            allDevices = UsbDevice.AllDevices;  // get all usb devises
            return allDevices.Count;

        }


        //@brief Selected device for showing -----CONFIGURATION DESCRIPTION--------- 
        public bool usbGetDeviceInformation(int sellIndex, ref string VID, ref string PID, ref string Product, ref string Manufacture)
        {
            // ---------open sel device------------
            allDevices = UsbDevice.AllDevices;  // get all usb devises
            try
            {
                allDevices[sellIndex].Open(out MyUsbDevice);
                VID = MyUsbDevice.Info.Descriptor.VendorID.ToString();
                PID = MyUsbDevice.Info.Descriptor.ProductID.ToString();
                Product = MyUsbDevice.Info.ProductString;
                Manufacture = MyUsbDevice.Info.ManufacturerString;
                MyUsbDevice.Close();

            }
            catch
            {
                return false;
            }
            return true;
        }


        // @brief open selected USB device
        //
        public bool usbOpenHIDInterface(int selectedIndex, showUSBData rxCallback)
        {
            allDevices = UsbDevice.AllDevices;  // get all usb devises
            try
            {
                allDevices[selectedIndex].Open(out MyUsbDevice);

                // Configure selected USB device for read/write operation
                // Configs -> InterfaceInfoList -> EndPointsInfoList -> Descriptor
                // Get number read data from endpoint 0x81
                UInt16 numEndPoints = MyUsbDevice.Configs[0].InterfaceInfoList[0].Descriptor.EndpointCount;
                UInt16 cnt;
                for (cnt = 0; cnt < (numEndPoints); cnt++) // temporary solution - looking for EP_1
                {
                    if (MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.EndpointID == 0x81)
                    {
                        rxBuferSize = MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.MaxPacketSize;
                    }
                    if (MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.EndpointID == 0x01)
                    {
                        txBuferSize = MyUsbDevice.Configs[0].InterfaceInfoList[0].EndpointInfoList[cnt].Descriptor.MaxPacketSize;
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
                libUSBRxCallback = rxCallback;
                readLibUSBThread = new Thread(readUSBHID);
                readLibUSBThread.Start();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //@brief Send comand to USB device
        //
        public void usbSend(byte[] message, int messageSize)
        {
            int numDataTx;
            ErrorCode rezTx;
            rezTx = writer.Write(message, 2000, out numDataTx);
        }


        public bool libUSBCloseEP()
        {
            // Stope readUSB rhread
            if (readLibUSBThread.IsAlive)
            {
                readLibUSBThread.Abort();
                readLibUSBThread.Join(500);

            }

            //
            if (MyUsbDevice != null)
            {
                if (MyUsbDevice.IsOpen)
                {
                    // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                    // it exposes an IUsbDevice interface. If not (WinUSB) the 
                    // 'wholeUsbDevice' variable will be null indicating this is 
                    // an interface of a device; it does not require or support 
                    // configuration and interface selection.
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // Release interface #0.
                        wholeUsbDevice.ReleaseInterface(0);
                    }
                    MyUsbDevice.Close();
                }
            }
            MyUsbDevice = null;

            // Free usb resources
            UsbDevice.Exit();

            return true;
        }


        private void readUSBHID()
        {
            byte[] buffReadPolling = new byte[rxBuferSize];
            int rxLength;
            ErrorCode reazRead;
            while (true)
            {
                reazRead = reader.Read(buffReadPolling, 50, out rxLength);
                if (rxLength != 0)
                {
                    libUSBRxCallback(buffReadPolling, rxLength);
                }
            }
        }


    }


}
