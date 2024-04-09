using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_
{
    public partial class StartupMenu : Form
    {
        Form1 gameForm;
        public StartupMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            gameForm = new Form1();
            gameForm.Show(this);
            this.Hide();
        }
    }
}
