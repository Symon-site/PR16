using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Money
    {
        private int rubles;
        private int kopeycks;

        public Money(int rubles, int kopeycks)
        {
            this.rubles = rubles + kopeycks / 100;
            this.kopeycks = kopeycks % 100;
        }

        public static Money operator +(Money m1, Money m2)
        {
            int totalKopecks = m1.kopeycks + m2.kopeycks;
            int totalRubles = m1.rubles + m2.rubles + totalKopecks / 100;
            return new Money(totalRubles, totalKopecks % 100);
        }
        public static bool operator ==(Money m1, Money m2)
        {
            return m1.rubles == m2.rubles && m1.kopeycks == m2.kopeycks;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Money money)
            {
                return this == money;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return rubles.GetHashCode() ^ kopeycks.GetHashCode();
        }

        public override string ToString()
        {
            return $"{rubles} руб {kopeycks} коп";
        }
    }
}
