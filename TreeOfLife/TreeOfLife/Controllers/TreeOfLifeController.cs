using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeOfLife.Model;

namespace TreeOfLife.Controllers
{
    class TreeOfLifeController
    {
        private Category treeOfLife { get; set; }

        public TreeOfLifeController()
        {
            this.treeOfLife = new Category("Tree of life", "");
        }

    }
}
