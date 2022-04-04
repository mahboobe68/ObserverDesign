﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    internal class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;


        public Investor(string name)
        {
          this._name = name;
        }


        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
            "change to {2:C}", _name, stock.Symbol, stock.Price);
        }
    }
}
