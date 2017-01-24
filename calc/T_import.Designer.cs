namespace calc
{
    partial class T_import
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btok = new System.Windows.Forms.Button();
            this.Msglist = new System.Windows.Forms.ListBox();
            this.btcopy = new System.Windows.Forms.Button();
            this.btcls = new System.Windows.Forms.Button();
            this.goldkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(78, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 128);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = " ";
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(421, 138);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(86, 41);
            this.btok.TabIndex = 1;
            this.btok.Text = "计算";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.button1_Click);
            // 
            // Msglist
            // 
            this.Msglist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Msglist.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Msglist.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Msglist.FormattingEnabled = true;
            this.Msglist.ItemHeight = 17;
            this.Msglist.Location = new System.Drawing.Point(78, 196);
            this.Msglist.Name = "Msglist";
            this.Msglist.Size = new System.Drawing.Size(321, 174);
            this.Msglist.TabIndex = 8;
            // 
            // btcopy
            // 
            this.btcopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcopy.Location = new System.Drawing.Point(421, 51);
            this.btcopy.Name = "btcopy";
            this.btcopy.Size = new System.Drawing.Size(34, 31);
            this.btcopy.TabIndex = 9;
            this.btcopy.Text = "copy";
            this.btcopy.UseVisualStyleBackColor = true;
            this.btcopy.Click += new System.EventHandler(this.btcopy_Click);
            // 
            // btcls
            // 
            this.btcls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcls.Location = new System.Drawing.Point(473, 51);
            this.btcls.Name = "btcls";
            this.btcls.Size = new System.Drawing.Size(34, 31);
            this.btcls.TabIndex = 10;
            this.btcls.Text = "cls";
            this.btcls.UseVisualStyleBackColor = true;
            this.btcls.Click += new System.EventHandler(this.btcls_Click);
            // 
            // goldkey
            // 
            this.goldkey.Location = new System.Drawing.Point(421, 238);
            this.goldkey.Name = "goldkey";
            this.goldkey.Size = new System.Drawing.Size(86, 38);
            this.goldkey.TabIndex = 11;
            this.goldkey.UseVisualStyleBackColor = true;
            this.goldkey.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // T_import
            // 
            this.AcceptButton = this.goldkey;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 392);
            this.Controls.Add(this.goldkey);
            this.Controls.Add(this.btcls);
            this.Controls.Add(this.btcopy);
            this.Controls.Add(this.Msglist);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "T_import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入数据算加班时长";
            this.Load += new System.EventHandler(this.T_import_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.ListBox Msglist;
        private System.Windows.Forms.Button btcopy;
        private System.Windows.Forms.Button btcls;
        private System.Windows.Forms.Button goldkey;
    }
}