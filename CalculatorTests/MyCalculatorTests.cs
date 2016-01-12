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
        public void Calculate1Test()
        {
            var target = new MyCalculator();

            int GC = 3;
            var DType = "0";
            List<int> strAns = new List<int>();
            strAns.Add(6);
            strAns.Add(15);
            strAns.Add(24);
            strAns.Add(21);
            
            List<int> strAnsCalculate = target.Calculation_results(GC, DType);

            CollectionAssert.AreEqual(strAns, strAnsCalculate);//會比順序
        }

        [TestMethod()]
        public void Calculate2Test()
        {
            var target = new MyCalculator();

            int GC = 4;
            var DType = "1";
            List<int> strAns = new List<int>();
            strAns.Add(50);
            strAns.Add(66);
            strAns.Add(60);
            
            List<int> strAnsCalculate = target.Calculation_results(GC, DType);

            CollectionAssert.AreEqual(strAns, strAnsCalculate);//會比順序       
        }
    }

    internal class HomeWork2
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
