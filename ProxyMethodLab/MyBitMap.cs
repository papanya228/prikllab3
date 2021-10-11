using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProxyMethodLab
{
    class MyBitMap : IMyBitMap
    {
        public string Path { get; set; }
        public MyBitMap(string path)
        {
            this.Path = path;
        }
        public string GetDimensions()
        {
            Bitmap bmp = new Bitmap(this.Path);
            int Width = bmp.Width;
            int Height = bmp.Height;
            return ($"Size = {Width}x{Height}");
        }

        
    }
}
