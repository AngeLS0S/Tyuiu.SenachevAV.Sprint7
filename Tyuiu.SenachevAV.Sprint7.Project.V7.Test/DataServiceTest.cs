using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SenachevAV.Sprint7.Project.V7.Lib;

namespace Tyuiu.SenachevAV.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestSortMin()
        {
            string[,] Data =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };
                                                    


            string[,] res = ds.SortMin(Data, 4);
            string[,] wait =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };
            CollectionAssert.AreEqual(wait, res);
        }
                                                                                                // ������ ����������
        [TestMethod]
        public void TestSortMax()
        {
            string[,] Data =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };



            string[,] res = ds.SortMax(Data, 4);
            string[,] wait =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortBeginBuy()
        {
            string[,] Data =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };



            string[,] res = ds.SortBeginBuy(Data, 6);
            string[,] wait =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortBeginRent()
        {
            string[,] Data =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };



            string[,] res = ds.SortBeginRent(Data, 6);
            string[,] wait =
            {
                {"1","1","g","1","1","1","�������" },
                {"1","2","������","3","100","4","������" }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}