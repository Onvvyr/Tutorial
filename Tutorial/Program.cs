using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace InterFaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFive obj1 = new ODDEVEN();
            obj1.ONE();
            obj1.THREE();
            obj1.FIVE();
            IEVEN obj2 = new ODDEVEN();
            obj2.TWO();
            obj2.FOUR();
        }
    }
}