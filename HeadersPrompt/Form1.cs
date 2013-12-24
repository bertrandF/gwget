﻿/**
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
