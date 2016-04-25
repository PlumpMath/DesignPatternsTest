using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class MainForm : Form
    {
        private MyMediator mediator = new MyMediator();
        public MainForm()
        {
            InitializeComponent();
            mediator.Register(btnAdd);
            mediator.Register(btnClear);
            mediator.Register(txtName);
            mediator.Register(listBox1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mediator.Add();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mediator.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            mediator.TextChanged();
        }
    }
}
