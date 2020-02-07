using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication1
{

    class Program
    {
        static int Main(string[] args)
        {
            Program p = new Program();
            p.Serial_Click();
            return 0;
        }


        private void Serial_Click()
        {
            byte[] loopArray;
            SerialPort thePort;
            WeatherLoopData loopData;

            byte[] loopArray1;
            SerialPort thePort1;
            WeatherLoopData1 loopData1;

            byte[] loopArray2;
            SerialPort thePort2;
            WeatherLoopData2 loopData2;

            byte[] loopArray3;
            SerialPort thePort3;
            WeatherLoopData3 loopData3;

            byte[] loopArray4;
            SerialPort thePort4;
            WeatherLoopData4 loopData4;

            byte[] loopArray5;
            SerialPort thePort5;
            WeatherLoopData5 loopData5;

            byte[] loopArray6;
            SerialPort thePort6;
            WeatherLoopData6 loopData6;

            byte[] loopArray7;
            SerialPort thePort7;
            WeatherLoopData7 loopData7;

            byte[] loopArray8;
            SerialPort thePort8;
            WeatherLoopData8 loopData8;

            byte[] loopArray9;
            SerialPort thePort9;
            WeatherLoopData9 loopData9;

            byte[] loopArray10;
            SerialPort thePort10;
            WeatherLoopData10 loopData10;

            byte[] loopArray11;
            SerialPort thePort11;
            WeatherLoopData11 loopData11;

            byte[] loopArray12;
            SerialPort thePort12;
            WeatherLoopData12 loopData12;

            byte[] loopArray13;
            SerialPort thePort13;
            WeatherLoopData13 loopData13;

            byte[] loopArray14;
            SerialPort thePort14;
            WeatherLoopData14 loopData14;

            thePort = Open_Serial_Port();

            if (thePort != null)
            {
                if (Wake_Serial_Vantage(thePort))
                {
                    loopData = new WeatherLoopData();
                    loopArray = Retrieve_Serial_Command(thePort, "LOOP 1", 95);
                    if (loopArray != null)
                    {
                        loopData.Load(loopArray);
                        Show_Message(loopData.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort.Close();
            }

            thePort1 = Open_Serial_Port1();

            if (thePort1 != null)
            {
                if (Wake_Serial_Vantage1(thePort1))
                {
                    loopData1 = new WeatherLoopData1();
                    loopArray1 = Retrieve_Serial_Command1(thePort1, "LOOP 1", 95);
                    if (loopArray1 != null)
                    {
                        loopData1.Load(loopArray1);
                        Show_Message(loopData1.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort1.Close();
            }

            thePort2 = Open_Serial_Port2();

            if (thePort2 != null)
            {
                if (Wake_Serial_Vantage2(thePort2))
                {
                    loopData2 = new WeatherLoopData2();
                    loopArray2 = Retrieve_Serial_Command2(thePort2, "LOOP 1", 95);
                    if (loopArray2 != null)
                    {
                        loopData2.Load(loopArray2);
                        Show_Message(loopData2.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort2.Close();
            }

            thePort3 = Open_Serial_Port3();

            if (thePort3 != null)
            {
                if (Wake_Serial_Vantage3(thePort3))
                {
                    loopData3 = new WeatherLoopData3();
                    loopArray3 = Retrieve_Serial_Command3(thePort3, "LOOP 1", 95);
                    if (loopArray3 != null)
                    {
                        loopData3.Load(loopArray3);
                        Show_Message(loopData3.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort3.Close();
            }

            thePort4 = Open_Serial_Port4();

            if (thePort4 != null)
            {
                if (Wake_Serial_Vantage4(thePort4))
                {
                    loopData4 = new WeatherLoopData4();
                    loopArray4 = Retrieve_Serial_Command4(thePort4, "LOOP 1", 95);
                    if (loopArray4 != null)
                    {
                        loopData4.Load(loopArray4);
                        Show_Message(loopData4.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort4.Close();
            }

            thePort5 = Open_Serial_Port5();

            if (thePort5 != null)
            {
                if (Wake_Serial_Vantage5(thePort5))
                {
                    loopData5 = new WeatherLoopData5();
                    loopArray5 = Retrieve_Serial_Command5(thePort5, "LOOP 1", 95);
                    if (loopArray5 != null)
                    {
                        loopData5.Load(loopArray5);
                        Show_Message(loopData5.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort5.Close();
            }

            thePort6 = Open_Serial_Port6();

            if (thePort6 != null)
            {
                if (Wake_Serial_Vantage6(thePort6))
                {
                    loopData6 = new WeatherLoopData6();
                    loopArray6 = Retrieve_Serial_Command6(thePort6, "LOOP 1", 95);
                    if (loopArray6 != null)
                    {
                        loopData6.Load(loopArray6);
                        Show_Message(loopData6.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort6.Close();
            }

            thePort7 = Open_Serial_Port7();

            if (thePort7 != null)
            {
                if (Wake_Serial_Vantage7(thePort7))
                {
                    loopData7 = new WeatherLoopData7();
                    loopArray7 = Retrieve_Serial_Command7(thePort7, "LOOP 1", 95);
                    if (loopArray7 != null)
                    {
                        loopData7.Load(loopArray7);
                        Show_Message(loopData7.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort7.Close();
            }

            thePort8 = Open_Serial_Port8();

            if (thePort8 != null)
            {
                if (Wake_Serial_Vantage8(thePort8))
                {
                    loopData8 = new WeatherLoopData8();
                    loopArray8 = Retrieve_Serial_Command8(thePort8, "LOOP 1", 95);
                    if (loopArray8 != null)
                    {
                        loopData8.Load(loopArray8);
                        Show_Message(loopData8.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort8.Close();
            }

            thePort9 = Open_Serial_Port9();

            if (thePort9 != null)
            {
                if (Wake_Serial_Vantage9(thePort9))
                {
                    loopData9 = new WeatherLoopData9();
                    loopArray9 = Retrieve_Serial_Command9(thePort9, "LOOP 1", 95);
                    if (loopArray9 != null)
                    {
                        loopData9.Load(loopArray9);
                        Show_Message(loopData9.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort9.Close();
            }

            thePort10 = Open_Serial_Port10();

            if (thePort10 != null)
            {
                if (Wake_Serial_Vantage10(thePort10))
                {
                    loopData10 = new WeatherLoopData10();
                    loopArray10 = Retrieve_Serial_Command10(thePort10, "LOOP 1", 95);
                    if (loopArray10 != null)
                    {
                        loopData10.Load(loopArray10);
                        Show_Message(loopData10.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort10.Close();
            }

            thePort11 = Open_Serial_Port11();

            if (thePort11 != null)
            {
                if (Wake_Serial_Vantage11(thePort11))
                {
                    loopData11 = new WeatherLoopData11();
                    loopArray11 = Retrieve_Serial_Command11(thePort11, "LOOP 1", 95);
                    if (loopArray11 != null)
                    {
                        loopData11.Load(loopArray11);
                        Show_Message(loopData11.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort11.Close();
            }

            thePort12 = Open_Serial_Port12();

            if (thePort12 != null)
            {
                if (Wake_Serial_Vantage12(thePort12))
                {
                    loopData12 = new WeatherLoopData12();
                    loopArray12 = Retrieve_Serial_Command12(thePort12, "LOOP 1", 95);
                    if (loopArray12 != null)
                    {
                        loopData12.Load(loopArray12);
                        Show_Message(loopData12.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort12.Close();
            }

            thePort13 = Open_Serial_Port13();

            if (thePort13 != null)
            {
                if (Wake_Serial_Vantage13(thePort13))
                {
                    loopData13 = new WeatherLoopData13();
                    loopArray13 = Retrieve_Serial_Command13(thePort13, "LOOP 1", 95);
                    if (loopArray13 != null)
                    {
                        loopData13.Load(loopArray13);
                        Show_Message(loopData13.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort13.Close();
            }

            thePort14 = Open_Serial_Port14();

            if (thePort14 != null)
            {
                if (Wake_Serial_Vantage14(thePort14))
                {
                    loopData14 = new WeatherLoopData14();
                    loopArray14 = Retrieve_Serial_Command14(thePort14, "LOOP 1", 95);
                    if (loopArray14 != null)
                    {
                        loopData14.Load(loopArray14);
                        Show_Message(loopData14.DebugString());
                    }
                    else
                        Show_Message("Lost Connection to Vantage Weatherstation");
                }
                else
                    Show_Message("Cannot Connect to Vantage Weatherstation");

                thePort14.Close();
            }
        }

      

        private void Clear()
        {
            
        }

        // Open a TCP socket.  Most operations will work on the underlying stream from the port which aren't completely 
        // implemented in .Net 2.x
        
        // Open the serial port for communication
        private SerialPort Open_Serial_Port()
        {
            try
            {
                SerialPort thePort = new SerialPort("COM5", 19200, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
             // thePort.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort.ReadTimeout = 2500;
                thePort.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort.DtrEnable = true;

                thePort.Open();

                return (thePort);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port1()
        {
            try
            {
                SerialPort thePort1 = new SerialPort("COM14", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
              //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                //thePort1.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort1.ReadTimeout = 2500;
                thePort1.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort1.DtrEnable = true;
                thePort1.RtsEnable = true;

                thePort1.Open();

                return (thePort1);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port2()
        {
            try
            {
                SerialPort thePort2 = new SerialPort("COM18", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort2.ReadTimeout = 2500;
                thePort2.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort2.DtrEnable = true;
                thePort2.RtsEnable = true;

                thePort2.Open();

                return (thePort2);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port3()
        {
            try
            {
                SerialPort thePort3 = new SerialPort("COM3", 19200, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort3.ReadTimeout = 2500;
                thePort3.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort3.DtrEnable = true;

                thePort3.Open();

                return (thePort3);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port4()
        {
            try
            {
                SerialPort thePort4 = new SerialPort("COM12", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort4.ReadTimeout = 2500;
                thePort4.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort4.DtrEnable = true;
                thePort4.RtsEnable = true;

                thePort4.Open();

                return (thePort4);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port5()
        {
            try
            {
                SerialPort thePort5 = new SerialPort("COM10", 19200, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort5.ReadTimeout = 2500;
                thePort5.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort5.DtrEnable = true;
                thePort5.RtsEnable = true;

                thePort5.Open();

                return (thePort5);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port6()
        {
            try
            {
                SerialPort thePort6 = new SerialPort("COM9", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort6.ReadTimeout = 2500;
                thePort6.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort6.DtrEnable = true;
                thePort6.RtsEnable = true;

                thePort6.Open();

                return (thePort6);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port7()
        {
            try
            {
                SerialPort thePort7 = new SerialPort("COM15", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort7.ReadTimeout = 2500;
                thePort7.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort7.DtrEnable = true;
                thePort7.RtsEnable = true;

                thePort7.Open();

                return (thePort7);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port8()
        {
            try
            {
                SerialPort thePort8 = new SerialPort("COM11", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort8.ReadTimeout = 2500;
                thePort8.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort8.DtrEnable = true;
                thePort8.RtsEnable = true;

                thePort8.Open();

                return (thePort8);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port9()
        {
            try
            {
                SerialPort thePort9 = new SerialPort("COM16", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort9.ReadTimeout = 2500;
                thePort9.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort9.DtrEnable = true;
                thePort9.RtsEnable = true;

                thePort9.Open();

                return (thePort9);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port10()
        {
            try
            {
                SerialPort thePort10 = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort10.ReadTimeout = 2500;
                thePort10.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort10.DtrEnable = true;
                thePort10.RtsEnable = true;

                thePort10.Open();

                return (thePort10);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port11()
        {
            try
            {
                SerialPort thePort11 = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort11.ReadTimeout = 2500;
                thePort11.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort11.DtrEnable = true;
                //thePort11.RtsEnable = true;

                thePort11.Open();

                return (thePort11);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port12()
        {
            try
            {
                SerialPort thePort12 = new SerialPort("COM13", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort12.ReadTimeout = 2500;
                thePort12.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort12.DtrEnable = true;
                thePort12.RtsEnable = true;

                thePort12.Open();

                return (thePort12);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port13()
        {
            try
            {
                SerialPort thePort13 = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort13.ReadTimeout = 2500;
                thePort13.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort13.DtrEnable = true;
                thePort13.RtsEnable = true;

                thePort13.Open();

                return (thePort13);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private SerialPort Open_Serial_Port14()
        {
            try
            {
                SerialPort thePort14 = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);

                // This establishes an event handler for serial comm errors
                //thePort1.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPort_ErrorReceived);

                // Set a timeout just in case there's a big problem and nothing is being received.  The rest of the code should
                // take care of most problems.  The following line can be used if no timeout is desired:
                // thePort.ReadTimeout = SerialPort.InfiniteTimeout;
                thePort14.ReadTimeout = 2500;
                thePort14.WriteTimeout = 2500;

                // Set Data Terminal Ready to true - can't transmit without DTR turned on
                thePort14.DtrEnable = true;
                thePort14.RtsEnable = true;

                thePort14.Open();

                return (thePort14);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
                return (null);
            }
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs ex)
        {
            System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\SerialPort catch", ex.ToString());
        }

        // The Vantage weather station sleeps when it can to save power.  In order to get it to respond to commands, it 
        // needs to "wake up."  To wake it up, it needs to receive a '\n' (newline character).  It responds with a '\n\r'.
        // If no response arrives after 1.2 seconds (the max delay according to the Davis documentation), we try again.
        private bool Wake_Serial_Vantage(SerialPort thePort)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort.DiscardInBuffer();
                thePort.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage1(SerialPort thePort1)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort1.DiscardInBuffer();
                thePort1.DiscardOutBuffer(); 

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort1.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort1.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort1.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort1.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage2(SerialPort thePort2)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort2.DiscardInBuffer();
                thePort2.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort2.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort2.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort2.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort2.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage3(SerialPort thePort3)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort3.DiscardInBuffer();
                thePort3.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort3.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort3.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort3.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort3.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage4(SerialPort thePort4)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort4.DiscardInBuffer();
                thePort4.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort4.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort4.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort4.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort4.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage5(SerialPort thePort5)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort5.DiscardInBuffer();
                thePort5.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort5.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort5.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort5.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort5.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage6(SerialPort thePort6)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort6.DiscardInBuffer();
                thePort6.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort6.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort6.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort6.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort6.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage7(SerialPort thePort7)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort7.DiscardInBuffer();
                thePort7.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort7.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort7.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort7.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort7.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage8(SerialPort thePort8)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort8.DiscardInBuffer();
                thePort8.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort8.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort8.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort8.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort8.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage9(SerialPort thePort9)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort9.DiscardInBuffer();
                thePort9.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort9.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort9.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort9.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort9.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage10(SerialPort thePort10)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort10.DiscardInBuffer();
                thePort10.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort10.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort10.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort10.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort10.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }


            private bool Wake_Serial_Vantage11(SerialPort thePort11)
            {
                int passCount = 1,
                    maxPasses = 4;

                try
                {
                    // Clear out both input and output buffers just in case something is in there already
                    thePort11.DiscardInBuffer();
                    thePort11.DiscardOutBuffer();

                    // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                    thePort11.WriteLine("");
                    // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                    System.Threading.Thread.Sleep(1200);
                    // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                    while (thePort11.BytesToRead == 0 && passCount < maxPasses)
                    {
                        thePort11.WriteLine("");
                        // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                        System.Threading.Thread.Sleep(1200);
                        passCount += 1;
                    }

                    // Vantage found and awakened
                    if (passCount < maxPasses)
                    {
                        // Now that the Vantage is awake, clean out the input buffer again for good measure.
                        thePort11.DiscardInBuffer();
                        return (true);
                    }
                    else
                        return (false);
                }
                catch (Exception ex)
                {
                    Show_Message(ex.ToString());
                    return (false);
                }
            }

        private bool Wake_Serial_Vantage12(SerialPort thePort12)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort12.DiscardInBuffer();
                thePort12.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort12.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort12.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort12.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort12.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage13(SerialPort thePort13)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort13.DiscardInBuffer();
                thePort13.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort13.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort13.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort13.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort13.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        private bool Wake_Serial_Vantage14(SerialPort thePort14)
        {
            int passCount = 1,
                maxPasses = 4;

            try
            {
                // Clear out both input and output buffers just in case something is in there already
                thePort14.DiscardInBuffer();
                thePort14.DiscardOutBuffer();

                // Put a newline character ('\n') out the serial port - the Writeline method terminates with a '\n' of its own
                thePort14.WriteLine("");
                // Wait for 1.2 seconds - this is being very conservative - shorten if things look good
                System.Threading.Thread.Sleep(1200);
                // Now check and see if anything's been returned.  If nothing, ping the Vantage with another newline.
                while (thePort14.BytesToRead == 0 && passCount < maxPasses)
                {
                    thePort14.WriteLine("");
                    // The Vantage documentation states that 1.2 seconds is the maximum delay - wait for that amount of time
                    System.Threading.Thread.Sleep(1200);
                    passCount += 1;
                }

                // Vantage found and awakened
                if (passCount < maxPasses)
                {
                    // Now that the Vantage is awake, clean out the input buffer again for good measure.
                    thePort14.DiscardInBuffer();
                    return (true);
                }
                else
                    return (false);
            }
            catch (Exception ex)
            {
                Show_Message(ex.ToString());
                return (false);
            }
        }

        // Retrieve_Command retrieves data from the Vantage weather station using the specified command
        private byte[] Retrieve_Serial_Command(SerialPort thePort, string commandString, int returnLength)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort.WriteLine(commandString);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort.Read(loopString, 0, returnLength);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
              System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command1(SerialPort thePort1, string commandString1, int returnLength1)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort1.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort1.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort1.WriteLine(commandString1);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort1.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort1.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength1];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort1.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort1.Read(loopString, 0, returnLength1);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
              System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command2(SerialPort thePort2, string commandString2, int returnLength2)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort2.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort2.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort2.WriteLine(commandString2);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort2.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort2.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength2];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort2.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort2.Read(loopString, 0, returnLength2);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command3(SerialPort thePort3, string commandString3, int returnLength3)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort3.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort3.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort3.WriteLine(commandString3);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort3.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort3.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength3];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort3.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort3.Read(loopString, 0, returnLength3);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command4(SerialPort thePort4, string commandString4, int returnLength4)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort4.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort4.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort4.WriteLine(commandString4);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort4.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort4.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength4];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort4.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort4.Read(loopString, 0, returnLength4);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command5(SerialPort thePort5, string commandString5, int returnLength5)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort5.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort5.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort5.WriteLine(commandString5);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort5.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort5.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength5];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort5.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort5.Read(loopString, 0, returnLength5);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command6(SerialPort thePort6, string commandString6, int returnLength6)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort6.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort6.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort6.WriteLine(commandString6);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort6.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort6.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength6];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort6.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort6.Read(loopString, 0, returnLength6);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command7(SerialPort thePort7, string commandString7, int returnLength7)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort7.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort7.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort7.WriteLine(commandString7);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort7.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort7.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength7];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort7.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort7.Read(loopString, 0, returnLength7);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command8(SerialPort thePort8, string commandString8, int returnLength8)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort8.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort8.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort8.WriteLine(commandString8);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort8.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort8.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength8];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort8.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort8.Read(loopString, 0, returnLength8);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command9(SerialPort thePort9, string commandString9, int returnLength9)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort9.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort9.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort9.WriteLine(commandString9);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort9.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort9.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength9];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort9.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort9.Read(loopString, 0, returnLength9);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command10(SerialPort thePort10, string commandString10, int returnLength10)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort10.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort10.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort10.WriteLine(commandString10);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort10.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort10.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength10];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort10.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort10.Read(loopString, 0, returnLength10);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command11(SerialPort thePort11, string commandString11, int returnLength11)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort11.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort11.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort11.WriteLine(commandString11);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort11.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort11.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength11];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort11.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort11.Read(loopString, 0, returnLength11);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command12(SerialPort thePort12, string commandString12, int returnLength12)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort12.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort12.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort12.WriteLine(commandString12);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort12.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort12.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength12];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort12.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort12.Read(loopString, 0, returnLength12);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command13(SerialPort thePort13, string commandString13, int returnLength13)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort13.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort13.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort13.WriteLine(commandString13);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort13.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort13.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength13];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort13.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort13.Read(loopString, 0, returnLength13);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private byte[] Retrieve_Serial_Command14(SerialPort thePort14, string commandString14, int returnLength14)
        {
            bool Found_ACK = false;
            int ACK = 6,        // ASCII 6
                passCount = 1,
                maxPasses = 4;
            int currChar;

            try
            {
                // Clean out the input (receive) buffer just in case something showed up in it
                thePort14.DiscardInBuffer();
                // . . . and clean out the output buffer while we're at it for good measure
                thePort14.DiscardOutBuffer();

                // Try the command until we get a clean ACKnowledge from the Vantage.  We count the number of passes since
                // a timeout will never occur reading from the sockets buffer.  If we try a bunch of times (maxPasses) and
                // we get nothing back, we assume that the connection is busted
                while (!Found_ACK && passCount < maxPasses)
                {
                    thePort14.WriteLine(commandString14);
                    // I'm using the LOOP command as the baseline here because many its parameters are a superset of
                    // those for other commands.  The most important part of this is that the LOOP command is iterative
                    // and the station waits 2 seconds between its responses.  Although it's not clear from the documentation, 
                    // I'm assuming that the first packet isn't sent for 2 seconds.  In any event, the conservative nature
                    // of waiting this amount of time probably makes sense to deal with serial IO in this manner anyway.
                    System.Threading.Thread.Sleep(2000);

                    // Wait for the Vantage to acknowledge the the receipt of the command - sometimes we get a '\n\r'
                    // in the buffer first or nor response is given.  If all else fails, try again.
                    while (thePort14.BytesToRead > 0 && !Found_ACK)
                    {
                        // Read the current character
                        currChar = thePort14.ReadChar();
                        if (currChar == ACK)
                            Found_ACK = true;
                    }

                    passCount += 1;
                }

                // We've tried a bunch of times and have heard nothing back from the port (nothing's in the buffer).  Let's 
                // bounce outta here
                if (passCount == maxPasses)
                    return (null);
                else
                {
                    // Allocate a byte array to hold the return data that we care about - up to, but not including the '\n'
                    // Size the array according to the data passed to the procedure
                    byte[] loopString = new byte[returnLength14];

                    // Wait until the buffer is full - we've received returnLength characters from the LOOP response, 
                    // including the final '\n' 
                    while (thePort14.BytesToRead <= loopString.Length)
                    {
                        // Wait a short period to let more data load into the buffer
                        System.Threading.Thread.Sleep(200);
                    }

                    // Read the first returnLength bytes of the buffer into the array
                    thePort14.Read(loopString, 0, returnLength14);

                    return loopString;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", ex.ToString());
                return null;
            }
        }

        private void Show_Message(string msgString)
        {
         // File.WriteAllText(@"C:\Users\admin\Desktop\WriteText.txt", msgString);
        }
    }
}