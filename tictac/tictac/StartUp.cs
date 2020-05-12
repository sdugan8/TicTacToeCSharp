using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictac
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 changeForm = new Form1();
            changeForm.ShowDialog();
            this.Close();
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 changeForm = new Form2();
            changeForm.ShowDialog();
            this.Close();
        }
    }
}
