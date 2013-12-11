using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace Dijkstra
{
    internal class Node
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public bool Solved { get; set; }
        private List<Edge> _connectors { get; set; }

        public Node(string name)
        {
            Name = name;
            _connectors = new List<Edge>();
        }

        public void ConnectToNode(Node end, double weigh)
        {
            Edge edge = new Edge(end, weigh);
            _connectors.Add(edge);
        }

        public Edge GetEdgeToNode(string nodeName)
        {
            foreach (Edge e in _connectors)
            {
                if (e.End.Name.Equals(nodeName))
                    return e;
            }

            return null;
        }

        public List<Edge> GetNeighbors()
        {
            List<Edge> edges = new List<Edge>();

            foreach (var e in _connectors)
            {
                if (e.End.Solved == false)
                    edges.Add(e);
            }
            return edges;
        }

        public Edge GetEdgeToNode(Node node)
        {
            return GetEdgeToNode(node.Name);
        }
    }

    internal class Edge
    {
        public Node End { get; set; }
        public double Weight { get; set; }

        public Edge(Node end, double weight)
        {
            End = end;
            Weight = weight;
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

    public class Dijkstra : Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        private Graph _graph;
        private Random rand;
        private Node nodeStart;

        public Dijkstra()
        {
            Info = new AlgorithmInformations();
            _graph = new Graph();
            rand = new Random();

            Info.DauRa = "Đường đi ngắn nhất giữa một đỉnh đến các đỉnh còn lại";
            Info.DauVao = "Đỉnh bắt đầu và các trọng số của cạnh nối các đỉnh";
            Info.GhiChu = "Dữ liệu nhập theo định dạng sau: Dòng đầu là *tên* của đỉnh xuất phát, "
                + "n dòng tiếp theo là các mô tả trọng số các cạnh của đồ thị, ví dụ:\r\n\r\n"
                + "A\r\n"
                + "A B 10\r\n"
                + "A C 5\r\n"
                + "B C 2\r\n"
                + "C B 3\r\n"
                + "C D 2\r\n"
                + "C E 9\r\n"
                + "B E 1\r\n"
                + "D A 7\r\n"
                + "D E 6\r\n"
                + "E D 4\r\n";
            Info.Kieu = "Tham lam";
            Info.Chuong = "Chương 6";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Dijkstra";
            Info.TheLoai = "Tìm đường";
            Info.XuLi = "Tìm đường đi ngắn nhất từ một đỉnh nguồn đến các đỉnh còn lại của đồ thị";
        }

        /* private string GenerateName(int length)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; ++i)
            {
                sb.Append((char)(rand.Next(26) + 65));
            }
            
            return sb.ToString();
        } */

        public bool GenerateInput(int n, Output output)
        {
            // output.WriteLine(n);

            HashSet<string> lstNodes = new HashSet<string>();
            for (int i = 0; i < n; ++i)
            {
                /* string s = GenerateName(5);
                while (lstNodes.Contains(s))
                {
                    s = GenerateName(5);
                } */

                lstNodes.Add(i.ToString());
            }

            output.WriteLine(lstNodes.ElementAt(rand.Next(lstNodes.Count - 1)));
            // output.WriteLine(lstNodes.ElementAt(rand.Next(lstNodes.Count - 1)));

            for (int i = 0; i < lstNodes.Count; ++i)
            {
                for (int j = 0; j < lstNodes.Count; ++j)
                {
                    if (i == j) continue;
                    output.WriteLine(lstNodes.ElementAt(i) + " " + lstNodes.ElementAt(j) + " " + rand.Next(100));
                }
            }
            
            return true;
        }

        private List<Edge> edges;
        private void DoDijkstra()
        {
            while (edges.Count > 0)
            {
                List<Edge> es = edges[0].End.GetNeighbors();

                foreach (var e in es)
                {
                    if (e.End.Value > edges[0].End.Value + e.Weight)
                    {
                        e.End.Value = edges[0].End.Value + e.Weight;
                    }
                }

                edges.AddRange(es);
                edges[0].End.Solved = true;
                edges.RemoveAt(0);
            }
        }

        public bool Performance()
        {
            edges = new List<Edge>();

            foreach (var n in _graph.Nodes)
            {
                n.Value = double.MaxValue;
                n.Solved = false;
            }

            foreach (var e in nodeStart.GetNeighbors())
            {
                e.End.Value = e.Weight;
                edges.Add(e);
            }

            nodeStart.Solved = true;
            edges = edges.OrderBy(e => e.Weight).ToList();

            DoDijkstra();
            return true;
        }

        public bool PrepareInput()
        {
            // int n = Input.NextInt();
            string start = Input.NextWord();

            while(true)
            {
                string s = Input.NextWord();
                if (s == null) break;

                string e = Input.NextWord();
                double w = Input.NextInt();
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

                ns.ConnectToNode(ne, w);
            }

            nodeStart = _graph.FindNodeByName(start);

            return true;
        }

        public bool PrintOutput()
        {
            foreach(var n in _graph.Nodes)
            {
                if (n.Name.Equals(nodeStart.Name))
                    continue;

                Output.WriteLine(n.Name + " " + n.Value);
            }

            return true;
        }
    }
}
