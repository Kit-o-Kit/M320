using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle
    {
        public string name;
        public int Width { get; set; }
        public int Height { get; set; }
        public int circum { get { return 2 * Height + 2 * Width; }}
        // private Color color = Color.Black;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Area => this.Height * this.Width;

        //public Color Color
        //{
        //    get
        //    {
        //        return this.color;
        //    }
        //    set
        //    {
        //        this.color = value;
        //    }
        //}

        public Color Color { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public string Start { get { return $"{PosX}/{PosY}";}} 
    }
}
