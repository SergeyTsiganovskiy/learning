using System;
using System.Threading;

namespace AdvancedTopics.eventexmple
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }
        }

        // source - object that publish an event
        // args - additional data that we want send with event

        // custom delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        // event publisher method should be protected, virtual, void, starts from 'On' + event name (convention .Net)
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){Video = video});

        }
    }
}
