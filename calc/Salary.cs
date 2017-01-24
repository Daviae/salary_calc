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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            this.Msglist.Items.Clear();
            double ot1=0,ot2=0,basesalary =0;
            try
            {
                if (Convert.ToDouble(txtTy1.Value) > 0)
                    ot1 = Convert.ToDouble(txtTy1.Text);
                if (Convert.ToDouble(txtTy2.Value) > 0)
                    ot2 = Convert.ToDouble(txtTy2.Text);
                basesalary = Convert.ToDouble(txtBase.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("您輸入有誤，請重新輸入", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mysalary s=new mysalary(basesalary,ot1,ot2);
            double x = Math.Round(s.MaxSalary(), 2);
            Msglist.Items.Add("您的時薪為:" + Math.Round(s.salaryPHour(),2));
            Msglist.Items.Add("最高薪資:"+x);
            Msglist.Items.Add("實際薪資:");
            Msglist.Items.Add(Math.Round(s.salaryPMonth(), 2));
            Msglist.Items.Add("總加班時長(單位小時):");
            Msglist.Items.Add(ot1+ot2);
            Msglist.Items.Add("一類加班(單位小時):"+ot1);
            Msglist.Items.Add("二類加班(單位小時):" + ot2);
            Msglist.Items.Add("您的加班工資為" + Math.Round(s.OTsalary(), 2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Msglist.Items.Clear();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            一键导入ToolStripMenuItem.Font=tools.Font = Submit.Font = new Font(fontawesome, 10);
            groupBox1.Font = new Font(fontawesome, 10);
            lbllogo.Font = new Font(fontawesome,30);
            lbllogo.Text = "\uF109"+"     "+"\uF0D6";
            Submit.Text += "\uF157";
            groupBox1.Text += "\uf186";
            tools.Text = "\uf0ad" + tools.Text;
            一键导入ToolStripMenuItem.Text = "\uf0d0" + 一键导入ToolStripMenuItem.Text;
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
            Regex reg = new Regex(@"\d\.\d");
            MatchCollection mc = reg.Matches(source);
            string result = String.Empty;
            double time = 0;
            foreach (var x in mc)
            {
                result += "  " + x.ToString();
                time += Convert.ToDouble(x.ToString());
            }
            txtBase.Text ="2430";
            txtTy1.Value =(int)time;
            Msglist.Items.Add("您的加班时长分别为" + result);
            Msglist.Items.Add("您的总加班时长为" + time.ToString());
            
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
        public double worktime = 21.5;
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
