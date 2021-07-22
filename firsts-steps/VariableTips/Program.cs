using System;

namespace VariableTips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Majulia";
            char genre = 'F';
            int age = 21;
            double stature = 1.58;

            Console.WriteLine("Name: " + name + ", genre: " + genre + ", age: " + age + " and stature is: " + stature);

            // basic int tips in C#
            byte from = 0;
            byte to = 255;

            sbyte from1 = -128;
            sbyte to1 = 127;

            short from2 = -32768 ;
            short to2 = 32767;

            ushort from3 = 0;
            ushort to3 = 65535;

            int from4 = -2147483648;
            int to4 = 2147483647;

            uint from5 = 0;
            uint to5 = 4294967295;

            long from6 = -9223372036854775808;
            long to6 = 9223372036854775807;

            ulong from7 = 0;
            ulong to7 = 18446744073709551615;

            //basil real tips in C#

            float from8 = -3.4028230e38F;
            float to8 = 3.4028230e38F;

            double from9 = -1.79769313486232;
            double to9 = 1.79769313486232;

            decimal from01 =  -79228162514264337593543950335M;
            decimal to01 = 79228162514264337593543950335M;

            char uniCode = 'U';
            string phrase = "A string of unicode characters";
            bool zeroOrOne = false;
            bool oneOrZero = true;
            object anObject = ["something", "like", "this"];






        }
    }
}
