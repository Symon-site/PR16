using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16
{
    internal class Money
    {
            
        public int Rubles { get; private set; }
            public int Kopeks { get; private set; }


        
        public Money(int rubles, int kopeks)
        
        {
        
            Rubles = rubles + kopeks / 100;
            
            Kopeks = kopeks % 100;
        
        }

        public static Money operator +(Money m1, Money m2)

        {

            int totalKopeks = m1.Kopeks + m2.Kopeks;

            return new Money(m1.Rubles + m2.Rubles + totalKopeks / 100, totalKopeks % 100);

        }
        public static bool operator ==(Money m1, Money m2) => m1.Rubles == m2.Rubles && m1.Kopeks == m2.Kopeks;
        
        public static bool operator !=(Money m1, Money m2) => !(m1 == m2);
        public override string ToString() => $"{Rubles} руб. {Kopeks} коп";
    }
}
