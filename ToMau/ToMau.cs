using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace ToMau
{
    internal class Node
    {
        public string Name { get; set; }
        public int Color { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(string name)
        {
            Name = name;
            Color = -1;
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

    internal class Graph
    {
        public List<Node> Nodes;

        public Graph()
        {
            Nodes = new List<Node>();
        }

        public Node FindNodeByName(string name)
        {
            foreach (Node n in Nodes)
            {
                if (n.Name.Equals(name))
                    return n;
            }

            return null;
        }

        public bool IsContainNodeName(string name)
        {
            if (FindNodeByName(name) != null) return true;
            else return false;
        }
    }

    public class ToMau: Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        private Random rand;
        private Graph _graph;
        public ToMau()
        {
            Info = new AlgorithmInformations();
            rand = new Random();

            Info.DauRa = "Các đỉnh đồ thị đã được tô màu";
            Info.DauVao = "Một đồ thị vô hướng";
            Info.GhiChu = "Đầu vào được định dạng như sau: n dòng, mỗi dòng gồm tên của 2 đỉnh liền kề nhau, ví dụ:\r\n\r\n"
                + "A B\r\nA D\r\nB E\r\nD E\r\nE C\r\nD C\r\nC F\r\nB F";
            Info.Kieu = "Tham lam";
            Info.Chuong = "Chương 6";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Tô màu đồ thị";
            Info.TheLoai = "Tô màu";
            Info.XuLi = "Tính số fibonacy thứ n";
        }

        private string GenerateName(int length)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; ++i)
            {
                sb.Append((char)(rand.Next(26) + 65));
            }

            return sb.ToString();

        }
        public bool GenerateInput(int n, Output output)
        {
            _graph = new Graph();
            for (int i = 0; i < n; ++i)
                _graph.Nodes.Add(new Node(i.ToString()));

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == j) continue;
                    if (rand.Next(10) > 5)
                    {
                        if (!_graph.Nodes[i].IsContainNeighbor(_graph.Nodes[j]))
                        {
                            _graph.Nodes[i].Neighbors.Add(_graph.Nodes[j]);
                            _graph.Nodes[j].Neighbors.Add(_graph.Nodes[i]);
                            output.WriteLine(_graph.Nodes[i].Name + " " + _graph.Nodes[j].Name);
                        }
                    }
                }
            }

            return true;
        }

        private bool NeighborWith(List<Node> lst, Node node)
        {
            foreach (var n in lst)
            {
                foreach (var neighbor in node.Neighbors)
                    if (neighbor.Name.Equals(n.Name))
                        return true;
            }

            return false;
        }

        public bool Performance()
        {
            List<Node> remaining = new List<Node>(_graph.Nodes);
            int c = 1;
            while (remaining.Count > 0)
            {
                Node s = remaining[0];
                List<Node> colored = new List<Node>();

                s.Color = c;
                remaining.Remove(s);
                foreach (Node n in remaining.ToArray())
                {
                    if (n.Color == -1 && !n.IsContainNeighbor(s) && !NeighborWith(colored, n))
                    {
                        n.Color = c;
                        remaining.Remove(n);
                        colored.Add(n);
                    }
                }

                c++;
            }

            return true;
        }

        public bool PrepareInput()
        {
            _graph = new Graph();
            while (true)
            {
                string s = Input.NextWord();
                if (s == null) break;

                string e = Input.NextWord();
                Node ns = null, ne = null;

                if (!_graph.IsContainNodeName(s))
                {
                    ns = new Node(s);
                    _graph.Nodes.Add(ns);
                }
                else ns = _graph.FindNodeByName(s);

                if (!_graph.IsContainNodeName(e))
                {
                    ne = new Node(e);
                    _graph.Nodes.Add(ne);
                }
                else ne = _graph.FindNodeByName(e);

                ns.Neighbors.Add(ne);
                ne.Neighbors.Add(ns);
            }

            return true;
        }

        public bool PrintOutput()
        {
            var lst = _graph.Nodes.GroupBy(n => n.Color);

            foreach (var c in lst)
            {
                Output.Write(c.Key + ": ");
                foreach (var n in c.ToList())
                {
                    Output.Write(n.Name + " ");
                }
                Output.WriteLine();
            }

            return true;
        }
    }
}
