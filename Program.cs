using System.Linq;
using System.Text;
using System;
using Ex01_02;

namespace Ex01_03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the diamond's height");
            string diamondHeightStr = GetValidHeightFromUser();
            PrintDiamond(diamondHeightStr);
        }

        private static string GetValidHeightFromUser()
        {
            string inputFromUser = Console.ReadLine();
            bool isValidHeight = CheckValidHeight(inputFromUser);

            if (!isValidHeight)
            {
                Console.WriteLine("Please enter valid height");
                inputFromUser = GetValidHeightFromUser();
            }

            return inputFromUser;
        }

        private static bool CheckValidHeight(string i_InputStr)
        {
            bool isValidHeight = i_InputStr.All(char.IsDigit);

            return isValidHeight;
        }

        private static void PrintDiamond(string i_HieghtOfDiamond)
        {
            int numOfSpaces;
            int currentLine = 1;
            int diamondHeight = int.Parse(i_HieghtOfDiamond, System.Globalization.NumberStyles.Integer);
            StringBuilder asterisksSB = new StringBuilder("", diamondHeight);

            if (diamondHeight != 1)
            {
                numOfSpaces = diamondHeight / 2;
                Ex01_02.Program.PrintDiamondRecursive(asterisksSB, numOfSpaces, diamondHeight, currentLine);
            }
            else
            {
                numOfSpaces = 1;
                asterisksSB.Append("*");
                Ex01_02.Program.PrintLineWithSpacesAndAsterisks(numOfSpaces, asterisksSB);
            }
        }
    }
}