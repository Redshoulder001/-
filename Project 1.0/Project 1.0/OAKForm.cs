using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1._0
{
    public partial class OAKForm : Form
    {
        public OAKForm()
        {
            InitializeComponent();
            
        }

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MedicBase;Integrated Security=True;";


        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            var frm = new OAKaddForm();
            frm.RBC = 0;
            frm.PLT = 0;
            frm.Hb = 0;
            frm.WBC = 0;
            frm.Ht = 0;
            frm.Lymph = 0;
            frm.ESR = 0;
            frm.Gran = 0;

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // var id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                    var sql = "INSERT INTO OAK VALUES (@PatientID, @Date, @RBC, @Hb, @PLT, @Ht, @WBC, @Lymph, @Gran, @ESR);";
                    using (var cn = new SqlConnection(connectionString))
                    {
                        cn.Open();

                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@PatientID", GetID.ID);
                        cmd.Parameters.AddWithValue("@Date", frm.Date);
                        cmd.Parameters.AddWithValue("@RBC", frm.RBC);
                        cmd.Parameters.AddWithValue("@Hb", frm.Hb);
                        cmd.Parameters.AddWithValue("@PLT", frm.PLT);
                        cmd.Parameters.AddWithValue("@Ht", frm.Ht);
                        cmd.Parameters.AddWithValue("@WBC", frm.WBC);
                        cmd.Parameters.AddWithValue("@Lymph", frm.Lymph);
                        cmd.Parameters.AddWithValue("@Gran", frm.Gran);
                        cmd.Parameters.AddWithValue("@ESR", frm.ESR);
                        cmd.ExecuteNonQuery();
                    }
                    LoadOAK();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            GetID.ID = null;
        }
        public void LoadOAK()
        {
            var sql = " SELECT OAK.ID, PatientID, Date, RBC, Hb, PLT, Ht, WBC, Lymph, Gran, ESR from OAK INNER JOIN Patient ON OAK.PatientID = Patient.ID where Patient.ID = @id;";
            using (var cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", GetID.ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                da.Fill(data);
                OAKGreedview.DataSource = data.Tables[0];
                this.OAKGreedview.Columns["ID"].Visible = false;
                this.OAKGreedview.Columns["PatientID"].Visible = false;
            }
           
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            var frm = new OAKaddForm();
            if (OAKGreedview.SelectedRows.Count == 0)
                return;
            var id = OAKGreedview.SelectedRows[0].Cells["ID"].Value.ToString();
            frm.Date = (DateTime)OAKGreedview.SelectedRows[0].Cells["Date"].Value;
            frm.RBC = (double)OAKGreedview.SelectedRows[0].Cells["RBC"].Value;
            frm.Hb = (double)OAKGreedview.SelectedRows[0].Cells["Hb"].Value;
            frm.PLT = (double)OAKGreedview.SelectedRows[0].Cells["PLT"].Value;
            frm.Ht = (double)OAKGreedview.SelectedRows[0].Cells["Ht"].Value;
            frm.WBC = (double)OAKGreedview.SelectedRows[0].Cells["WBC"].Value;
            frm.Lymph = (double)OAKGreedview.SelectedRows[0].Cells["Lymph"].Value;
            frm.Gran = (double)OAKGreedview.SelectedRows[0].Cells["Gran"].Value;
            frm.ESR = (double)OAKGreedview.SelectedRows[0].Cells["ESR"].Value;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    var sql = "UPDATE OAK SET Date = @Date, RBC = @RBC, Hb = @Hb, PLT = @PLT, Ht = @Ht, WBC = @WBC, Lymph = @Lymph, Gran = @Gran, ESR=@ESR Where ID = @id;";
                    using (var cn = new SqlConnection(connectionString))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Date", frm.Date);
                        cmd.Parameters.AddWithValue("@RBC", frm.RBC);
                        cmd.Parameters.AddWithValue("@Hb", frm.Hb);
                        cmd.Parameters.AddWithValue("@PLT", frm.PLT);
                        cmd.Parameters.AddWithValue("@Ht", frm.Ht);
                        cmd.Parameters.AddWithValue("@WBC", frm.WBC);
                        cmd.Parameters.AddWithValue("@Lymph", frm.Lymph);
                        cmd.Parameters.AddWithValue("@Gran", frm.Gran);
                        cmd.Parameters.AddWithValue("@ESR", frm.ESR);
                        cmd.ExecuteNonQuery();
                        LoadOAK();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (OAKGreedview.SelectedRows.Count == 0)
                return;
            try
            {
                var id = OAKGreedview.SelectedRows[0].Cells["ID"].Value.ToString();
                var sql = "DELETE from OAK where ID=@id";
                using (var cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    var cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                LoadOAK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string NameBoxText
        {
            get { return NameBox.Text; }
            set { NameBox.Text = value; }
        }
        public string SurnameBoxText
        {
            get { return SurnameBox.Text; }
            set { SurnameBox.Text = value; }
        }
        public string PatronimicBoxText
        {
            get { return PatronimicBox.Text; }
            set { PatronimicBox.Text = value; }
        }
        public DateTime Berthdate
        {
            get { return DateTime.Parse(BerthdateBox.Text); }
            set { BerthdateBox.Text = value.ToString(); }
        }
    }
 }
