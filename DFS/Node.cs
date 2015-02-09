using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS
{
    public class Node
    {
        public bool Visited { get; set; }

        public Node[] Adjacent { get; set; }
    }
}
