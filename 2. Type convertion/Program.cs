using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Numerics;

namespace Type_convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------TYPE_CONVERSION----------------------------------------");
            // CONVERSION----------------------------------------------
            // impicite convertion // when we store small datatype value into large datatype 
            double num3;
            int num4 = 12345664;
            num3= num4;
            Console.WriteLine(num3);

            // expicite convertion 
            // convert large data type into smaller data type. like 8 byte to 4 byte
            // convet one data type to other datatype. is call expicite convertion
            // convert double into integer or float to integer 
            double num2 = 2.540;
            float num6 = 2342.34f;
            int num1 , num7;
            num7 = (int)num6;
            num1 = (int)num2;
            Console.WriteLine(num1);    
            Console.WriteLine(num7);

            //Convert any datatype into string formate 
            string s1 = num6.ToString();
            string s2 = num4.ToString();
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            // convert string to interger or any other data type using parse
            //datatype variable = DataType.parce(string); //formula
            string s3 = "15";
            string s4 = "10";
            Console.WriteLine(s3+s4); 

            int numm = Int32.Parse(s3);
            int nunn = Int32.Parse(s4);
            int nunm = numm + nunn;
            Console.WriteLine(nunm);

            // string convert into toher data type using TryParse
            // syntax  int.TryParse(String , out store variable)
            string numberAsString = "1234";
            int parsevalue;
            bool Success = int.TryParse(numberAsString,out parsevalue);
            if(Success) { Console.WriteLine($"Parsing successful number is : {parsevalue}"); }
            else { Console.WriteLine("Parsing failed"); }

            string ss1 = "552.621";
            double d1 = double.Parse(ss1);
            Console.WriteLine(d1);
            //int n1 = Int32.Parse(ss1); 
            //Console.WriteLine(n1);

            int  myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.WriteLine("--------------------STRING MANIPULATION---------------------------------------");

            //STRING MANIPULATION  ----------------------------------- 
            int age = 20;
            string Name = "Sourah";
            String job = "Developer";

            // 1. string concetination
            Console.WriteLine("Hello My Name Is " + Name + " and I am " + age + " year old.");

            //2. string formating
            // String formatting uses Index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello My Name Is {0} and I am {1} year old. I'm a {2}.",Name,age,job);

            // 3. String Interpolation.
            //string interpolation uses $ sign at the Start  which will allow us to 
            // write our variable like this{Variable}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello My Name Is {Name} and I am {age} year old.");

            //4. Verbatim strings.
            // verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, \n \n 
             /T /n Scape character does not work in this type of string 
             ------
             Even it print Exect same formate");

            // instead of using \\ to write file paths we can use verbatim strings to make it easier
            // if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog. png");
            Console.WriteLine("-----------------------VARIOUS STRING METHOD------------------------------------");

            // VARIOUS STRING METHOD -------------------------------------------

            // SubString(int32) - is used to get the Substring from the string, starting from the specified index.
            // ToLower()  is used to convert the string to lowercase.
            // ToUpper() is used to convert the string to uppercase.
            // Trim() is used to trim all leading and trailing white space from the string. Remove extra white space 
            // IndexOf(string) — is used to get the first occurrence of the string or character inside the string.
            // IsNullOrWhiteSpace returns true if the string is either null or is blank else it returns false.

            string FirstName = "Sourabh";
            string LastName = "Shakya";
            string FullName =string.Concat(" ",FirstName,LastName," "); //Add extra space 
            Console.WriteLine(FullName);
            Console.WriteLine(FirstName.Substring(2));
            Console.WriteLine(LastName.ToLower());
            Console.WriteLine(LastName.ToUpper());
            Console.WriteLine(FullName.Trim());
            Console.WriteLine(FirstName.IndexOf('u'));
            Console.WriteLine(String.IsNullOrWhiteSpace(FirstName)); //False

            // In C# the String.Format method is used to insert the object or variable value inside any string.
            // With the String.Format we can replace the value in the specified format.
            // Syntax: String.Format("any string {index}",object); 
            var name = "Sourabh";
            Console.WriteLine(String.Format("My name is {0}", name)); //Here the string name will be replaced at
            //Index {0} in the string and the output will be "My name is Denis".

            Console.WriteLine("---------------String.Format--------------------------------------------");
            string MyName;
            Console.WriteLine("Please Enter your full name and press Enter: ");
            MyName= Console.ReadLine();

            string MyNameUpperCase = String.Format("Upper Case {0} ", MyName.ToUpper());
            string MyNameLowerCase = String.Format("Lower Case {0} ",MyName.ToLower());
            string MyNameTrimmed = String.Format("Trimmed {0} ",MyName.Trim());
            string MyNameSubstring = String.Format("SubString {0} ", MyName.Substring(0, 6));
            //string test = ("Testing {0}",MyName.ToUpper());  // give error cannot convert implicitily

            Console.WriteLine(MyNameSubstring);
            Console.WriteLine(MyNameUpperCase);
            Console.WriteLine(MyNameLowerCase);
            Console.WriteLine(MyNameTrimmed);

            Console.Read();
        }
    }
}