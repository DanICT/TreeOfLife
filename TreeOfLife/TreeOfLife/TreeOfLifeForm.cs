using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeOfLife.Controllers;

namespace TreeOfLife
{
    public partial class TreeOfLifeForm : Form
    {

        private TreeOfLifeController controller;
        public TreeOfLifeForm()
        {
            InitializeComponent();
        }

        private void TreeOfLifeForm_Load(object sender, EventArgs e)
        {
            controller = new TreeOfLifeController();
        }
    }
}
