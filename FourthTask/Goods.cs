using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Goods
    {
        public string name;
        public DateTime buyDate;
        public DateTime expirationDate;
        public Money price;
        public int goodsCount;
        public int goodsNumber;

        public Goods(string name, DateTime buyDate, DateTime expirationDate, Money price, int goodsCount, int goodsNumber) {
            this.name = name;
            this.buyDate = buyDate;
            this.expirationDate = expirationDate;
            this.price = price;
            this.goodsCount = goodsCount;
            this.goodsNumber = goodsNumber;
        }
        public void ChangePrice(long ruble, int kopec, string operation)
        {
            switch (operation)
            {
                case "increase":
                    this.price.ruble += ruble;
                    this.price.kopec += kopec;
                    break;
                case "reduce":
                    //ADD EXEPTION!!!
                    this.price.ruble -= ruble;
                    this.price.kopec -= kopec;
                    break;
            }
            Console.WriteLine(this.price);
        }

        public void ChangeGoodsCount(int goodsCount, string operation)
        {
            switch (operation)
            {
                case "increase":
                    this.goodsCount += goodsCount;
                    break;
                case "reduce":
                    this.goodsCount -= goodsCount;
                    break;
                    //default: Console.WriteLine("Incorrect operation");

            }
            Console.WriteLine(this.goodsCount);
        }

        public Money FindCost(int goodsCount)
        {
            return this.price.Multiply(goodsCount);
        } 

        public void FindPriceAfterDevaluation()
        {
            double rubleDevaluation = this.price.ruble * 0.01 * (this.buyDate.Day - this.expirationDate.Day);
            double kopecDevaluation = this.price.kopec * 0.01 * (this.buyDate.Day - this.expirationDate.Day);
            //ADD EXEPTION
            if (kopecDevaluation >= 100)
            {
                rubleDevaluation += rubleDevaluation / 100;
                kopecDevaluation = kopecDevaluation % 100;
            }
            this.price.ruble -= Convert.ToInt64(rubleDevaluation);
            this.price.kopec -= Convert.ToInt32(kopecDevaluation);

        }
        public override string ToString()
        {
            return String.Format("{0} units {1} {2}  = tenge", this.goodsCount, this.name, this.FindCost(this.goodsCount));
        }
    }
}
