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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string NameAdd
        {
            get { return NameText.Text;}
            set { NameText.Text = value; }
        }
        public string Surname
        {
            get { return SurnameText.Text; }
            set { SurnameText.Text = value; }
        }
        public string Patronymic
        {
            get { return PatronymicText.Text; }
            set { PatronymicText.Text = value; }
        }
        public DateTime Berthdate
        {
            get { return DateTime.Parse(BerthDateText.Text); }
            set { BerthDateText.Text = value.ToString(); }
        }
        public string Gender
        {
            get { return GenderText.Text; }
            set { GenderText.Text = value; }
        }
        public double High
        {
            get { return double.Parse(HighText.Text); }
            set { HighText.Text = value.ToString(); }
        }
        public double Weight
        {
            get { return double.Parse( weightText.Text); }
            set { weightText.Text = value.ToString(); }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("Необходимо заполнить поле 'Имя'");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
