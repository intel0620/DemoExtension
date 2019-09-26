using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0920
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TEST CheckInOutBetweenExtension
            var myBetween = new List<IBetween>
            {
                new InBetween (1,100,50),  //t
                new InBetween (1,110,120),  //f
                new OutBetween(10,200,300),  //t
                new OutBetween(100,200,60),  //f
            };
            var visitor = new AreaVisitor();

            foreach (var Check in myBetween)
            {
                Check.Accept(visitor);
            }
            Console.ReadLine();
            #endregion

            #region TEST Extension
            //int start = 1;
            //int end = 100;
            //int[] numarray = new int[] { 10, 100, 1000 };
            //Console.WriteLine(string.Format("檢查範圍{0} ~ {1} ", start, end));
            //foreach (var cknum in numarray)
            //{
            //    string msg = cknum.Between(start, end) == true ? cknum + " 在範圍內." : cknum + " 不在範圍內.";
            //    Console.WriteLine(msg);
            //}
            #endregion
            Console.ReadLine();
        }

    }


    /// <summary>
    ///擴充方法的必備條件
    ///1.類別名稱可以自訂，但必須要為static的類別
    ///2.擴充方法必須為static
    ///3.帶入的第一個參數就是要擴充的型別，並且加上this
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// 檢查數字範圍
        /// </summary>
        /// <param name="CheckNumber">檢查數字</param>
        /// <param name="StartNumber">起始數字</param>
        /// <param name="EndNumber">結束數字</param>
        /// <returns></returns>
        public static bool Between(this int CheckNumber, int StartNumber, int EndNumber)
        {
            if (StartNumber <= CheckNumber && EndNumber >= CheckNumber)
            {
                return true;
            }
            return false;
        }



    }
}
