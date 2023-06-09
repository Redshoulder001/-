using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1._0
{
    public partial class BCForm : Form
    {
        public BCForm()
        {
            InitializeComponent();
        }
        public void LoadBc()
        {
            var sql = " SELECT BioChim.ID, PatientID, Date, Glu, CHOL, ALT, AST, CREAT, UREA, BILIRUBIN, Proteine, CRB from BioChim INNER JOIN Patient ON BioChim.PatientID = Patient.ID where Patient.ID = @id;";
            using (var cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", GetID.ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                da.Fill(data);
                BcGreedView.DataSource = data.Tables[0];
                this.BcGreedView.Columns["ID"].Visible = false;
                this.BcGreedView.Columns["PatientID"].Visible = false;
            }
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MedicBase;Integrated Security=True;";
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var frm = new AddBC();
            frm.GLU = 0;
            frm.Chol = 0;
            frm.Alt = 0;
            frm.Ast = 0;
            frm.Creat = 0;
            frm.Uri = 0;
            frm.Bilirub = 0;
            frm.Prot = 0;
            frm.Crb = 0;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // var id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                    var sql = "INSERT INTO BioChim VALUES (@PatientID, @Date, @Glu, @CHOL, @ALT, @AST, @CREAT, @UREA, @BILIRUBIN, @Proteine, @CRB);";
                    using (var cn = new SqlConnection(connectionString))
                    {
                        cn.Open();

                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@PatientID", GetID.ID);
                        cmd.Parameters.AddWithValue("@Date", frm.Date);
                        cmd.Parameters.AddWithValue("@Glu", frm.GLU);
                        cmd.Parameters.AddWithValue("@CHOL", frm.Chol);
                        cmd.Parameters.AddWithValue("@ALT", frm.Alt);
                        cmd.Parameters.AddWithValue("@AST", frm.Ast);
                        cmd.Parameters.AddWithValue("@CREAT", frm.Creat);
                        cmd.Parameters.AddWithValue("@UREA", frm.Uri);
                        cmd.Parameters.AddWithValue("@BILIRUBIN", frm.Bilirub);
                        cmd.Parameters.AddWithValue("@Proteine", frm.Prot);
                        cmd.Parameters.AddWithValue("@CRB", frm.Crb);
                        cmd.ExecuteNonQuery();
                    }
                    LoadBc();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }   }

        private void ChngBtn_Click(object sender, EventArgs e)
        {
            var frm = new AddBC();
            if (BcGreedView.SelectedRows.Count == 0)
                return;
            var id = BcGreedView.SelectedRows[0].Cells["ID"].Value.ToString();
            frm.Date = (DateTime)BcGreedView.SelectedRows[0].Cells["Date"].Value;
            frm.GLU = (double)BcGreedView.SelectedRows[0].Cells["Glu"].Value;
            frm.Chol = (double)BcGreedView.SelectedRows[0].Cells["CHOL"].Value;
            frm.Alt = (double)BcGreedView.SelectedRows[0].Cells["ALT"].Value;
            frm.Ast = (double)BcGreedView.SelectedRows[0].Cells["AST"].Value;
            frm.Creat = (double)BcGreedView.SelectedRows[0].Cells["CREAT"].Value;
            frm.Uri = (double)BcGreedView.SelectedRows[0].Cells["UREA"].Value;
            frm.Bilirub = (double)BcGreedView.SelectedRows[0].Cells["BILIRUBIN"].Value;
            frm.Prot = (double)BcGreedView.SelectedRows[0].Cells["Proteine"].Value;
            frm.Crb = (double)BcGreedView.SelectedRows[0].Cells["CRB"].Value;
            if (frm.ShowDialog(this) == DialogResult.OK) ;
            try
            {
                var sql = "UPDATE BioChim Set Date = @Date, Glu=@Glu, CHOL =@CHOL, ALT=@ALT, AST = @AST, CREAT = @CREAT, UREA = @UREA, BILIRUBIN = @BILIRUBIN, Proteine = @Proteine, CRB = @CRB Where ID = @id;";
                using (var cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id",id );
                    cmd.Parameters.AddWithValue("@Date", frm.Date);
                    cmd.Parameters.AddWithValue("@Glu", frm.GLU);
                    cmd.Parameters.AddWithValue("@CHOL", frm.Chol);
                    cmd.Parameters.AddWithValue("@ALT", frm.Alt);
                    cmd.Parameters.AddWithValue("@AST", frm.Ast);
                    cmd.Parameters.AddWithValue("@CREAT", frm.Creat);
                    cmd.Parameters.AddWithValue("@UREA", frm.Uri);
                    cmd.Parameters.AddWithValue("@BILIRUBIN", frm.Bilirub);
                    cmd.Parameters.AddWithValue("@Proteine", frm.Prot);
                    cmd.Parameters.AddWithValue("@CRB", frm.Crb);
                    cmd.ExecuteNonQuery();
                    LoadBc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (BcGreedView.SelectedRows.Count == 0)
                return;
            try
            {
                var id = BcGreedView.SelectedRows[0].Cells["ID"].Value.ToString();
                var sql = "DELETE from BioChim where ID=@id";
                using (var cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    var cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                LoadBc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            Close();
            GetID.ID = null;
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
