using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_glazing_test_program
{     
    public class DoubleGlazing
    {
        public string glass;
        public string secondGlass;
        public string thirdGlass;
        public string frame;
        public string secondFrame;

        public DoubleGlazing( string Glass, string Frame, string SecondGlass, string SecondFrame, string ThirdGlass)
        {
            this.glass = Glass;
            this.frame = Frame;
            this.secondGlass = SecondGlass;
            this.secondFrame = SecondFrame;
            this.thirdGlass = ThirdGlass;
        }
        public DoubleGlazing (string Glass, string Frame, string SecondGlass) :
            this(Glass, Frame, SecondGlass, "0","0")
        {

        }       
    }
}
