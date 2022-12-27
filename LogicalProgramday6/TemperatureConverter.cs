using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    internal class TemperatureConverter
    {
        public double celciusToFahrenhiet()
        {
            double Celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenhiet = (Celcius * 9 / 5) + 3;
            return fahrenhiet;
        }
        public double fahrenhietToCelcius()
        {
            double Fahrenhiet = Convert.ToDouble(Console.ReadLine());
            double Celcius = (Fahrenhiet - 32) * 5 / 9;
            return Celcius;
        }
    }
}
