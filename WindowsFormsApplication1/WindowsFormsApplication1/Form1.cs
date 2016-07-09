using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton_Commit_Click(object sender, EventArgs e)
        {
            this.textEdit_Result.Text = HttpService.HttpServiceLogic.Post2(new Uri(this.textEdit_Uri.Text), this.textEdit_Para.Text);
        }
    }
}
