using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUserName = sendByUserName;
            IsPublic = isPublic;

            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - by {3}", ID, Title, ImageURL, SendByUserName);
        }
    }
}
