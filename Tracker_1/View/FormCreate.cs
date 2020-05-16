using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker_1.Controller;

namespace Tracker_1
{
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }
        private ControllerFormCreate _controller;

        private void Form2_Load(object sender, EventArgs e)
        {
            _controller = new ControllerFormCreate(this);



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (_controller.AddTracker() == false)
                MessageBox.Show("Ошибка");
            else
                Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
