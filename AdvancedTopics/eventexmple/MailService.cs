using System;

namespace AdvancedTopics.eventexmple
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEncoder.VideoEventArgs e)
        {
            Console.WriteLine("Mail service: Sending an email....." + e.Video.Title);
        }
    }
}