using System;

namespace AdvancedTopics.eventexmple
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEncoder.VideoEventArgs e)
        {
            Console.WriteLine("Message service: Sending a text messsage ....." + e.Video.Title);
        }
    }
}