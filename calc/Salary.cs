using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{

    public partial class Salary : Form
    {
        public FontFamily fontawesome;
        public Salary()
        {
            InitializeComponent();
            System.IO.File.WriteAllBytes(@"myfont.ttf", Properties.Resources.fontawesome);
            PrivateFontCollection pf = new PrivateFontCollection();
            pf.AddFontFile("myfont.ttf");
            fontawesome = pf.Families[0];
        }
        static Color defaultcolor = Color.Black;
        private void Submit_Click(object sender, EventArgs e)
        {
            this.rtxt.Clear();
            double ot1 = 0, ot2 = 0, ot3 = 0, basesalary = 0;
            try
            {
                if (Convert.ToDouble(txtTy1.Value) > 0)
                    ot1 = Convert.ToDouble(txtTy1.Text);
                if (Convert.ToDouble(txtTy2.Value) > 0)
                    ot2 = Convert.ToDouble(txtTy2.Text);
                if (Convert.ToDouble(txtTy3.Value) > 0)
                    ot3 = Convert.ToDouble(txtTy3.Text);
                basesalary = Convert.ToDouble(txtBase.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("您輸入有誤，請重新輸入", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mysalary s = new mysalary(basesalary, ot1, ot2, ot3);
            double x = Math.Round(s.MaxSalary(), 2);
            SetRichText("您的時薪為:" + Math.Round(s.salaryPHour(), 2), defaultcolor);
            SetRichText("最高薪資:" + x, defaultcolor);
            SetRichText("實際薪資:" + Math.Round(s.salaryPMonth(), 2).ToString(), Color.Red);
            SetRichText("總加班時長(單位小時):" + (ot1 + ot2+ot3).ToString(), defaultcolor);
            SetRichText("一類加班(單位小時):" + ot1, defaultcolor);
            SetRichText("二類加班(單位小時):" + ot2, defaultcolor);
            SetRichText("三類加班(單位小時):" + ot3, defaultcolor);
            SetRichText("您的加班工資為" + Math.Round(s.OTsalary(), 2), defaultcolor);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.rtxt.Clear();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            一键导入ToolStripMenuItem.Font = tools.Font = Submit.Font = new Font(fontawesome, 10);
            groupBox1.Font = new Font(fontawesome, 10);
            lbllogo.Font = new Font(fontawesome, 30);
            lbllogo.Text = "\uF109" + "     " + "\uF0D6";
            Submit.Text += "\uF157";
            groupBox1.Text += "\uf186";
            tools.Text = "\uf0ad" + tools.Text;
            一键导入ToolStripMenuItem.Text = "\uf0d0" + 一键导入ToolStripMenuItem.Text;
            btncopy.Font = btnparse.Font = cutbtn.Font = new Font(fontawesome, 10);
            btnparse.Text = "\uf0ea  " + btnparse.Text;
            cutbtn.Text = "\uf0c4  " + cutbtn.Text;
            btncopy.Text = "\uf0c5  " + btncopy.Text;
            //clipboard f0ea 剪刀f0c4 复制 f0c5
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void T_import_Click(object sender, EventArgs e)
        {
            T_import ti = new T_import();
            ti.Show();
        }

        private void 一键导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string source = String.Empty;
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
                source = (String)iData.GetData(DataFormats.Text);
            }
            Regex reg = new Regex(@"\d+\.\d+");
            MatchCollection mc = reg.Matches(source);
            string result = String.Empty;
            double time = 0;
            foreach (var x in mc)
            {
                result += "  " + x.ToString();
                time += Convert.ToDouble(x.ToString());
            }
            txtBase.Text = "3000";
            txtTy1.Value = (int)time;
            SetRichText("您的加班时长分别为" + result, defaultcolor);
            SetRichText("您的总加班时长为" + time.ToString(), defaultcolor);

        }
        private void SetRichText(string message, Color fontcolor)
        {
            int firstlength = rtxt.TextLength;
            rtxt.AppendText(message);
            rtxt.Select(firstlength, message.Length);
            rtxt.SelectionColor = fontcolor;
            rtxt.AppendText("\n");
            rtxt.ScrollToCaret();
        }

        private void btnparse_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            this.rtxt.Paste();
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            this.rtxt.Copy();
        }

        private void cutbtn_Click(object sender, EventArgs e)
        {
            this.rtxt.Cut();
        }

        private void rtxtmenu_Opening(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(rtxt.SelectedText))
            {
                btncopy.Enabled = false;
                cutbtn.Enabled = false;
            }
            else
            {
                btncopy.Enabled = true;
                cutbtn.Enabled = true;
            }
            IDataObject io = Clipboard.GetDataObject();
            if (!io.GetDataPresent(DataFormats.Text))
                btnparse.Enabled = false;
            else
                btnparse.Enabled = true;
        }

        private void showtextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtxt.SelectedText))
                MessageBox.Show(rtxt.SelectedText);
        }

        private void rtxtmenu_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
    class mysalary
    {
        public mysalary(double basesalary, double Ty1=0, double Ty2=0, double Ty3 = 0)
        {
            this.basesalary = basesalary;
            this.overtimeTy1 = Ty1;
            this.overtimeTy2 = Ty2;
            this.overtimeTy3 = Ty3;
        }
        public double basesalary;
        public double worktime = 21.75;
        public double overtimeTy1;
        public double overtimeTy2;
        public double overtimeTy3;
        public double salaryPHour()
        {
            return basesalary / worktime / 8;
        }
        public double salaryPMonth()
        {
            double h = salaryPHour();
            return h * overtimeTy1 * 1.5 + h * overtimeTy2 * 2 + h * overtimeTy3 * 3+basesalary;
        }
        public double MaxSalary()
        {
            double h = salaryPHour();
            return h * 40 * 1.5 + h * 40 * 2+basesalary;
        }
        public double OTsalary()
        {
            double h = salaryPHour();
            return h * overtimeTy1 * 1.5 + h * overtimeTy2 * 2 + h * overtimeTy3 * 3;       
        }
    }
    }
