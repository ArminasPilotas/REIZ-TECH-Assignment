﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Structure
{
    public class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
    }
}
