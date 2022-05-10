using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainingVS
{
    public class Text
    {
        public string name { get;}
        public string text { get; set; }
        public string color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Text(string name)
        {
            this.name= name;
        }
        public void SetText(string text, int x, int y, string color = "wait")
        {
            this.text = text;
            this.color = color;
            this.X = x;
            this.Y = y;
         }
        
    }
}
