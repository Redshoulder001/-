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
    public partial class AddBC : Form
    {
        public AddBC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        public DateTime Date
        {
            get { return DateTime.Parse(BCDate.Text); }
            set { BCDate.Text = value.ToString(); }
        }
        public double GLU
        {
            get { return double.Parse(Glu.Text); }
            set { Glu.Text = value.ToString(); }
        }
        public double Chol
        {
            get { return double.Parse(CHOL.Text); }
            set { CHOL.Text = value.ToString(); }
        }
        public double Alt
        {
            get { return double.Parse(ALT.Text); }
            set { ALT.Text = value.ToString(); }
        }
        public double Ast
        {
            get { return double.Parse(AST.Text); }
            set { AST.Text = value.ToString(); }
        }
        public double Creat
        {
            get { return double.Parse(CREAT.Text); }
            set { CREAT.Text = value.ToString(); }
        }
        public double Uri
        {
            get { return double.Parse(UREA.Text); }
            set { UREA.Text = value.ToString(); }
        }
        public double Bilirub
        {
            get { return double.Parse(BILIRUBIN.Text); }
            set { BILIRUBIN.Text = value.ToString(); }
        }
        public double Prot
        {
            get { return double.Parse(Proteine.Text); }
            set { Proteine.Text = value.ToString(); }
        }
        public double Crb
        {
            get { return double.Parse(CRB.Text); }
            set { CRB.Text = value.ToString(); }
        }
    }
}
