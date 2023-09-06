using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class ToaDo
    {
        private string _ten;
        private float _x;
        private float _y;
        public string Ten { get { return _ten; } set {  _ten = value; } }
        public float X { get { return _x; } set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }
        public override string ToString()
        {
            return _ten+"("+_x+","+_y+")";
        }
        public ToaDo()
        {
            Ten = "M";
            X = 1.2f;
            Y = 3.4f;
        }
        public ToaDo(string ten,float x,float y)
        {
            Ten = ten;
            X = x;
            Y = y;
        }
    }
}
