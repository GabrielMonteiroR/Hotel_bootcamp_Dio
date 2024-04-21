using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Pessoa
    {
        private string _firstName;
        private string _lastName;

        public Pessoa(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public string Name
        {
            get => _firstName;

            set => _lastName = value;
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
