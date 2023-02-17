using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognizing_Patterns_and_Decorator_Practice
{
    public abstract class Decorator : Widget
    {
        Widget wid;
        public Decorator(Widget w) {

        }
        public void Draw()
        {

        }
    }
}
