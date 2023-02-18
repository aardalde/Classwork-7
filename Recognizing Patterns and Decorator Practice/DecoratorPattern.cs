/* 
 * Aaron Alden
 * CSCI 352
 * February 17, 2023
 * DecoratorPattern.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognizing_Patterns_and_Decorator_Practice
{
    class DecoratorPattern
    {
        static void Main(string[] args)
        {
            //Decorator Design Pattern
            IWidget textField = new TextField(10, 10);
            IWidget borderDecorator = new BorderDecorator(textField);
            IWidget scrollDecorator = new ScrollDecorator(borderDecorator);
            IWidget fireworkAnimationDecorator = new FireworkAnimationDecorator(scrollDecorator);
            borderDecorator.Draw();
            scrollDecorator.Draw();
            fireworkAnimationDecorator.Draw();
            textField.Draw(); // I hope I correctly understood your instructions under the DecoratorDemo in the UML. Next time I will reach out sooner.
        }
    }
    // base interface
    interface IWidget
    {
        void Draw();
    }
    // concrete implementation
    class TextField : IWidget
    {
        private int width;
        private int height;
        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }
        public virtual void Draw()
        {
            Console.WriteLine("This is a basic text field with no decorators");
        }
    }
    // base decorator
    class Decorator : IWidget
    {
        private IWidget wid;
        public Decorator(IWidget w)
        {
            wid = w;
        }
        public virtual void Draw()
        {
            wid.Draw();
        }
    }
    // concrete decorators
    class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget widget) : base(widget) { }

        public override void Draw()
        {
            Console.WriteLine("This is a textfield with a border graphic around it");
        }
    }
    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(IWidget widget) : base(widget) { }

        public override void Draw()
        {
            Console.WriteLine("This is a textfield with scroll mechanics");
        }
    }
    class FireworkAnimationDecorator : Decorator
    {
        public FireworkAnimationDecorator(IWidget widget) : base(widget) { }

        public override void Draw()
        {
            Console.WriteLine("This is a texfield with firework animations going off");
        }
    }
}




