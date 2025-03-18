using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMeClient
{
    public partial class InputBox : Form
    {
        private string response = null;
          
        public string Response
        {
            get { return response; }
        }


        public InputBox(string title)
        {
            InitializeComponent();
            lbltitle.Text = title;
            /*foreach (char letter in lbltitle.Text)
            {
                lbltitle.Left -= 2;
            }*/
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          response = txtInput.Text;
            this.Close();
        }
    }
}
