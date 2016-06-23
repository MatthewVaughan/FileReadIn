using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj11
{
    class Resistance
    {
        private double specifiedResistance;
        private double specifiedPower;
        private double[] voltages;
        private int index;

        public Resistance(string data)
        {
            //Save the data input and split the data received
            string[] inputs = data.Split();

            specifiedResistance = double.Parse(inputs[0]);
            specifiedPower = double.Parse(inputs[1]);

            voltages = new double[50];
            index = 0;
        }

        public void AddDate(string input)
        {
            voltages[index++] = double.Parse(input);
        }

        public int GetLength()
        {
            return index;
        }

        public double GetPowerDissipated(int i)
        {
            return voltages[i] * voltages[i] / specifiedResistance;
        }

        public string GetTestPassFail(int i)
        {
            if (GetPowerDissipated(i) > specifiedPower)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
