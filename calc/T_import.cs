using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;
namespace calc
{
    public partial class T_import : Form
    {
        public FontFamily fontawesome;
        public T_import()
        {
            InitializeComponent();
            PrivateFontCollection pf = new PrivateFontCollection();
            pf.AddFontFile("myfont.ttf");
            fontawesome = pf.Families[0];
        }
        Regex reg = new Regex(@"\d+\.\d+");
        private void button1_Click(object sender, EventArgs e)
        {
            MatchCollection mc=reg.Matches(this.richTextBox1.Text);
            string result=String.Empty;
            double time=0;
            foreach (var x in mc)
            {
                result += "  "+x.ToString();
                time +=Convert.ToDouble(x.ToString());
            }
            Msglist.Items.Add("您的加班时长分别为" +result);
            Msglist.Items.Add("您的总加班时长为"+time.ToString());
        }

        private void T_import_Load(object sender, EventArgs e)
        {
            this.btok.Text = "\uf00c" + this.btok.Text;
            this.btcopy.Text = "\uf0c5";
            this.btcls.ForeColor = Color.OrangeRed;
            this.btcopy.ForeColor = Color.Green;
            this.btcls.Text = "\uf021";
            goldkey.Text = "\uf084";
            goldkey.Font=btok.Font=this.btcopy.Font=this.btcls.Font = new Font(fontawesome,12);
        }

        private void btcopy_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
                this.richTextBox1.Text = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void btcls_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text=String.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string source=String.Empty;
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
               source = (String)iData.GetData(DataFormats.Text);
            }
            MatchCollection mc = reg.Matches(source);
            string result = String.Empty;
            double time = 0;
            foreach (var x in mc)
            {
                result += "  " + x.ToString();
                time += Convert.ToDouble(x.ToString());
            }
            Msglist.Items.Add("您的加班时长分别为" + result);
            Msglist.Items.Add("您的总加班时长为" + time.ToString());
        }
    }
}
