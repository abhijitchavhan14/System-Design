using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObserverDesignPattern
{
    public class Subscriber : ISubscriber   
    {
        private readonly IChannels channels;
        public string Name { get; set; }
        public Subscriber(string name,IChannels channels)
        {
            Name = name;
            this.channels = channels;
        }
    
        public void Update(string videoTitle)
        {
            var video = channels.getLatestMessage(videoTitle);
            Console.WriteLine($"Subscriber {Name} received an update {video}");
        }
    }
}
