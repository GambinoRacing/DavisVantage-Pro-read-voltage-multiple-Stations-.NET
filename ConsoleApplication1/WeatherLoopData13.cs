using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WeatherLoopData13
    {
        private int barTrend = 0,
                 currWindSpeed = 0,
                 avgWindSpeed = 0,
                 insideHumidity = 0,
                 outsideHumidity = 0,
                 windDirection = 0;

        private float voltage = 0;

        private bool transmitter = true;

        private float barometer = 0.0F,
                      insideTemp = 0.0F,
                      outsideTemp = 0.0F,
                      dayRain = 0.0F;
        private DateTime sunRise = DateTime.Now,
                         sunSet = DateTime.Now;

        public int BarometricTrend { get { return barTrend; } }

        public int CurrentWindSpeed { get { return currWindSpeed; } }

        public int AvgWindSpeed { get { return avgWindSpeed; } }

        public int InsideHumidity { get { return insideHumidity; } }

        public int OutsideHumidity { get { return outsideHumidity; } }

        public float Barometer { get { return barometer; } }

        public float InsideTemperature { get { return insideTemp; } }

        public float OutsideTemperature { get { return outsideTemp; } }

        public float DailyRain { get { return dayRain; } }

        public int WindDirection
        {
            get { return windDirection; }

        }

        public void Load(byte[] loopArray13)
        {

            int hours,
               minutes;
            string timeString;
            DateTime currTime;

            /*
            barTrend = Convert.ToInt32((sbyte)loopArray[3]);                    // Sbyte - signed byte
            barometer = (float)(BitConverter.ToInt16(loopArray, 7)) / 1000;     // Uint16
            insideTemp = (float)(BitConverter.ToInt16(loopArray, 9)) / 10;      // Uint16
            insideHumidity = Convert.ToInt32(loopArray[11]);                    // Byte - unsigned byte
            outsideTemp = (float)(BitConverter.ToInt16(loopArray, 12)) / 10;    // Uint16
            outsideHumidity = Convert.ToInt32(loopArray[33]);                   // Byte - unsigned byte
            windDirection = BitConverter.ToInt16(loopArray, 16);                // Uint16
            currWindSpeed = Convert.ToInt32(loopArray[14]);                     // Byte - unsigned byte
            avgWindSpeed = Convert.ToInt32(loopArray[15]);                      // Byte - unsigned byte
            dayRain = (float)(BitConverter.ToInt16(loopArray, 50)) / 100;       // Uint16
            */
            voltage = (float)BitConverter.ToInt16(loopArray13, 87) * 300 / 512 / 100; //Тока на конзолата

            //transmitter = BitConverter.ToBoolean(loopArray, 86); //Йок ?



            // get the current date and time
            currTime = DateTime.Now;

            // Time from the Vatnage is all in 24-hour format.  I move it into a string so I can manipulate it 
            // more easily.
            timeString = BitConverter.ToInt16(loopArray13, 91).ToString();    // Uint16
            // Exract hours and minutes and convert them to integers - required by Datetime
            hours = Convert.ToInt32(timeString.Substring(0, timeString.Length - 2));
            minutes = Convert.ToInt32(timeString.Substring(timeString.Length - 2, 2));
            // Create a new Datetime instance - use surrent year, month and day
            sunRise = new DateTime(currTime.Year, currTime.Month, currTime.Day, hours, minutes, 0);

            timeString = BitConverter.ToInt16(loopArray13, 93).ToString();    // Uint16
            hours = Convert.ToInt32(timeString.Substring(0, timeString.Length - 2));
            minutes = Convert.ToInt32(timeString.Substring(timeString.Length - 2, 2));
            sunSet = new DateTime(currTime.Year, currTime.Month, currTime.Day, hours, minutes, 0);
        }

        public string DebugString()
        {

            StringBuilder outputString = new StringBuilder();

            // Format the string for output
            //outputString.Append("Barometer: " + barometer.ToString("f2") + "in. " + BarTrendText() + Environment.NewLine);
            /*
             outputString.Append("Inside Temp in F: " + insideTemp.ToString() + Environment.NewLine);
             outputString.Append("Inside Humidity: " + insideHumidity.ToString() + "%" + Environment.NewLine);
             outputString.Append("Outside Temp: " + outsideTemp.ToString() + Environment.NewLine);
             outputString.Append("Outside Humidity: " + outsideHumidity.ToString() + "%" + Environment.NewLine);
             //  outputString.Append("Wind Direction: " + WindDirectionText() + " @ " + windDirection.ToString() + " degrees" + Environment.NewLine);
             outputString.Append("Current Wind Speed: " + currWindSpeed.ToString() + "MPH" + Environment.NewLine);
             outputString.Append("10 Minute Average Wind Speed: " + avgWindSpeed.ToString() + "MPH" + Environment.NewLine);
             outputString.Append("Daily Rain: " + dayRain.ToString() + "in" + Environment.NewLine);
             outputString.Append("Sunrise: " + sunRise.ToString("t") + Environment.NewLine);
             outputString.Append("Sunset: " + sunSet.ToString("t") + Environment.NewLine);
             outputString.Append("Voltage: " + voltage.ToString() + Environment.NewLine);
             outputString.Append("Transmitter Voltage: " + transmitter.ToString() + Environment.NewLine);
             */
            File.AppendAllText(@"D:\Davis\Zlatitsa.txt", "Station - 64137, Date: " + DateTime.Now + ", Voltage: " + Convert.ToString(voltage) + " V" + Environment.NewLine);

            return (outputString.ToString());
        }
        /*
        private string BarTrendText()
        {
        throw new NotImplementedException();
        }
        
        private string WindDirectionText()
        {
            throw new NotImplementedException();
        }
        */
        public float BatteryVoltage { get { return voltage; } }

        public bool TransmitterVoltage { get { return transmitter; } }


        public DateTime SunRise { get { return sunRise; } }

        public DateTime SunSet { get { return sunSet; } }

        // Load - dissassembles the byte array passed in and loads it into local data that the accessors can use.
        // Actual data is in the format to the right of the assignments - I convert it to make it easier to use
        // When bytes have to be assembled into 2-byte, 16-bit numbers, I convert two bytes from the array into 
        // an Int16 (16-bit integer).  When a single byte is all that's needed, I just convert it to an Int32.
        // In the end, all integers are cast to Int32 for return.
    }
}
