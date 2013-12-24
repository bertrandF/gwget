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

namespace gwget
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Request = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HostLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.UserAgentLabel = new System.Windows.Forms.Label();
            this.AdditionalFieldsLabel = new System.Windows.Forms.Label();
            this.HostnameTextBox = new System.Windows.Forms.TextBox();
            this.PortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.UserAgentComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.RichTextBox();
            this.HTTPVersionLabel = new System.Windows.Forms.Label();
            this.HTTPVersionTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddHeaderButton = new System.Windows.Forms.Button();
            this.DeleteHeaderButton = new System.Windows.Forms.Button();
            this.HeaderListView = new System.Windows.Forms.ListView();
            this.HeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Response = new System.Windows.Forms.GroupBox();
            this.ResponseTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ResponseTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResponseWebBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Request.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.Response.SuspendLayout();
            this.ResponseTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Request);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Response);
            this.splitContainer1.Size = new System.Drawing.Size(777, 481);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 0;
            // 
            // Request
            // 
            this.Request.Controls.Add(this.tableLayoutPanel1);
            this.Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Request.Location = new System.Drawing.Point(0, 0);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(337, 481);
            this.Request.TabIndex = 0;
            this.Request.TabStop = false;
            this.Request.Text = "Request";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tableLayoutPanel1.Controls.Add(this.HostLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PortLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MethodLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserAgentLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.AdditionalFieldsLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.HostnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PortNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MethodComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserAgentComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.FileLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FileTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DataLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.DataTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.HTTPVersionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HTTPVersionTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.HeaderListView, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostLabel.Location = new System.Drawing.Point(3, 0);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(70, 25);
            this.HostLabel.TabIndex = 0;
            this.HostLabel.Text = "Host Name :";
            this.HostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortLabel.Location = new System.Drawing.Point(3, 25);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(70, 25);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port :";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodLabel.Location = new System.Drawing.Point(3, 50);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(70, 25);
            this.MethodLabel.TabIndex = 2;
            this.MethodLabel.Text = "Method :";
            this.MethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserAgentLabel
            // 
            this.UserAgentLabel.AutoSize = true;
            this.UserAgentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgentLabel.Location = new System.Drawing.Point(3, 125);
            this.UserAgentLabel.Name = "UserAgentLabel";
            this.UserAgentLabel.Size = new System.Drawing.Size(70, 25);
            this.UserAgentLabel.TabIndex = 5;
            this.UserAgentLabel.Text = "User-Agent :";
            this.UserAgentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdditionalFieldsLabel
            // 
            this.AdditionalFieldsLabel.AutoSize = true;
            this.AdditionalFieldsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdditionalFieldsLabel.Location = new System.Drawing.Point(3, 150);
            this.AdditionalFieldsLabel.Name = "AdditionalFieldsLabel";
            this.tableLayoutPanel1.SetRowSpan(this.AdditionalFieldsLabel, 2);
            this.AdditionalFieldsLabel.Size = new System.Drawing.Size(70, 105);
            this.AdditionalFieldsLabel.TabIndex = 7;
            this.AdditionalFieldsLabel.Text = "Additional fields :";
            this.AdditionalFieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HostnameTextBox
            // 
            this.HostnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostnameTextBox.Location = new System.Drawing.Point(79, 3);
            this.HostnameTextBox.Name = "HostnameTextBox";
            this.HostnameTextBox.Size = new System.Drawing.Size(249, 20);
            this.HostnameTextBox.TabIndex = 8;
            // 
            // PortNumericUpDown
            // 
            this.PortNumericUpDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.PortNumericUpDown.Location = new System.Drawing.Point(249, 28);
            this.PortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortNumericUpDown.Name = "PortNumericUpDown";
            this.PortNumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.PortNumericUpDown.TabIndex = 9;
            this.PortNumericUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "TRACE",
            "CONNECT",
            "PATCH",
            "HEAD",
            "OPTIONS"});
            this.MethodComboBox.Location = new System.Drawing.Point(79, 53);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(249, 21);
            this.MethodComboBox.TabIndex = 13;
            this.MethodComboBox.Text = "GET";
            // 
            // UserAgentComboBox
            // 
            this.UserAgentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UserAgentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgentComboBox.FormattingEnabled = true;
            this.UserAgentComboBox.Location = new System.Drawing.Point(79, 128);
            this.UserAgentComboBox.Name = "UserAgentComboBox";
            this.UserAgentComboBox.Size = new System.Drawing.Size(249, 21);
            this.UserAgentComboBox.TabIndex = 14;
            this.UserAgentComboBox.Text = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9) AppleWebKit/537.71 (KHTML, like Geck" +
    "o) Version/7.0 Safari/537.71";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(253, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 121);
            this.button1.TabIndex = 16;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileLabel.Location = new System.Drawing.Point(3, 100);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(70, 25);
            this.FileLabel.TabIndex = 17;
            this.FileLabel.Text = "File :";
            this.FileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileTextBox
            // 
            this.FileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTextBox.Location = new System.Drawing.Point(79, 103);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(249, 20);
            this.FileTextBox.TabIndex = 18;
            this.FileTextBox.Text = "index.php";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLabel.Location = new System.Drawing.Point(3, 255);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(70, 80);
            this.DataLabel.TabIndex = 19;
            this.DataLabel.Text = "Data :";
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTextBox.Location = new System.Drawing.Point(79, 258);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(249, 74);
            this.DataTextBox.TabIndex = 20;
            this.DataTextBox.Text = "";
            // 
            // HTTPVersionLabel
            // 
            this.HTTPVersionLabel.AutoSize = true;
            this.HTTPVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPVersionLabel.Location = new System.Drawing.Point(3, 75);
            this.HTTPVersionLabel.Name = "HTTPVersionLabel";
            this.HTTPVersionLabel.Size = new System.Drawing.Size(70, 25);
            this.HTTPVersionLabel.TabIndex = 21;
            this.HTTPVersionLabel.Text = "Http Ver. :";
            this.HTTPVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HTTPVersionTextBox
            // 
            this.HTTPVersionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPVersionTextBox.Location = new System.Drawing.Point(79, 78);
            this.HTTPVersionTextBox.Name = "HTTPVersionTextBox";
            this.HTTPVersionTextBox.Size = new System.Drawing.Size(249, 20);
            this.HTTPVersionTextBox.TabIndex = 22;
            this.HTTPVersionTextBox.Text = "HTTP/1.1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(79, 233);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddHeaderButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DeleteHeaderButton);
            this.splitContainer2.Size = new System.Drawing.Size(249, 19);
            this.splitContainer2.SplitterDistance = 83;
            this.splitContainer2.TabIndex = 23;
            // 
            // AddHeaderButton
            // 
            this.AddHeaderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHeaderButton.Location = new System.Drawing.Point(0, 0);
            this.AddHeaderButton.Name = "AddHeaderButton";
            this.AddHeaderButton.Size = new System.Drawing.Size(83, 19);
            this.AddHeaderButton.TabIndex = 0;
            this.AddHeaderButton.Text = "Add Header";
            this.AddHeaderButton.UseVisualStyleBackColor = true;
            this.AddHeaderButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddHeaderButton_MouseClick);
            // 
            // DeleteHeaderButton
            // 
            this.DeleteHeaderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteHeaderButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteHeaderButton.Name = "DeleteHeaderButton";
            this.DeleteHeaderButton.Size = new System.Drawing.Size(162, 19);
            this.DeleteHeaderButton.TabIndex = 0;
            this.DeleteHeaderButton.Text = "Delete Header";
            this.DeleteHeaderButton.UseVisualStyleBackColor = true;
            this.DeleteHeaderButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteHeaderButton_MouseClick);
            // 
            // HeaderListView
            // 
            this.HeaderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderColumn,
            this.ValueColumn});
            this.HeaderListView.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HeaderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderListView.FullRowSelect = true;
            this.HeaderListView.GridLines = true;
            this.HeaderListView.Location = new System.Drawing.Point(79, 153);
            this.HeaderListView.Name = "HeaderListView";
            this.HeaderListView.Size = new System.Drawing.Size(249, 74);
            this.HeaderListView.TabIndex = 24;
            this.HeaderListView.UseCompatibleStateImageBehavior = false;
            this.HeaderListView.View = System.Windows.Forms.View.Details;
            // 
            // HeaderColumn
            // 
            this.HeaderColumn.Text = "Name";
            this.HeaderColumn.Width = 112;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 113;
            // 
            // Response
            // 
            this.Response.Controls.Add(this.ResponseTabs);
            this.Response.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Response.Location = new System.Drawing.Point(0, 0);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(436, 481);
            this.Response.TabIndex = 0;
            this.Response.TabStop = false;
            this.Response.Text = "Response";
            // 
            // ResponseTabs
            // 
            this.ResponseTabs.Controls.Add(this.tabPage1);
            this.ResponseTabs.Controls.Add(this.tabPage2);
            this.ResponseTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseTabs.Location = new System.Drawing.Point(3, 16);
            this.ResponseTabs.Name = "ResponseTabs";
            this.ResponseTabs.SelectedIndex = 0;
            this.ResponseTabs.Size = new System.Drawing.Size(430, 462);
            this.ResponseTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ResponseTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(422, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseTextBox.Location = new System.Drawing.Point(3, 3);
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ReadOnly = true;
            this.ResponseTextBox.Size = new System.Drawing.Size(416, 430);
            this.ResponseTextBox.TabIndex = 0;
            this.ResponseTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResponseWebBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Browser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResponseWebBrowser
            // 
            this.ResponseWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.ResponseWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ResponseWebBrowser.Name = "ResponseWebBrowser";
            this.ResponseWebBrowser.ScriptErrorsSuppressed = true;
            this.ResponseWebBrowser.Size = new System.Drawing.Size(416, 430);
            this.ResponseWebBrowser.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 505);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphical wget";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Request.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUpDown)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Response.ResumeLayout(false);
            this.ResponseTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Request;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.GroupBox Response;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.Label UserAgentLabel;
        private System.Windows.Forms.Label AdditionalFieldsLabel;
        private System.Windows.Forms.TextBox HostnameTextBox;
        private System.Windows.Forms.NumericUpDown PortNumericUpDown;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.ComboBox UserAgentComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox ResponseTextBox;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.RichTextBox DataTextBox;
        private System.Windows.Forms.Label HTTPVersionLabel;
        private System.Windows.Forms.TextBox HTTPVersionTextBox;
        private System.Windows.Forms.TabControl ResponseTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser ResponseWebBrowser;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button AddHeaderButton;
        private System.Windows.Forms.Button DeleteHeaderButton;
        private System.Windows.Forms.ListView HeaderListView;
        private System.Windows.Forms.ColumnHeader HeaderColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}

