using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class BFS
    {
        public static void Search( Node root )
        {
            var queue = new Queue<Node>();
            root.Visited = true;
            Visit(root);
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                var current_node = queue.Dequeue();
                if (current_node.Adjacent != null)
                { 
                    foreach (var node in current_node.Adjacent)
                    {
                        if(!node.Visited)
                        {
                            Visit(node);
                            node.Visited = true;
                            queue.Enqueue(node);
                        }
                    }
                }
            }
        }

        private static void Visit(Node root)
        {
            // nop
        }
    }
}
