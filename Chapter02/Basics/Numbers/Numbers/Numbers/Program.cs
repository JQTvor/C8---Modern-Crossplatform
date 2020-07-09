
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            void TEL()
            {
                WriteLine();
                WriteLine();
            }

            void StoringNumbers()
            {
                //unsigned integer means positive whole number
                //including 0
                uint naturalNumber = 23;

                //integer means negative or positive whole number
                //including 0
                int integerNumber = -23;

                //float mean single-percision floathing point
                //F suffix makes it a float literal
                float realNumber = 2.3F;

                //Double means double precision floating point 
                double anotherRealNumber = 2.3; // double literal

                //three variables that store 2 million
                int decimalNotation = 2_000_000;
                int bionaryNotation = 0b_0001_1110_1000_0100_1000_0000;
                int hexadecimalNotation = 0x_001E_8480;

                //Check the three variables have the same value both statements output is true
                WriteLine($"{decimalNotation == bionaryNotation}");
                WriteLine($"{decimalNotation == hexadecimalNotation}");
            }
            TEL();
            StoringRealNumbers();

            void StoringRealNumbers()
            {
                WriteLine($"int uses {sizeof(int)} bytes and can store " +
                    $"numbers in the rang {int.MinValue:N0} to {int.MaxValue:N0}.");

                WriteLine($"Double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");

                WriteLine($"Decimal uses { sizeof(decimal)} bytes and can " +
                    $"store numbers in the rang of {decimal.MinValue:N0} to " +
                    $"{decimal.MaxValue:N0}");
            }
            TEL();
            ComparingDoubleAndDecimal2();

            void ComparingDoubleAndDecimal2()
            {
                WriteLine("Using decimals:");
                decimal a = 0.1M; //M suffix means a decimal literal value.
                decimal b = 0.2M;
                if (a + b == 0.3M)
                    WriteLine($"{a} + {b} equals 0.3");

                else
                    WriteLine($"{a} + {b} does NOT equal 0.3");

            }
            TEL();
            ComparingDoubleAndDecimal();

            void ComparingDoubleAndDecimal()
            {
                WriteLine("Using doubles:");
                double a = 0.1;
                double b = 0.2;
                if (a + b == 0.3)
                    WriteLine($"{a} + {b} equals 0.3");

                else
                    WriteLine($"{a} + {b} does NOT equal 0.3");

            }
            TEL();
            StoringAnyTypeOfObject();

            void StoringAnyTypeOfObject()
            {
                object height = 1.88; //storing a double in a object
                object name = "Amir"; //storing a string in an object
                WriteLine($"{name} is {height} metres tall.");
                //int length1 = name.Length;
                int lenght2 = ((string)name).Length; //tell compiler it is a string
                WriteLine($"{name} has {lenght2} characters.");
            }
            TEL();
            StoringDynamicTypes();


            void StoringDynamicTypes()
            {
                //storing a string in a dynamic object
                dynamic anotherName = "Ahmed";

                //This Compiles but would throw an exception at run-time
                //If you later store a data type that does not have a property length
                // It does throw! int length = anotherName.length;
            }
            TEL();
            DeclaringLocalVariables();

            void DeclaringLocalVariables()
            {
                int population = 66_000_000;//66 million in UK
                double weight = 1.88; //in kilograms
                decimal price = 4.99M; // in pounds sterling
                string fruit = "Apples"; //string uses double-quotes
                char letter = 'Z'; //chars have a single quote.
                bool happy = true; //Booleans have either true or false.
            }

            DeclaringLocalVariables2();

            void DeclaringLocalVariables2()
            {
                var population = 66_000_000;//66 million in UK
                var weight = 1.88; //in kilograms
                var price = 4.99M; // in pounds sterling
                var fruit = "Apples"; //string uses double-quotes
                var letter = 'Z'; //chars have a single quote.
                var happy = true; //Booleans have either true or false.
            }

            GettingDefaultValuesForTypes();

            void GettingDefaultValuesForTypes()
            {
                WriteLine($"default(int) = {default(int)}");
                WriteLine($"default(bool) = {default(bool)}");
                WriteLine($"default(DateTime) = {default(DateTime)}");
                WriteLine($"Default(string) = {default(string)}");

            }
            TEL();
            StoringMultipleValues();

            void StoringMultipleValues()
            {
                string[] names; //can rreference any array of strings.

                //Allocating memory for four strings in an array
                names = new string[4];

                //storing items at index positions
                names[0] = "Kate";
                names[1] = "Jack";
                names[2] = "Rebecca";
                names[3] = "Tom";

                //Looping through the names
                for (int i = 0; i < names.Length; i++)
                {
                    //Output the names
                    WriteLine(names[i]);
                }

            }
            TEL();
            WorkingWithNullItems();



            void WorkingWithNullItems()
            {
                int thisCannotBeNull = 4;
                //thisCannotBeNull = null; //Compile Error!
                int? thisCouldBeNull = null;
                WriteLine(thisCouldBeNull);
                WriteLine(thisCouldBeNull.GetValueOrDefault());
                thisCouldBeNull = 7;
                WriteLine(thisCouldBeNull);
                WriteLine(thisCouldBeNull.GetValueOrDefault());
            }
            TEL();
            Formatting();

            //Page 58 - 59
            void Formatting()
            {
                int numberOfApples = 12;
                decimal pricePerApple = 0.35M;
                WriteLine(
                    format: "{0} apples cost {1:C}",
                    arg0: numberOfApples,
                    arg1: pricePerApple * numberOfApples);
                string formatted = string.Format(
                    format: "{0} apples cost {1:C}",
                    arg0: numberOfApples,
                    arg1: pricePerApple * numberOfApples);
                //WriteToFile(Formatted); //Writes the string into a file.

                WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");
            }
            TEL();
            UnderstandingFormatStrings();


            //Page 60 
            void UnderstandingFormatStrings()
            {
                string applesText = "Apples";
                int applesCount = 1234;
                string bananasText = "Bananas";
                int bananasCount = 56789;
                WriteLine(
                    format: "{0,-8} {1,6:N0}",
                    arg0: "Name",
                    arg1: "Count");
                WriteLine(
                    format: "{0, -8} {1,6:N0}",
                    arg0: applesText,
                    arg1: applesCount);
                WriteLine(
                    format: "{0,-8} {1,6:N0}",
                    arg0: bananasText,
                    arg1: bananasCount);

            }
            TEL();
            UserInput();

            //Page 61
            void UserInput()
            {
                Write("Type your first name and press ENTER: ");
                string firstName = ReadLine();

                Write("Type your age and press ENTER: ");
                string age = ReadLine();

                WriteLine(
                    $"Hello {firstName}, you look good for {age}.");
            }
            TEL();
            GettingKeyInput();

            //Page 62
            void GettingKeyInput()
            {
                Write("Press any key combination: ");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();
                WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                    arg0: key.Key,
                    arg1: key.KeyChar,
                    arg2: key.Modifiers);
            }
            TEL();
            Arguements();

            //Page 64
            void Arguements()
            {
                WriteLine($"There are {args.Length} arguments.");
            }
            TEL();
            SettingsOptionsWithArgs();

            void SettingsOptionsWithArgs()
            {
                if (args.Length < 4)
                {
                    WriteLine("You must specify two colors and dimensions, e.g.");
                    WriteLine("dotnet run red yellow 80 40");
                    return;//stop running
                }
                ForegroundColor = (ConsoleColor)Enum.Parse(
                    enumType: typeof(ConsoleColor),
                    value: args[0],
                    ignoreCase: true);
                BackgroundColor = (ConsoleColor)Enum.Parse(
                    enumType: typeof(ConsoleColor),
                    value: args[1],
                    ignoreCase: true);
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[3]);

            }
            TEL();
            exercise2_2();

            //Exercise2.2 - Practice number sizes and ranges
            void exercise2_2()
            {
                //Create a conole application project that outputs the numbers of bytes in memory that each of the following
                //Number types use, and the minimum and maximum values they can have:
                //sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

                Write(
                    format: "{0} {1, 6} {2,15}",
                    arg0: "Name",
                    arg1: "Byte",
                    arg2: "Max");
                WriteLine(
                    format: " {0, 35}",
                    arg0: "Max");

                
                Write(
                 format: "{0} {1, 6} {2,15}",
                    arg0: "sbyte",
                    arg1: sizeof(sbyte),
                    arg2: sbyte.MinValue);
                WriteLine(
                    format: " {0, 35}",
                    arg0: sbyte.MaxValue);

                Write(
                 format: "{0} {1, 6} {2,15}",
                    arg0: "byte",
                    arg1: sizeof(byte),
                    arg2: byte.MinValue);
                WriteLine(
                    format: " {0, 35}",
                    arg0: byte.MaxValue);




            }   




            ReadLine();
        }
    }
}
