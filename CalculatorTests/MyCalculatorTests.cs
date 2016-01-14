using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void Calculate1Test_針對Cost資料每3筆進行加總()
        {
            var target = new MyCalculator();

            int GroupCountTest = 3;
            // DdlType： 0：Cost，1：Revenue，2：SellPrice。
            var DType = "0";
            var lhw = new List<HomeWork>()
            {
                new HomeWork(){ Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new HomeWork(){ Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new HomeWork(){ Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new HomeWork(){ Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new HomeWork(){ Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new HomeWork(){ Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new HomeWork(){ Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new HomeWork(){ Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new HomeWork(){ Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new HomeWork(){ Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new HomeWork(){ Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };

            List<int> strAns = new List<int>() { 6, 15, 24, 21 };

            List<int> strAnsCalculate = target.Calculation_results(GroupCountTest, DType, lhw);

            CollectionAssert.AreEqual(strAns, strAnsCalculate);//會比順序
        }

        [TestMethod()]
        public void Calculate2Test_針對Revenue資料每4筆進行加總()
        {
            var target = new MyCalculator();

            int GroupCountTest = 4;
            // DdlType： 0：Cost，1：Revenue，2：SellPrice。
            var DType = "1";
            var lhw = new List<HomeWork>()
            {
                new HomeWork(){ Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new HomeWork(){ Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new HomeWork(){ Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new HomeWork(){ Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new HomeWork(){ Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new HomeWork(){ Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new HomeWork(){ Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new HomeWork(){ Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new HomeWork(){ Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new HomeWork(){ Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new HomeWork(){ Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
            List<int> strAns = new List<int>() { 50, 66, 60 };

            List<int> strAnsCalculate = target.Calculation_results(GroupCountTest, DType, lhw);

            CollectionAssert.AreEqual(strAns, strAnsCalculate);//會比順序       
        }
    }
}
