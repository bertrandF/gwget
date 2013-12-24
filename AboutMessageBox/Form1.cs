/**
 *  gwget is a little GUI http client
    Copyright (C) 2013  Bertrand Feuillerat

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see [http://www.gnu.org/licenses/].
 * **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutMessageBox
{
    public partial class AboutMessageBox : Form
    {
        private string version = "GWGET 0.1\n\n";
        private string licence = Resource1.String1;
        public AboutMessageBox()
        {
            InitializeComponent();

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = this.version + this.licence;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
