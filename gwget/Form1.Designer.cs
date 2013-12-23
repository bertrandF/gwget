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
            this.RefererLabel = new System.Windows.Forms.Label();
            this.HostnameLabel = new System.Windows.Forms.Label();
            this.UserAgentLabel = new System.Windows.Forms.Label();
            this.CookieLabel = new System.Windows.Forms.Label();
            this.AdditionalFieldsLabel = new System.Windows.Forms.Label();
            this.HostnameTextBox = new System.Windows.Forms.TextBox();
            this.PortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RefererTextBox = new System.Windows.Forms.TextBox();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalFieldsTextBox = new System.Windows.Forms.RichTextBox();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.UserAgentComboBox = new System.Windows.Forms.ComboBox();
            this.CookieTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.RichTextBox();
            this.HTTPVersionLabel = new System.Windows.Forms.Label();
            this.HTTPVersionTextBox = new System.Windows.Forms.TextBox();
            this.Response = new System.Windows.Forms.GroupBox();
            this.ResponseTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Request.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUpDown)).BeginInit();
            this.Response.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Request);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Response);
            this.splitContainer1.Size = new System.Drawing.Size(777, 596);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 0;
            // 
            // Request
            // 
            this.Request.Controls.Add(this.tableLayoutPanel1);
            this.Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Request.Location = new System.Drawing.Point(0, 0);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(337, 596);
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
            this.tableLayoutPanel1.Controls.Add(this.RefererLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.HostnameLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.UserAgentLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.CookieLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.AdditionalFieldsLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.HostnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PortNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RefererTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.HostTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AdditionalFieldsTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.MethodComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserAgentComboBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.CookieTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.FileLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FileTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DataLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.DataTextBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.HTTPVersionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HTTPVersionTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            // RefererLabel
            // 
            this.RefererLabel.AutoSize = true;
            this.RefererLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefererLabel.Location = new System.Drawing.Point(3, 125);
            this.RefererLabel.Name = "RefererLabel";
            this.RefererLabel.Size = new System.Drawing.Size(70, 25);
            this.RefererLabel.TabIndex = 3;
            this.RefererLabel.Text = "Referer :";
            this.RefererLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HostnameLabel
            // 
            this.HostnameLabel.AutoSize = true;
            this.HostnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostnameLabel.Location = new System.Drawing.Point(3, 150);
            this.HostnameLabel.Name = "HostnameLabel";
            this.HostnameLabel.Size = new System.Drawing.Size(70, 25);
            this.HostnameLabel.TabIndex = 4;
            this.HostnameLabel.Text = "Host :";
            this.HostnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserAgentLabel
            // 
            this.UserAgentLabel.AutoSize = true;
            this.UserAgentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgentLabel.Location = new System.Drawing.Point(3, 175);
            this.UserAgentLabel.Name = "UserAgentLabel";
            this.UserAgentLabel.Size = new System.Drawing.Size(70, 25);
            this.UserAgentLabel.TabIndex = 5;
            this.UserAgentLabel.Text = "User-Agent :";
            this.UserAgentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CookieLabel
            // 
            this.CookieLabel.AutoSize = true;
            this.CookieLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CookieLabel.Location = new System.Drawing.Point(3, 200);
            this.CookieLabel.Name = "CookieLabel";
            this.CookieLabel.Size = new System.Drawing.Size(70, 25);
            this.CookieLabel.TabIndex = 6;
            this.CookieLabel.Text = "Cookie :";
            this.CookieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdditionalFieldsLabel
            // 
            this.AdditionalFieldsLabel.AutoSize = true;
            this.AdditionalFieldsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdditionalFieldsLabel.Location = new System.Drawing.Point(3, 225);
            this.AdditionalFieldsLabel.Name = "AdditionalFieldsLabel";
            this.AdditionalFieldsLabel.Size = new System.Drawing.Size(70, 102);
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
            this.HostnameTextBox.TextChanged += new System.EventHandler(this.HostnameTextBox_TextChanged);
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
            // RefererTextBox
            // 
            this.RefererTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefererTextBox.Location = new System.Drawing.Point(79, 128);
            this.RefererTextBox.Name = "RefererTextBox";
            this.RefererTextBox.Size = new System.Drawing.Size(249, 20);
            this.RefererTextBox.TabIndex = 10;
            // 
            // HostTextBox
            // 
            this.HostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostTextBox.Location = new System.Drawing.Point(79, 153);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(249, 20);
            this.HostTextBox.TabIndex = 11;
            // 
            // AdditionalFieldsTextBox
            // 
            this.AdditionalFieldsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdditionalFieldsTextBox.Location = new System.Drawing.Point(79, 228);
            this.AdditionalFieldsTextBox.Name = "AdditionalFieldsTextBox";
            this.AdditionalFieldsTextBox.Size = new System.Drawing.Size(249, 96);
            this.AdditionalFieldsTextBox.TabIndex = 12;
            this.AdditionalFieldsTextBox.Text = "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0." +
    "8\\\nAccept-Encoding: gzip,deflate,sdch\nAccept-Language: fr-FR,fr;q=0.8,en-US;q=0." +
    "6,en;q=0.4";
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
            this.UserAgentComboBox.Location = new System.Drawing.Point(79, 178);
            this.UserAgentComboBox.Name = "UserAgentComboBox";
            this.UserAgentComboBox.Size = new System.Drawing.Size(249, 21);
            this.UserAgentComboBox.TabIndex = 14;
            this.UserAgentComboBox.Text = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9) AppleWebKit/537.71 (KHTML, like Geck" +
    "o) Version/7.0 Safari/537.71";
            // 
            // CookieTextBox
            // 
            this.CookieTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CookieTextBox.Location = new System.Drawing.Point(79, 203);
            this.CookieTextBox.Name = "CookieTextBox";
            this.CookieTextBox.Size = new System.Drawing.Size(249, 20);
            this.CookieTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(253, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
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
            this.DataLabel.Location = new System.Drawing.Point(3, 327);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(70, 225);
            this.DataLabel.TabIndex = 19;
            this.DataLabel.Text = "Data :";
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTextBox.Location = new System.Drawing.Point(79, 330);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(249, 219);
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
            // Response
            // 
            this.Response.Controls.Add(this.ResponseTextBox);
            this.Response.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Response.Location = new System.Drawing.Point(0, 0);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(436, 596);
            this.Response.TabIndex = 0;
            this.Response.TabStop = false;
            this.Response.Text = "Response";
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseTextBox.Location = new System.Drawing.Point(3, 16);
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ReadOnly = true;
            this.ResponseTextBox.Size = new System.Drawing.Size(430, 577);
            this.ResponseTextBox.TabIndex = 0;
            this.ResponseTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 596);
            this.Controls.Add(this.splitContainer1);
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
            this.Response.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Request;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.GroupBox Response;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.Label RefererLabel;
        private System.Windows.Forms.Label HostnameLabel;
        private System.Windows.Forms.Label UserAgentLabel;
        private System.Windows.Forms.Label CookieLabel;
        private System.Windows.Forms.Label AdditionalFieldsLabel;
        private System.Windows.Forms.TextBox HostnameTextBox;
        private System.Windows.Forms.NumericUpDown PortNumericUpDown;
        private System.Windows.Forms.TextBox RefererTextBox;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.RichTextBox AdditionalFieldsTextBox;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.ComboBox UserAgentComboBox;
        private System.Windows.Forms.TextBox CookieTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox ResponseTextBox;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.RichTextBox DataTextBox;
        private System.Windows.Forms.Label HTTPVersionLabel;
        private System.Windows.Forms.TextBox HTTPVersionTextBox;

    }
}

