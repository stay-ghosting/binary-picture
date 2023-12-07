using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumber
{
    class BaseNumber
    {


        //              fields/properties


        static readonly string NUMBERS_IN_ORDER = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        readonly int numberOfBase;
        protected int NumberOfBase { get => numberOfBase; }

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
                    if (!NUMBERS_IN_ORDER.Contains(number))
                        throw new Exception("Hex 01: input not in correct form.");
                    else if (NUMBERS_IN_ORDER.IndexOf(number) >= NumberOfBase)
                        throw new Exception("Hex 02: input not in correct form.");
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
                    // from end to start convert each number from hex 0-Z to 0-9 form
                    string number = value[Value.Length - 1 - i].ToString();
                    int numberInDenary = NUMBERS_IN_ORDER.IndexOf(number);
                    // get value of that number in denary
                    int valueOfNumber = numberInDenary * (int)Math.Pow(NumberOfBase, i);
                    // accumualate value into denary
                    denary += valueOfNumber;
                }
                return denary;
            }
        }



        //              constucters



        public BaseNumber(string value, int numberOfBase)
        {
            this.numberOfBase = numberOfBase;
            this.Value = value;
        }

        public BaseNumber(int denary, int numberOfBase)
        {
            this.numberOfBase = numberOfBase;
            this.Value = DenaryToBaseNumber(denary, numberOfBase);
        }

        public BaseNumber(BaseNumber baseNumber, int numberOfBase) : this(baseNumber.DenaryValue, numberOfBase) { }


        //              methods


        ///<remarks> uses the base number from instance</remarks>
        //public string DenaryToBaseNumber(int denary)
        //{
        //    string baseNumber = DenaryToBaseNumber(denary, NumberOfBase);
        //    return baseNumber;
        //}

        public static string DenaryToBaseNumber(int denary, int NumberOfBase)
        {
            // easy solution
            if (denary == 0)
                return "0";

            // create an empty string to get populated and returned
            string baseNumber = "";
            // number of times max power goes into denary
            int number;

            // used to get differences between powers for zero padding
            int lastPowerOfNumber;

            lastPowerOfNumber = (int)Math.Floor(Math.Log(denary, NumberOfBase));

            while (denary > 0)
            {
                // the max power that goes into denary
                int maxPowOfBase = (int)Math.Floor(Math.Log(denary, NumberOfBase));
                // the max powers value 
                int maxPowValue = (int)Math.Pow(NumberOfBase, maxPowOfBase);

                // value of 0-z number
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
                // find how many placeholders to pad
                int NumberOfPlaceholdersToPad = Math.Clamp(lastPowerOfNumber - maxPowOfBase - 1, 0, int.MaxValue);
                // padding them
                baseNumber += new string('0', NumberOfPlaceholdersToPad);
                // accumulates the base number value value
                baseNumber += NUMBERS_IN_ORDER[number];
                // used to get differences between powers for zero padding
                lastPowerOfNumber = maxPowOfBase;
            }

            baseNumber += new string('0', lastPowerOfNumber);

            // returns value
            return baseNumber;
        }


        public List<string> ToChunks(int chunkSize)
        {

            // create temp variable for creating chunks
            string currentChunk;
            // where all the chunks are stored
            List<string> chunks = new List<string>();

            // loops in chunk sizes form end to start
            for (int i = this.Value.Length - chunkSize; i > -chunkSize; i -= chunkSize)
            {
                // if on last cunk and there is less then chunk size values...
                if (i < 0)
                {
                    // zero pads to make a full chunk
                    string zeroPad = new string('0', Math.Abs(i));
                    currentChunk = zeroPad + this.value.Substring(0, chunkSize + i);
                }
                else
                {
                    // takle a chunk out 
                    currentChunk = this.value.Substring(i, chunkSize);
                }

                // puts chunk into list of nibbles
                chunks.Insert(0, currentChunk);
            }

            return chunks;
        }
    }

    class Hex : BaseNumber
    {
        //              constructers

        public Hex(string hexValue) : base(hexValue, 16) { }

        public Hex(int denary) : base(denary, 16) { }

        public Hex(BaseNumber baseNumber) : base(baseNumber, 16) { }
    }

    class Binary : BaseNumber
    {
        //              constructers

        public Binary(string binaryValue) : base(binaryValue, 2) { }

        public Binary(int denary) : base(denary, 2) { }

        public Binary(BaseNumber baseNumber) : base(baseNumber, 2) { }
    }
}
