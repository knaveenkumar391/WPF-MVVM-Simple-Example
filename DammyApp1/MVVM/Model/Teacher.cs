using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DammyApp1.MVVM.Model
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Division { get; set; }
        public Teacher( string name, string cls, string div) {
            this.Name = name;
            this.Class = cls;
            this.Division = div;
        }
    }
}
