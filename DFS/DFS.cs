using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class DFS
    {
        public void Search( Node root )
        {
            if(root == null)
            {
                return;
            }
            Visit(root);
            root.Visited = true;
            foreach (var node in root.Adjacent)
            {
                if(!node.Visited)
                {
                    Search(node);
                }
            }
        }

        private void Visit(Node root)
        {
            // nop
        }
    }
}
