using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMethods;

namespace practProject1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            Task1 task = new Task1();
            task.ShowDialog();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            Task2 task = new Task2();
            task.ShowDialog();
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            Task3 task = new Task3();
            task.ShowDialog();
        }

        private void Task4_Click(object sender, EventArgs e)
        {
            Task4 task = new Task4();
            task.ShowDialog();
        }
    }
}
