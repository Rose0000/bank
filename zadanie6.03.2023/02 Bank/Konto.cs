using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    internal class Konto
    {
        public Osoba Wlasciciel;
        private decimal _saldo = 0;
        private int _pin = 0;

        // sprawdzam pin = jeśli jest poprawne, to true, jak nie, to false
        private bool SprawdzPin(int pin)
        {
            return this._pin == pin;
            //to samo co u góry tylko bardziej rozbudowane

            // if (this._pin == pin)
            //   return true;
            //else
            //  return false;           
        }

        //zmiana pinu
        public bool ZmienPin(int nowy, int stary)
        {
            if(!SprawdzPin(stary)) return false;
            
            //rózne możliwości:

            //if(SprawdzPin(stary) == false) return false;

            //if(this._pin != stary)
            //  return false;

            _pin = nowy;
            return true;
        }

    }
}
