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
        public decimal price;
        public int goodsCount;
        public int goodsNumber;

        public void ChangePrice(decimal price, string operation)
        {
            switch (operation)
            {
                case "increase":
                    this.price += price;
                    break;
                case "reduce":
                    this.price -= price;
                    break;
                    //default: Console.WriteLine("Incorrect operation");

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

        public override string ToString()
        {
            return this.price.ToString();
        }
    }
}
