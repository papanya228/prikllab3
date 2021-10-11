using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProxyMethodLab
{
    class ProxyMyBitMap : IMyBitMap
    {
        public string Path { get; set; }
        public ProxyMyBitMap(string path)
        {
            this.Path = path;
        }
        public string GetDimensions()
        {
            if (File.Exists(Path))
            {
                Regex checkext = new Regex("\\.bmp$");
                if (checkext.IsMatch(Path))
                {
                    Regex checkpath = new Regex("_\\d*x\\d*\\.bmp$");

                    if (checkpath.IsMatch(Path))
                    {
                        string _name = Path;
                        while (_name.Contains("\\"))
                        {
                            _name = _name.Remove(0, _name.IndexOf('\\') + 1);
                        }
                        _name = _name.Remove(_name.Length - 4, 4);
                        _name = _name.Remove(0, _name.IndexOf('_') + 1);
                        string[] dimensions;
                        dimensions = _name.Split('x');
                        return $"Size = {dimensions[0]}x{dimensions[1]}  {Path}";
                    }
                    else
                    {
                        MyBitMap img = new MyBitMap(Path);
                        return img.GetDimensions();
                    }
                }
                else return "Not a bitmap";
            }
            else return "No such file";
            
        }
    }
}
