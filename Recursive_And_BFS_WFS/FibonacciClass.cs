using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace Recursive_And_BFS_WFS
{
    class FibonacciClass
    {
        public List<int> CalculateFibValueByFor(int n)
        {
            List<int> fibArr = new List<int> { 0, 1 };

            //從第二項開始新增f[n]的值
            for (int i = 2; i < n; i++)
            {
                //因為index從0開始，所以要多-1
                var nValue = fibArr[i - 1] + fibArr[i - 2];
                fibArr.Add(nValue);
            }
            //因為index從0開始，所以要多-1
            return fibArr;


        }
        public int CalculateFibValueByRecursive(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                var a = CalculateFibValueByRecursive(n - 1);
                var b = CalculateFibValueByRecursive(n-2);
                return a+b;
            }
        }
    }
}
