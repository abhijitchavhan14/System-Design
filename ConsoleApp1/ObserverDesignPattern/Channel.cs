using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObserverDesignPattern
{
    public class Channel: IChannels
    {
        private readonly string name;
        public string latestvideo;

        public List<ISubscriber> Subscribers { get; set; } = new List<ISubscriber>();

        public Channel(string name)
        {
            this.name = name;
        }
        public void Subscribe(ISubscriber subscriber)
        {
            if(!Subscribers.Contains(subscriber))
            {
                Subscribers.Add(subscriber);
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (Subscribers.Contains(subscriber))
            {
                Subscribers.Remove(subscriber);
            }
        }

        public void NotifySubscribers(string message)
        {
            foreach(var subscriber in Subscribers)
            {
                subscriber.Update(message);
            }
        }

        // channel owner will upload a video and notify all the subscribers about the new video;
        void uploadVideo(string videoTitle)
        {
            latestvideo = videoTitle;
            NotifySubscribers(videoTitle);
        }

        public string getLatestMessage(string videoTitle)
        {
            string video = $"getting video base on title {videoTitle}";
            return video;
        }
    }
}
