using System;
using System.Collections.Generic;

namespace Recursive_And_BFS_WFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //FibonacciClass fibonacciClass = new FibonacciClass();
            //var fibs = fibonacciClass.CalculateFibValueByFor(8);
            //foreach (var a in fibs)
            //    Console.Write($" {a} ,");
            //var fib = fibonacciClass.CalculateFibValueByRecursive(8);
            //    Console.WriteLine($" {fib} ,");
            //Console.ReadLine();

            TreeNode treeNode = new TreeNode();

            treeNode.val = 1;
            treeNode.left = null;
            treeNode.right = new TreeNode { val = 2,left=new TreeNode { val=3,left=new TreeNode {val=4,right=new TreeNode {val= 6} } }, right=new TreeNode { val=5} };
            Cousins cousins = new Cousins();
            Console.WriteLine(cousins.IsCousins(treeNode, 5, 3));
        }
    }
}
