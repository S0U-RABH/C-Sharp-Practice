namespace Arrays_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1D  ARRAYS 

            // 1st way to Declair and initialise and assign value to array
            int[] grades = new int[5];

            grades[0] = 1;
            grades[1] = 2;
            grades[2] = 3;
            grades[3] = 4;
            grades[4] = 5;

            Console.WriteLine("Grades at index 0 is {0} ", grades[0]);
            // Lenght Method.
            Console.WriteLine("The lenght of array is {0}", grades.Length);

            // 2 way to Declair and initailise and assign value to arrays
            int[] gradesOfMathsStudentA = { 1, 2, 3, 4, 5, 6, };

            // 3 way to Declair and  initailise and assign value to arrays
            int[] gradesOfMathsStudentB = new int[] { 1, 2, 3, 4, 5, 6 };

            //FOREACH LOOP

            int[] learnLoop = new int[10];

            // Inserting values in array
            for (int i = 0; i < 10; i++)
            { learnLoop[i] = i + 10; }

            // printing value from arrays
            for (int j = 0; j < learnLoop.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, learnLoop[j]);
            }

            // foreach
            Console.WriteLine("----------------------------Foreach--------------------------------------");
            int counter = 0;
            foreach (int K in learnLoop)
            {
                Console.WriteLine("Element {0} = {1}", counter++, K);
            }

            Console.WriteLine("----------------------------Foreach--------------------------------------");
            string[] Friends = { "test", "test", "test", "test", "test" };
            foreach (string name in Friends)
            {
                Console.WriteLine("Hi there,{0} ", name);
            }

            // 2D Arrays
            int[,] Matrix;

            //  2 demention arrays
            int[,] array2D = new int[,]
            {
                {1,2,3},     //row 0
                {4,5,6},     //row 1
                {7,8,9}      //row 2
            };
            Console.WriteLine("2D Array Element {0} ", array2D[1,1] );
            
            // 3D Arrays
            int[,,] ThreeD;

            // 3 demention arrays
            int[,,] array3D = new int[,,]
            {
                {                 
                    {1,2,3},
                    {4,5,6},
                    {7,8,9}
                },
                {                
                    {1,2,3},
                    {4,5,6},
                    {7,8,9}
                }

            };
            Console.WriteLine("3D array Element {0}", array3D[0,0,1] );

            // if we dont know the demension of array them we use rank method. 
            int demension = array3D.Rank;
            Console.WriteLine("Demension is :{0} ",demension);
            Console.ReadKey();
        }
    }
}