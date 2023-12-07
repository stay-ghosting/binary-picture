using System;
using System.Collections.Generic;
using BaseNumber;
// add check for correct hex format
namespace toHex
{
    class Hexx
    {
        static string hexAlphabet = "0123456789ABCDEF";
        // TODO make conversion for hex


        /// <summary> input hex returns denary(int)</summary>
        public static int ToDenaryFromHex(string hex)
        {
            // value to populate and retern
            int denary = 0;
            // find value of each number in hex adding it to denary
            foreach (char number in hex)
            {
                // make number in correct format
                string numberToSearch = number.ToString().ToUpper();
                // find value of number
                int valueOfNumber = hexAlphabet.IndexOf(numberToSearch);
                // add to denary
                denary += valueOfNumber;
            }
            return denary;
        }

        //TODO test
        public static int ToDenaryFromBinary(string binary)
        {
            // makes sure binary is in correct form
            ForceBinary(binary);
            // repete from end to start adding 1* 2^power populating denary
            int denary = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                // stores if bit at index i is "1" or "0"
                string bit = binary[-i - 1].ToString();

                int valueOfBit = int.Parse(bit) * (int)Math.Pow(2, i);
                denary += valueOfBit;
            }
            return denary;
        }

        /// <summary>input denery return binary(str)</summary>
        public static string ToBinary(int denary)
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

            return binary;
        }
        // TODO: not in correct form
        /// <summary>input hex return binary(str)</summary>
        public static string ToBinary(string hex)
        {
            // convert to denary
            int denary = ToDenaryFromHex(hex);
            // covert denary to binary
            string binary = ToBinary(denary);
            // return binary
            return binary;
        }


        /// <summary> converts denary to hex </summary>
        public static string ToHex(int denary)
        {
            string binary = ToBinary(denary);
            string hex = ToHex(binary);
            return hex;
        }
        /// <summary> converts binary to hex </summary>
        public static string ToHex(string binary)
        {
            // string to populate and return hex
            string hex = "";

            // break into 4's
            List<string> nibbles = ToNibbles(binary);

            // for each nibble of binary
            foreach (string nibble in nibbles)
            {
                // value to populate the value of whole nibble
                int nibbleInDenary = 0;

                // for letter (nibbleIndex) in nibbles
                for (int nibbleIndex = 0; nibbleIndex < nibble.Length; nibbleIndex++)
                {
                    // if theres a 1
                    if (nibble[nibbleIndex] == '1')
                        // add the coresponding power of 2
                        nibbleInDenary += (int)Math.Pow(2, nibble.Length - nibbleIndex - 1);
                }
                // adds coverts the contex of that nibble into hex 
                char currentHexNumber = hexAlphabet[nibbleInDenary];
                // accumulates that hex number to hex variable
                hex += currentHexNumber;
            }
            return hex;
        }
        
        /// <remarks>may use spaces to break up binary input</remarks>
        /// <returns>list of nibbles</returns>
        public static List<string> ToNibbles(string binary)
        {
            // remove spaces
            binary = binary.Replace(" ", "");

            // check in binary form and throwing error
            foreach (char letter in binary)
            {
                if (letter != '0' && letter != '1')
                    throw new Exception("toNibbles method: input not in correct form.");
            }

            // create temp variable for creating nibbles
            string currentNibble;
            // where all the nibbles are stored
            List<string> nibbles = new List<string>();

            // loops in 4s form end to start
            for (int i = binary.Length - 4; i > -4; i -= 4)
            {
                // if on last nibble and there is less then 4 values...
                if (i < 0)
                {
                    // zero pads to make a full nibble
                    string zeroPad = new string('0', Math.Abs(i));
                    currentNibble = zeroPad + binary.Substring(0, 4+i);
                }
                else
                {
                    // takle a nibble out 
                    currentNibble = binary.Substring(i, 4);
                }

                // puts nibble into list of nibbles
                nibbles.Insert(0, currentNibble);
            }

            return nibbles;
        }

        /// <summary> returns true if sting is in corrext binary form else false </summary>
        public static bool IsBinary(string binary)
        {
            // check in binary form and throwing error
            foreach (char letter in binary)
            {
                if (letter != '0' && letter != '1')
                    return false;
            }

            return true;
        }

        /// <summary> throws error if in incorect binary form </summary>
        public static void ForceBinary(string binary)
        {
            if(!IsBinary(binary))
                throw new Exception("binary: input not in correct form.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var a = new Binaryy(101);
            //var b = a.DenaryValue;
            //var c = new Hexxx(240);
            //var d = c.DenaryValue;

            // 1010
            var a = new Hex("f94 ad8");
            var b = new Hex(77);
            var c = new Hex(new Binary("100 1101"));
            var d = a.ToChunks(2);
        }
    }
}
