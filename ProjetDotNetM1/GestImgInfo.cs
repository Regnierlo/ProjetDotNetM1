
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjetDotNetM1
{
    class GestImgInfo
    {
       public  List<string> Tag
        {
            get;
            set;
        }
        public int Orientation
        {
            get;
            set;
        }
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }
        public GestImgInfo()
        {
            Tag = new List<string>();
            Y = 0;
            X = 0;
            Orientation = 1;
        }
    }
}