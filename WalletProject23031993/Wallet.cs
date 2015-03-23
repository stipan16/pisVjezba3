using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletProject23031993
{
    public class Wallet
    {
        //konstruktor
        public Wallet()
        {
            this.dictionary = new Dictionary<string, float>();
        }

        //metoda za dodavanje valuta
        public void AddCurrencyValue(string currency, float value)
        {
            if (this.dictionary.ContainsKey(currency))
            {
                this.dictionary[currency] += value;
            }
            else
            {
                this.dictionary.Add(currency, value);
            }
        }

        public float GetCurrencyValue(string currency)
        {
            //provjerava da li ima vrijednost tog ključa ---ako ga ima vrati vrijednost ,a ako ne vrati 0
            return this.dictionary.ContainsKey(currency)
                ? this.dictionary[currency]
                : 0;
        }


        private Dictionary<string, float> dictionary;

    }
}

//codeCoverageResults->Crveno što nie obrađeno,plavo ono što je izvršeno
//Solution Items/Local.testsettings/2-click/Data&Diagnostics/CodeCoverage->Apply
//CTRL+R   + A