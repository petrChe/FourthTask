using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Money
    {
        public long ruble;
        public int kopec;

        public Money() { }
        public Money(long ruble, int kopec)
        {
            this.ruble = ruble;
            this.kopec = kopec;
        }

        public override string ToString()
        {
            return this.ruble + "," + this.kopec;
        }

        public Money Sum(Money secondMoney)
        {
            Money resultMoney = new Money();
            long resultRuble = this.ruble + secondMoney.ruble;
            int resultKopec = this.kopec + secondMoney.kopec;
            if (resultKopec >= 100)
            {
                resultRuble += resultKopec / 100;
                resultKopec = resultKopec % 100;
            }
            resultMoney.ruble = resultRuble;
            resultMoney.kopec = resultKopec;

            return resultMoney;
        }
        public Money Sub(Money secondMoney)
        {
            Money resultMoney = new Money();
            long resultRuble = this.ruble - secondMoney.ruble;
            int resultKopec = this.kopec - secondMoney.kopec;
            if (this.ruble > secondMoney.ruble)
            {
                if (resultKopec >= 100)
                {
                    resultRuble += resultKopec / 100;
                    resultKopec = resultKopec % 100;
                }
                resultMoney.ruble = resultRuble;
                resultMoney.kopec = resultKopec;
            }
            else
            {
                Console.Write("Incorrect operation");
            }

            return resultMoney;
        }
    }
}

