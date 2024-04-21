using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Reserva
    {
        private List<Pessoa> _clientList {  get; set; }
        private Suite _suite {  get; set; }
        private int _days { get; set; }

        public Reserva(int days)
        {
            this._clientList = new List<Pessoa>();
            this._days = days;
            this._suite = null;
        }


        public void RegisterGuests(List<Pessoa> guests)
        {
            if (guests.Count > this._suite.Capacity)
            {
                throw new Exception("A suite está cheia!");
            }
            else
            {
                this._clientList = guests;
            }
        }
        public int getGuestQuantity()
        {
            return this._clientList.Count;
        }

        public void RegisterSuites(Suite suite)
        {
            this._suite = suite;
        }

        public decimal calculateDailyPrice()
        {
            if(this._days >= 10)
            {
                return this._days * (this._suite.DailyPrice - (this._suite.DailyPrice * 0.1M)) ;
            }
            else
            {
                return this._days * this._suite.DailyPrice;
            }            
        }
    }
}
