using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    // inherit method and properties from post calss
    public  class ImagePost : Post
    {
       protected string ImageURL { get; set; }

       public ImagePost() { }

       public ImagePost (string Title, bool IsActive, string sendByUserName, string imageURL) : base(Title, IsActive, sendByUserName) 
        {
            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {ImageURL} - By {SendByUserName}");
        }
    }
}
