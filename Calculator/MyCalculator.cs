using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyCalculator
    {
        private IGroupCount _GroupCount;
        private IDdlType _DdlType;

        public MyCalculator(IGroupCount GroupCount, IDdlType DdlType)
        {
            this._GroupCount = GroupCount;
            this._DdlType = DdlType;
        }
        public MyCalculator()
        {

        }

        public List<int> Calculate1()
        {
            List<HomeWork> lhwc = new List<HomeWork>();
            for (int a = 1; a <= 11; a++)
            {
                lhwc.Add(new HomeWork() { Id = a, Cost = a, Revenue = 10 + a, SellPrice = 20 + a });
            }
            return Calculation_results(3, "0", lhwc);
        }

        public List<int> Calculate2()
        {
            List<HomeWork> lhwc = new List<HomeWork>();
            for (int a = 1; a <= 11; a++)
            {
                lhwc.Add(new HomeWork() { Id = a, Cost = a, Revenue = 10 + a, SellPrice = 20 + a });
            }
            return Calculation_results(4, "1", lhwc);
        }

        public List<int> Calculation_results(int GCount, string DType, List<HomeWork> lhwc)
        {
            List<int> strAns = new List<int>();

            //GCount 可以是3筆一組、4筆一組、甚至是任意決定幾筆一組
            int txtCount = GCount;
            //DType 為指定欄位參數 
            string txtddlType = DType;

            int Total = 0;
            for (int b = 0; b < lhwc.Count; b++)
            {
                switch (txtddlType)
                {
                    case "0":
                        Total += lhwc[b].Cost;
                        break;

                    case "1":
                        Total += lhwc[b].Revenue;
                        break;

                    case "2":
                        Total += lhwc[b].SellPrice;
                        break;
                }
                if (b != lhwc.Count - 1)
                {
                    if (lhwc[b].Id % txtCount == 0)
                    {
                        strAns.Add(Total);
                        Total = 0;
                    }
                }
                else
                {
                    strAns.Add(Total);
                }
            }
            return strAns;
        }
    }

    public class GroupCount : IGroupCount
    {
        public int GetGroupCount(int GroupCount)
        {
            if (GroupCount != null)
            {
                GroupCount = GroupCount != 0 ? GroupCount : 3;
            }
            var result = GroupCount;
            return result;
        }
    }

    public class DdlType : IDdlType
    {
        public string GetType(string DdlType)
        {
            if (DdlType != null)
            {
                DdlType = DdlType != "" ? DdlType : "0";
            }
            var result = DdlType;
            return result;
        }
    }

    public interface IGroupCount
    {
        int GetGroupCount(int GroupCount);
    }

    public interface IDdlType
    {
        string GetType(string DdlType);
    }

    public class HomeWork
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
