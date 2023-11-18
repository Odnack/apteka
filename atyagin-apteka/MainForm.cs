using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matyagin_apteka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newApplications_Click(object sender, EventArgs e)
        {
            Hide();
            var newApplication = new NewApplication();
            newApplication.ShowDialog();
            Show();
        }
    }
}
