namespace InheritanceDemo2              
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Flow of Program 
             * 1. I created the post class it was the base class 
             * 2. I created the ImagePost class where I did inherit the method and properties of the base class and me the override Tostring method 
             * 3. I create the VideoPost class where I did inherit the method and properties of the base class and me the override Tostring method and create custon constructors.
             * 4. I intanceated object of the class. and call it.
             */


            // first object call
            Post post2 = new Post();
            Console.WriteLine(post2.ToString());

            //Second Object Call 
            Post post1 = new Post("Thaks for the Birthday Wises", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());

            // instanciate object to its class
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", true, "Denis Panjuta", "https://images.com/shoes");
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("check out my New blog", true, "Denis Panjuta", "https://Myblog.com", 25);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press Any Key To Stop Video.");
            Console.ReadLine();
            videoPost1.Stop();

        }
    }
}