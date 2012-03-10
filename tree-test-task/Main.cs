using System;
using System.Collections;

namespace treetesttask
{
    class MainClass
    {       
        public static void Main (string[] args)
        {
            Node root = new Node();
            root.Value = 1;
            
            Node node1 = new Node();
            node1.Value = 15;
            Node node2 = new Node();
            node2.Value = 45;
            Node node3 = new Node();
            node3.Value = 13;
            
            root.ChildNodes.Add(node1);
            root.ChildNodes.Add(node2);
            root.ChildNodes.Add(node3);
            
            Node node4 = new Node();
            node4.Value = 7;
            Node node5 = new Node();
            node5.Value = 2;
            
            node1.ChildNodes.Add(node4);
            node1.ChildNodes.Add(node5);
            
            Node node6 = new Node();
            node6.Value = 1;
            
            node3.ChildNodes.Add(node6);
            
            int sum = root.Sum;
            Console.WriteLine ("Sum = {0}", sum);
        }
    }
}
