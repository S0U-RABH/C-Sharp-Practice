using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    public class Post
    {
        private static int CurrentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsActive { get; set; }

        public Post() 
        {
            ID= 0;
            Title = "My First Post";
            SendByUserName = "Denis Panjuta";
            IsActive = true;
        }

        public Post( string Title, bool IsActive ,  string sendByUserName)
        {
            ID = GetNetId();
            this.Title = Title;
            this.SendByUserName = sendByUserName;
            this.IsActive = IsActive;
        }

        protected int GetNetId()
        {
            return ++CurrentPostId;
        }

        public void Update (string Title , bool IsActive)
        {
            this.IsActive = IsActive;
            this.Title = Title;
        }

        //we can Override predefine class object like this 
        //Here Tostirng is not convert to other Data type to string but it Perform our Define task
        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - By {SendByUserName}") ;                                                                                   
        }
    }
}
