using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class DataItem
    {
        int number;
        string topic;
        string content;
        string image;

        public DataItem(int number, string topic, string content)
        {
            this.Number = number;
            this.Topic = topic;
            this.Content = content;
            this.Image = "";
        }

        public DataItem(int number, string topic, string content, string image)
        {
            this.Number = number;
            this.Topic = topic;
            this.Content = content;
            this.Image = image;
        }

        public int Number { get => number; set => number = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Content { get => content; set => content = value; }
        public string Image { get => image; set => image = value; }

        
    }
}
