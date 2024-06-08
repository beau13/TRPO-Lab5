using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba3.ClassLibrary;

namespace Laba3.WpfApp.Models
{
    class Model
    {
        public static double GetSquare(double r, double R, double l)
        {
            double result = new ClassSquare().S(r, R, l);
            return result;
        }
    }
}
