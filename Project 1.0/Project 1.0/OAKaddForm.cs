using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1._0
{
    public partial class OAKaddForm : Form
    {
        public OAKaddForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CnclBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public DateTime Date
        {
            get { return DateTime.Parse(OAKDate.Text); }
            set { OAKDate.Text = value.ToString(); }
        }
        public double RBC
        {
            get { return double.Parse(RBCText.Text); }
            set { RBCText.Text = value.ToString(); }
        }public double Hb
        {
            get { return double.Parse(HbText.Text); }
            set { HbText.Text = value.ToString(); }
        }
        
        public double PLT
        {
            get { return double.Parse(PltText.Text); }
            set { PltText.Text = value.ToString(); }
        }

        public double Ht
        {
            get { return double.Parse(HtText.Text); }
            set { HtText.Text = value.ToString(); }
        }

        public double WBC
        {
            get { return double.Parse(WBCtext.Text); }
            set { WBCtext.Text = value.ToString(); }
        }
        public double Lymph
        {
            get { return double.Parse(LymphText.Text); }
            set { LymphText.Text = value.ToString(); }
        }
        public double Gran
        {
            get { return double.Parse(GranText.Text); }
            set { GranText.Text = value.ToString(); }
        }
        public double ESR
        {
            get { return double.Parse(ESRText.Text); }
            set { ESRText.Text = value.ToString(); }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
