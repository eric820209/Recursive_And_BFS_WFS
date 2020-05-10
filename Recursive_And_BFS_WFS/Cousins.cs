using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursive_And_BFS_WFS
{
    class Cousins
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var IsSiblingsResult = IsSiblings(root, x, y);
            var xLevel = GetLevel(root,x,1);
            var yLevel = GetLevel(root, y,1);

            return !IsSiblingsResult && xLevel==yLevel;
        }

        private int GetLevel(TreeNode node, int val,int level)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.val == val)
            {
                return level;
            }
            var leftResult=  GetLevel(node.left, val, level + 1);
            if (leftResult != 0)
            {
                return leftResult;
            }
            return GetLevel(node.right, val, level + 1);
        }

        public bool IsSiblings(TreeNode node,int x,int y)
        {
            if (node == null )
            {
                return false;
            }
            return ((node.left!=null &&node.left.val == x )&&(node.right!=null && node.right.val == y)) ||
                  ((node.left != null && node.left.val == y) && (node.right != null && node.right.val == x)) ||
                  (IsSiblings(node.left, x, y)) || (IsSiblings(node.right, x, y));
        }
    }
}
