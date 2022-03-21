using System;
using System.Linq;

namespace Hierarchical_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hierarchical structure initialization 
            Branch root = new Branch();
            //Left Side
            root.branches.Add(new Branch());
            root.branches.First().branches.Add(new Branch());

            //Right Side
            root.branches.Add(new Branch());
            root.branches.Last().branches.Add(new Branch());

            root.branches.Last().branches.Add(new Branch());
            root.branches.Last().branches.Last().branches.Add(new Branch());
            root.branches.Last().branches.Last().branches.Add(new Branch());

            root.branches.Last().branches.Last().branches.First().branches.Add(new Branch());

            root.branches.Last().branches.Add(new Branch());

            root.branches.Last().branches.First().branches.Add(new Branch());


            Console.WriteLine("Depth of hierarchical structure is: {0}", Structure.MaxDepth(root));
        }
    }
}
