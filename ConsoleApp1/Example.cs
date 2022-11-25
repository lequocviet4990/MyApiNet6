using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Example
    {
    }

    public class TShirt
    {
        public void Wear()
        {
            Console.WriteLine("wear T-shirt");

        }
    }

    public class Dress
    {
        public void Wear()
        {
            Console.WriteLine("wear Dress");

        }
    }
    public class SportShirt
    {
        public void Wear()
        {
            var b = 0;
            var a = 7 / b;
            Console.WriteLine("wear SportShirt");

        }
    }

    public interface IOutFit
    {
       public void Wear();
       public DateTime GetDateNow();
    }

    public class OutFit : IOutFit
    {
        public DateTime GetDateNow()
        {
            return DateTime.Now;
        }

        public void Wear()
        {
            Console.WriteLine("wear  Drees");
        }
    }


    public class Girl
    
    {
        public IOutFit _outFit { get; set; }
        public Girl(IOutFit outFit)
        {
            this._outFit = outFit;
        }

        public void Go()
        {
            this._outFit.Wear();
        }
    }

}
