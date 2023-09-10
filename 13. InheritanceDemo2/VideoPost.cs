using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{   
    public class VideoPost : Post
    {
        // Member Field
        protected bool Isplaying = false;
        protected int CurrentDuration = 0;
        Timer timer;  // (preprocessor comand) defination define in System.Threading.Tasks;

        //properties 
        public string VideoUrl { get; set; }
        public int Length { get; set; }

        //Default constructor
        public VideoPost() { } 

        //constructor with arguements and inhherit the arguement form base class
        public VideoPost(string Title, bool IsActive, string sendByUserName, string videoUrl, int length) : base(Title, IsActive, sendByUserName)
        {
            VideoUrl = videoUrl;
            Length = length;
        }

        public void Play()
        {
            if (!Isplaying)
            { 
                Isplaying= true;
                Console.WriteLine("Playing..");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        protected void TimerCallback(object op)
        {
            if(CurrentDuration < Length ) 
            {
                CurrentDuration++;
                Console.WriteLine("Video at {0}s", CurrentDuration);
                GC.Collect();
            }else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (Isplaying) 
            {
                Isplaying= false;
                Console.WriteLine("Stopped at {0}s", CurrentDuration);
                CurrentDuration = 0;
                timer.Dispose();
            }
            
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {VideoUrl} - Length is {Length} minutes - By {SendByUserName}");
        }
    }
}
