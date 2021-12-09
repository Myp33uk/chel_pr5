using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chel_pr5
{
    class Liquid
    {
        public string Title { get; set; }
        public int Volume { get; set; }
        public int Density { get; set; }
        public Liquid()
        {
            Title = string.Empty;
            Volume = 0;
            Density = 0;
        }
        public Liquid SetParams(string title, int volume, int density)
        {
            Title = title;
            Volume = volume;
            Density = density;
            return this;
        }
    }
}
