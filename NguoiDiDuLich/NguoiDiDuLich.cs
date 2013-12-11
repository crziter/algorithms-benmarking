using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace NguoiDiDuLich
{
    internal class Node
    {
        public string Name { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(string name)
        {
            Name = name;
            Neighbors = new List<Node>();
        }

        public bool IsContainNeighbor(Node node)
        {
            foreach (var n in Neighbors)
            {
                if (n.Name.Equals(node.Name))
                    return true;
            }

            return false;
        }
    }

    internal class Edge
    {
        public Edge()
        {

        }
    }

    public class NguoiDiDuLich: Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        public bool GenerateInput(int n, Output output)
        {
            output.WriteLine(n);

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {

                }

                output.WriteLine("");
            }

            return true;
        }

        public bool Performance()
        {
            throw new NotImplementedException();
        }

        public bool PrepareInput()
        {
            throw new NotImplementedException();
        }

        public bool PrintOutput()
        {
            throw new NotImplementedException();
        }
    }
}
