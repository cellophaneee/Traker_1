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
    [Serializable]
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();

        }
        ControllerFormMain _controller;



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _controller.Saves();
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                     
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormCreate FormCreate = new FormCreate();
            Visible = false;
            FormCreate.ShowDialog();
            Visible = true;
            _controller.UpdateDataGried();
        }

        private void dateTimePickerMain_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;          
        }

        private void dateTimePicker15_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker15.Format = DateTimePickerFormat.Time;
            dateTimePicker15.ShowUpDown = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }
        
        private void FormMain_Load_1(object sender, EventArgs e)
        {
            
            _controller = new ControllerFormMain(this);
            _controller.UpdateDataGried();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.Delete();
            _controller.UpdateDataGried();

        }
    }

    
}

