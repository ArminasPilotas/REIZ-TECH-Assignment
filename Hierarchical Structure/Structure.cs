using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Structure
{
    public static class Structure
    {
        public static int MaxDepth(Branch branch, int depth = 1)
        {
            if (branch == null)
                return depth;

            if (branch.branches.Count == 0)
                return depth;


            int returnDepth = depth;

            foreach (Branch item in branch.branches)
            {
                int branchesDepth = MaxDepth(item, depth + 1);

                if (branchesDepth > returnDepth)
                    returnDepth = branchesDepth;
            }
            return returnDepth;
        }
    }
}
