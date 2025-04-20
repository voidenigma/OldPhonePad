using System;
using System.Collections.Generic;

namespace OldPhonePadApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OldPhonePad("33#");
            OldPhonePad("227*#");
            OldPhonePad("4433555 555666#");
            OldPhonePad("8 88777444666*664#");
            OldPhonePad("66666555555333333#");
            OldPhonePad("01");
        }

        public static Dictionary<char, string> letterMapping = new Dictionary<char, string>
        {
            {'1', "&'("},
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"},
            {'0', " "},
             // Assign a valid non-empty string as " " prefix so when encountering empty spaces count != 0
             // Replace it later with  ""
            {' ', "_"}
        };

        public static string OldPhonePad(string input)
        {
            List<char> result = new List<char>();
            int count = 0;

            if (input.Length > 0 && input[input.Length - 1] == '#')
            {
                // Iterate through each character in the input string except the last index
                // Omit the last character '#' as it has been checked in if condition above
                for (int i = 0; i < input.Length - 1; i++)
                {
                    char c = input[i];

                    // Check if the current input character exists in the letterMapping dictionary
                    // Ensure input is checked early otherwise exit the loop and return "?????" as indication of incorrect input
                    if (letterMapping.ContainsKey(c))
                    {
                        // Check if the next character is the same as the current one
                        if (i + 1 < input.Length && input[i] == input[i + 1])
                        {
                            // Count consecutive characters
                            count++;
                        }
                        else
                        {
                            // Append the letter based on the count
                            string letters = letterMapping[c];
                            if (count >= letters.Length)
                            {
                                count = count - letters.Length;
                            }
                            result.Add(letters[count]);
                            // Reset the count
                            count = 0;
                        }
                    }
                    else
                    {
                        result.Clear();
                        result.AddRange("?????".ToCharArray());
                        // Exit for loop once invalid character has been verified
                        break;
                    }
                }
                // Remove placeholder '_' from the result at the end
                result.RemoveAll(c => c == '_');
            }
            else
            {
                result.Clear();
                result.AddRange("?????".ToCharArray());
            }

            // Convert the List<char> to a string to join reslut and return it
            string joinResult = new string(result.ToArray());
            Console.WriteLine($"{joinResult}");
            return joinResult;
        }
    }
}