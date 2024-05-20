using System.Text;
using System.Linq;

namespace _21.StringMethods
{
    internal class Program
    {
        // Learn all methods we can use on string data type.
        /*
                In C#, string and String are effectively the same, as string is an alias for System.String.
                Therefore, all the methods available for string are also available for String. 
                The String class provides a rich set of methods for various string operations. 
                Here are some of the commonly used methods in the String class:
         */
        static void Main(string[] args)
        {
            string s1 = "Hi my name is sourabh";
            string s2 = "I am a software engineer";

            Console.WriteLine("-------------------String or string------------------");

            //1 string Split
            string[] val1 = s1.Split(' ');
            Console.WriteLine("1 string Split");
            foreach (string val in val1) Console.Write(val+", ");

            //2. string Concate
            Console.WriteLine("\n2. string Concate");
            Console.WriteLine(string.Concat(s1," ",s2));

            //3 string.Format
            string result = string.Format("Hello there {0} and {1}",s1 ,s2);
            Console.WriteLine("3 string.Format");
            Console.WriteLine(result);

            //4. string.Replace
            string val2 = s2.Replace("engineer", "Developer");
            Console.WriteLine("4. string.Replace");
            Console.WriteLine(val2);

            //5. string.Substring
            string val3 = s2.Substring(7,17);
            Console.WriteLine("5. string.Substring");
            Console.WriteLine(val3);

            //6. string.Contains
            bool val4 = s2.Contains("software");
            Console.WriteLine("6. string.Contains");
            Console.WriteLine(val4);

            //7. string.Trim, string.TrimStart, string.TrimEnd
            string s3 = "      hello my name is sourabh                ";
            string trimmed = s3.Trim();
            string trimmedstart = s3.TrimStart();
            string trimmedEnd = s3.TrimEnd();
            Console.WriteLine("7. string.Trim, string.TrimStart, string.TrimEnd");
            Console.WriteLine(trimmed);
            Console.WriteLine(trimmedstart);
            Console.WriteLine(trimmedEnd);

            //8. string.ToUpper, string.ToLower
            string val5 = s1.ToUpper();
            string val6 = s2.ToLower();
            Console.WriteLine("8. string.ToUpper, string.ToLower");
            Console.WriteLine(val5);
            Console.WriteLine(val6);

            //9. string.StartsWith, string.EndsWith
            Console.WriteLine("9. string.StartsWith, string.EndsWith");
            Console.WriteLine(s1.StartsWith("Hi"));
            Console.WriteLine(s1.EndsWith("engineer"));

            //10. string.Join
            string[] array = { "Apple", "Banana", "Orange", "Graps" };
            string result3 = string.Join(", ", array);
            Console.WriteLine("10. string.Join");
            Console.WriteLine(result3);

            //11. string.Compare, string.CompareTo
            int compaire = string.Compare(s1, s2);
            Console.WriteLine("11. string.Compare, string.CompareTo");
            Console.WriteLine(compaire);

            //12. string.IndexOf, string.LastIndexOf
            Console.WriteLine("12. string.IndexOf, string.LastIndexOf");
            int index = s1.IndexOf("name");
            int indexlast = s1.LastIndexOf("sourabh");
            Console.WriteLine(index);
            Console.WriteLine(indexlast);

            //13. string.PadLeft, string.PadRight
            string pad = "Hello";
            string Padleft = pad.PadLeft(10);
            string padRight = pad.PadRight(10,'*');
            Console.WriteLine("13. string.PadLeft, string.PadRight");
            Console.WriteLine(Padleft);
            Console.WriteLine(padRight);

            //14. string.IsNullOrEmpty, string.IsNullOrWhiteSpace
            string s = " ";  // if " " have space so string is not empty, if "" now its empty.
            bool isEmpty = string.IsNullOrEmpty(s);
            // isEmpty = false
            bool isWhiteSpace = string.IsNullOrWhiteSpace(s);
            Console.WriteLine("14. string.IsNullOrEmpty, string.IsNullOrWhiteSpace");
            Console.WriteLine(isEmpty);
            Console.WriteLine(isWhiteSpace);

            //15. string.Equals
            string str1 = "Hello";
            string str2 = "hello";
            bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            // areEqual = true
            Console.WriteLine("15. string.Equals");
            Console.WriteLine(areEqual);

            //16 Insert
            string str = "Hello, World!";
            string res = str.Insert(7, "Beautiful ");
            Console.WriteLine("16.  Insert");
            Console.WriteLine(res);

            //17.  Lenght
            int length = s1.Length;
            Console.WriteLine("17.  Lenght");
            Console.WriteLine("Lenght: "+length);

            //18.  Reverse
            string Reverse = new string(s1.Reverse().ToArray());
            Console.WriteLine("18.  Reverse");
            Console.WriteLine(Reverse);


            Console.WriteLine("\n-------------------StringBuilder------------------");
            
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            //1. Append
            sb.Append("Hello ");
            sb.Append("World!");
            sb.ToString();
            Console.WriteLine("1. Append");
            Console.WriteLine(sb);

            // 2. AppendFormat
            Console.WriteLine("2. AppendFormat");
            sb2.AppendFormat("Name: {0}, Age: {1}", "Alice", 30);
            sb2.ToString();
            Console.WriteLine(sb2);

            //3. Insert
            Console.WriteLine("3. Insert");
            sb.Insert(5, ",");
            sb.ToString();
            Console.WriteLine(sb);

            //4. Remove
            Console.WriteLine("4. Remove");
            sb.Remove(5, 1); // Removes the comma
            sb.ToString();
            Console.WriteLine(sb);

            //5. Replace
            Console.WriteLine("5. Replace");
            sb.Replace("World", "C#");
            sb.ToString();
            Console.WriteLine(sb);

            //6. Length
            Console.WriteLine("6. Length");
            int len =sb.Length;
            Console.WriteLine(len);

            //7. Clear
            Console.WriteLine("7. Clear");
            sb.Clear();
            sb.ToString();
            Console.WriteLine(sb);

            //8. AppendLine
            Console.WriteLine("8. AppendLine");
            StringBuilder sb3 = new StringBuilder();
            sb3.AppendLine("First line");
            sb3.AppendLine("Second line");
            Console.WriteLine(sb3.ToString());
            // Output:
            // First line
            // Second line

            //9.  AppendJoin
            Console.WriteLine("9.  AppendJoin");
            StringBuilder sb4 = new StringBuilder();
            string[] values = { "apple", "banana", "cherry" };
            sb4.AppendJoin(", ", values);
            Console.WriteLine(sb4.ToString()); // Output: "apple, banana, cherry"



            /*

             10. ToString
             Converts the StringBuilder instance to a string.
             StringBuilder sb = new StringBuilder("Hello, World!");
             string result = sb.ToString();

             11. Capacity
             Gets or sets the capacity of the StringBuilder, 
             which is the number of characters it can hold.

             StringBuilder sb = new StringBuilder(50); // Initial capacity of 50
             int capacity = sb.Capacity;
             // capacity = 50


            */

            Console.ReadKey();
        }

        /*
        If you need to use string methods, you can convert the StringBuilder to a string, perform the operation,
        and if necessary, convert it back to a StringBuilder: 

          public static void Main()
            {
                StringBuilder sb = new StringBuilder("Hello, World!");

                // Convert to string and use string methods
                string str = sb.ToString();
                str = str.ToUpper();

                // Convert back to StringBuilder if further modifications are needed
                sb = new StringBuilder(str);
                Console.WriteLine(sb.ToString()); // Output: "HELLO, WORLD!"
            }
        */
    }
}
