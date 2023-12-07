using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// implement hex to binary and vice versa2
namespace toHex
{


    class Binaryy
    {
        private string value;
        public string Value
        {
            get => value;

            set
            {
                // remove spaces
                string newValue = value.Replace(" ", "");

                // check every bit only contains 1s and 0s
                foreach (char bit in newValue)
                {
                    if (bit != '0' && bit != '1')
                        throw new Exception("binary: input not in correct form.");
                }
                this.value = newValue;
            }
        }

        public int DenaryValue
        {
            get
            {
                // repete from end to start adding 1* 2^power populating denary
                int denary = 0;

                for (int i = 0; i < this.value.Length; i++)
                {
                    // stores if bit at index i is "1" or "0"
                    int currentBitIndex = this.value.Length - i - 1;
                    string bit = this.value[currentBitIndex].ToString();

                    int valueOfBit = int.Parse(bit) * (int)Math.Pow(2, i);
                    denary += valueOfBit;
                }
                return denary;
            }
        }


        //          constructers
        public Binaryy(string binary)
        {
            this.Value = binary;
        }

        public Binaryy(int denary)
        {
            // create an empty string to get populated and returned
            string binary = "";

            // used to calculate the highest pow of 2 that goes into denary values
            int powerOf2 = 0;
            int maxPowOf2 = 0;

            // find max power of 2 that fits into original value
            while (Math.Pow(2, maxPowOf2) < denary)
            {
                maxPowOf2 += 1;
            }
            maxPowOf2 -= 1;

            // populating string for binary
            powerOf2 = maxPowOf2;

            // for each power of 2 from maxPowOf2 to 0
            for (int i = powerOf2; i > -1; i--)
            {
                // if powOf2 fits...
                int newValue = denary - (int)Math.Pow(2, powerOf2);
                if (newValue >= 0)
                {
                    // take it away from value and place 1
                    binary += "1";
                    denary = newValue;
                }
                else
                {
                    // else place 0
                    binary += "0";
                }
                powerOf2--;
            }

            // sets value
            this.Value = binary;
        }
    }

    class Hexxx
    {
        static readonly string HEX_NUMBERS = "0123456789ABCDEF";

        private string value;
        public string Value
        {
            get => value;

            set
            {
                // remove spaces make uppercase
                string newValue = value.Replace(" ", "").ToUpper();

                // check every number only contains 1s and 0s
                foreach (char number in newValue)
                {
                    if (!HEX_NUMBERS.Contains(number))
                        throw new Exception("Hex: input not in correct form.");
                }
                this.value = newValue;
            }
        }

        public int DenaryValue
        {
            get
            {
                // value to populate and retern
                int denary = 0;

                // for every number in hex value...
                for (int i = 0; i < Value.Length; i++)
                {
                    // from end to start convert each number from hex a-f to 0-9 form
                    string number = value[Value.Length - 1 - i].ToString();
                    int numberInDenary = HEX_NUMBERS.IndexOf(number);
                    // get value of that number in denary
                    int valueOfNumber = numberInDenary * (int)Math.Pow(16, i);
                    // accumualate value into denary
                    denary += valueOfNumber;
                }
                return denary;
            }
        }
        

        //          constructers
        public Hexxx(string hex)
        {
            Value = hex;
        }

        public Hexxx(int denary)
        {
            // create an empty string to get populated and returned
            string hex = "";
            // number of times max power goes into denary
            int number;
            // TODO try number f

            while (denary > 0)
            {
                // the max power that goe into denary
                var a = Math.Log(denary, 16);
                int maxPowOf16 = (int)Math.Floor(Math.Log(denary, 16));
                // the max powers value 
                int maxPowValue = (int)Math.Pow(16, maxPowOf16);

                // value of 0-16 number
                int valueOfNumber;
                // if power is 0...
                if (maxPowValue == 0)
                {
                    number = denary;
                    // value of number is denary
                    valueOfNumber = denary;
                }
                else
                {
                    // number of times max power goes into denary 0-16
                    number = (int)Math.Floor((double)denary / (maxPowValue));
                    // value of number to be subtracted
                    valueOfNumber = number * maxPowValue;
                }

                // subtract that value from senary
                denary -= valueOfNumber;
                // accumulates the hex value
                hex += HEX_NUMBERS[number];
            }

            // sets value of this class
            this.Value = hex;
        }
    }
}
