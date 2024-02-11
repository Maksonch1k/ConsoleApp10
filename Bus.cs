using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Bus
    {
        protected string brand;
        protected int seats;
        protected double ticketCost;

        
        public Bus(string brand, int seats, double ticketCost)
        {
            this.brand = brand;
            this.seats = seats;
            this.ticketCost = ticketCost;
        }

        
        public double CalculateTotalCost()
        {
            return seats * ticketCost;
        }
    }

    class Tourist : Bus
    {
        private double excursionCost;

       
        public Tourist(string brand, int seats, double ticketCost, double excursionCost) : base(brand, seats, ticketCost)
        {
            this.excursionCost = excursionCost;
        }

        
        public new double CalculateTotalCost()
        {
            return base.CalculateTotalCost() + (seats * excursionCost);
        }
    }
}

