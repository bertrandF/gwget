using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadersPrompt
{

    public partial class HeaderPrompt : Form
    {
        public string HeaderName { get; private set; }
        public string HeaderValue { get; private set; }

        public HeaderPrompt()
        {
            InitializeComponent();
        }
        private void OkButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.HeaderName = this.comboBox1.Text;
            this.HeaderValue = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.HeaderName = null;
            this.HeaderValue = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
