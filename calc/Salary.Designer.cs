namespace calc
{
    partial class Salary
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.txtBase = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTy3 = new System.Windows.Forms.NumericUpDown();
            this.txtTy2 = new System.Windows.Forms.NumericUpDown();
            this.txtTy1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbllogo = new System.Windows.Forms.Label();
            this.menus = new System.Windows.Forms.MenuStrip();
            this.tools = new System.Windows.Forms.ToolStripMenuItem();
            this.T_import = new System.Windows.Forms.ToolStripMenuItem();
            this.一键导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.rtxtmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.btncopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnparse = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTy1)).BeginInit();
            this.menus.SuspendLayout();
            this.rtxtmenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBase.Location = new System.Drawing.Point(17, 76);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(375, 34);
            this.txtBase.TabIndex = 1;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.txtTy3);
            this.groupBox1.Controls.Add(this.txtTy2);
            this.groupBox1.Controls.Add(this.txtTy1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加班";
            // 
            // txtTy3
            // 
            this.txtTy3.Location = new System.Drawing.Point(94, 118);
            this.txtTy3.Name = "txtTy3";
            this.txtTy3.Size = new System.Drawing.Size(83, 25);
            this.txtTy3.TabIndex = 17;
            this.txtTy3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTy2
            // 
            this.txtTy2.Location = new System.Drawing.Point(283, 24);
            this.txtTy2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtTy2.Name = "txtTy2";
            this.txtTy2.Size = new System.Drawing.Size(77, 25);
            this.txtTy2.TabIndex = 16;
            this.txtTy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTy1
            // 
            this.txtTy1.Location = new System.Drawing.Point(94, 24);
            this.txtTy1.Name = "txtTy1";
            this.txtTy1.Size = new System.Drawing.Size(83, 25);
            this.txtTy1.TabIndex = 15;
            this.txtTy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "不怎麼可能的3類加班";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(212, 113);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(76, 34);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(208, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "二類加班";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "一類加班";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Location = new System.Drawing.Point(141, 24);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(0, 15);
            this.lbllogo.TabIndex = 10;
            // 
            // menus
            // 
            this.menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools,
            this.一键导入ToolStripMenuItem});
            this.menus.Location = new System.Drawing.Point(0, 0);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(419, 28);
            this.menus.TabIndex = 11;
            this.menus.Text = "menuStrip1";
            // 
            // tools
            // 
            this.tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T_import});
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(51, 24);
            this.tools.Text = "工具";
            this.tools.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // T_import
            // 
            this.T_import.Name = "T_import";
            this.T_import.Size = new System.Drawing.Size(183, 24);
            this.T_import.Text = "导入数据算时长";
            this.T_import.Click += new System.EventHandler(this.T_import_Click);
            // 
            // 一键导入ToolStripMenuItem
            // 
            this.一键导入ToolStripMenuItem.Name = "一键导入ToolStripMenuItem";
            this.一键导入ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.一键导入ToolStripMenuItem.Text = "一键导入";
            this.一键导入ToolStripMenuItem.Click += new System.EventHandler(this.一键导入ToolStripMenuItem_Click);
            // 
            // rtxt
            // 
            this.rtxt.BackColor = System.Drawing.SystemColors.Control;
            this.rtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt.ContextMenuStrip = this.rtxtmenu;
            this.rtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt.Location = new System.Drawing.Point(3, 21);
            this.rtxt.MaxLength = 2147;
            this.rtxt.Name = "rtxt";
            this.rtxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxt.Size = new System.Drawing.Size(413, 207);
            this.rtxt.TabIndex = 12;
            this.rtxt.Text = "";
            // 
            // rtxtmenu
            // 
            this.rtxtmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.cutbtn,
            this.btncopy,
            this.btnparse});
            this.rtxtmenu.Name = "rtxtmenu";
            this.rtxtmenu.ShowCheckMargin = true;
            this.rtxtmenu.ShowImageMargin = false;
            this.rtxtmenu.Size = new System.Drawing.Size(109, 82);
            this.rtxtmenu.Text = "菜单";
            this.rtxtmenu.Opening += new System.ComponentModel.CancelEventHandler(this.rtxtmenu_Opening);
            this.rtxtmenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rtxtmenu_MouseMove);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // cutbtn
            // 
            this.cutbtn.Name = "cutbtn";
            this.cutbtn.Size = new System.Drawing.Size(108, 24);
            this.cutbtn.Text = "剪切";
            this.cutbtn.Click += new System.EventHandler(this.cutbtn_Click);
            // 
            // btncopy
            // 
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(108, 24);
            this.btncopy.Text = "复制";
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // btnparse
            // 
            this.btnparse.Name = "btnparse";
            this.btnparse.Size = new System.Drawing.Size(108, 24);
            this.btnparse.Text = "粘贴";
            this.btnparse.Click += new System.EventHandler(this.btnparse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Beige;
            this.groupBox2.Controls.Add(this.rtxt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 231);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // Salary
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.menus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menus;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "这是我的加班";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTy1)).EndInit();
            this.menus.ResumeLayout(false);
            this.menus.PerformLayout();
            this.rtxtmenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtTy2;
        private System.Windows.Forms.NumericUpDown txtTy1;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.MenuStrip menus;
        private System.Windows.Forms.ToolStripMenuItem tools;
        private System.Windows.Forms.ToolStripMenuItem T_import;
        private System.Windows.Forms.ToolStripMenuItem 一键导入ToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown txtTy3;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip rtxtmenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutbtn;
        private System.Windows.Forms.ToolStripMenuItem btncopy;
        private System.Windows.Forms.ToolStripMenuItem btnparse;

    }
}

