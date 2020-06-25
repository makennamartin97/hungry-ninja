using System;
using System.Collections.Generic;
using hungryninja.Models;

namespace hungryninja
{


    class Program
    {
        static void Main(string[] args)
        {
            Buffet bestBuffet = new Buffet();
            Ninja Makenna = new Ninja(1200);
            while (Makenna.IsFull == false)
            {
                Makenna.Eat(bestBuffet.Serve());
            }
            Makenna.Eat(bestBuffet.Serve());
        }
    }
}
