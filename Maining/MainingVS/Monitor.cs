using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainingVS
{


    
    public class Monitor
    {
        private Text[] text = null;
        private string summ = null;
        private int width { get; }
        private int height { get; }

        public Monitor(int width, int height) // konstruktor iestata consoles platumu augstumu
        {
            this.width = width;
            this.height = height;
            Console.SetWindowSize(width, height);
        }
        public void AddText(string text, int x, int y, string color = "wait") // pievieno textu pa elementiem
        {

        }
       public void Addtext(Text text)  // pievieni tekstu no objekta Text
        {

        }
        public void RemoveText(string name) // izdzēš tekstu pec varda
        {

        }
        public void RemoveText(int id)    // izdzeš tekstu pec indeksa
        {

        }
        public Text GetText(string name)  // atgriez tekstu pec nosaukuma
        {
            throw new NotImplementedException();
        }
        public Text GetText(int id)       // atgriez tekstu pec indeksa
        {
            throw new NotImplementedException();
        }

       private void GetSum()    // izveido gala trkstu;
        {

        }
        public void PrintFrame()    // izdrukā jaunu tekstu
        {
            Console.Clear();        // atira iepriekšējo tekstu
            GetSum();
            Console.WriteLine(summ);
        }
    }
}
