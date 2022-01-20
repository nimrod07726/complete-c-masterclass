using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Inheritance2
{
    class VideoPost : Post
    {
        private Timer timer = new Timer();
        private bool isPlaying = false;


        protected string VideoURL { get; set; }
        protected static int Length { get; set; }
        private static int currentDuration;

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length)
        {
            ID = GetNextID();
            Title = title;
            SendByUserName = sendByUserName;            
            IsPublic = isPublic;

            VideoURL = videoURL;
            Length = length;
            currentDuration = 0;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - by {4}",
                ID, Title, VideoURL, Length, SendByUserName);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing...");
                isPlaying = true;
                SetTimer();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine("Stopped at {0}s", currentDuration);
                timer.Dispose();
                isPlaying = false;
            }           
        }
        private void SetTimer()
        {
            timer = new Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (currentDuration < Length) 
            {
                Console.WriteLine("\rCurrent Duration: {0}s", ++currentDuration);
            } 
            else
            {
                Stop();
            }
                
        }

    }
}
