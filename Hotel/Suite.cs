using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Suite
    {
        private string _suiteType { get; set; }
        private int _capacity { get; set; }
        private decimal _dailyPrice;

        public Suite (string suiteType, int capacity, decimal dailyPrice)
        {
            this._suiteType = suiteType;
            this._capacity = capacity;
            this._dailyPrice = dailyPrice;
        }


        public decimal DailyPrice
        {
            get { return this._dailyPrice; }
            set { this._dailyPrice = value; }
        }

        public int Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }

        }
    }
}