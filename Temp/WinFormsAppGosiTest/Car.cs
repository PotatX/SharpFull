using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGosiTest
{
    public class Car
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsBus { get; set; }
        public int CarParkId { get; set; }


        public override string ToString()
        {
            return $"Name:{Name}  Width:{Width} Height:{Height} IsBus:{IsBus}\n";
        }
    }
}
