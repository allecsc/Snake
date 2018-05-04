using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class About : Form
    {
        Form1 main = Form.ActiveForm as Form1;

        public About()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
            main.timer1.Enabled = true;
            main.pause_panel.Visible = false;
        }
    }
}
