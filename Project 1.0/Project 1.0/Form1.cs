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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MedicBase;Integrated Security=True;";

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        public void LoadData()
        {
            using (var cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string sql = "SELECT ID, Name, Surname, Patronymic, Berthdate, High, Weight, Gender FROM Patient;";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["ID"].Visible = false;
            }
        }


        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AddForm();
            frm.High = 0;
            frm.Weight = 0;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    var sql = "INSERT INTO Patient VALUES (@Name, @Surname, @Patronymic, @Berthdate, @High, @Weight, @Gender);";
                    using (var cn = new SqlConnection(connectionString))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@Name", frm.NameAdd);
                        cmd.Parameters.AddWithValue("@Surname", frm.Surname);
                        cmd.Parameters.AddWithValue("@Patronymic", frm.Patronymic);
                        cmd.Parameters.AddWithValue("@Berthdate", frm.Berthdate);
                        cmd.Parameters.AddWithValue("@High", frm.High);
                        cmd.Parameters.AddWithValue("@Weight", frm.Weight);
                        cmd.Parameters.AddWithValue("@Gender", frm.Gender);
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            try
            {
                var id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                var sql = "DELETE from Patient where ID=@id";
                using (var cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    var cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AddForm();
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            var id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            frm.NameAdd = (string)dataGridView1.SelectedRows[0].Cells["Name"].Value;
            frm.Surname = (string)dataGridView1.SelectedRows[0].Cells["Surname"].Value;
            frm.Patronymic = (string)dataGridView1.SelectedRows[0].Cells["Patronymic"].Value;
            frm.Berthdate = (DateTime)dataGridView1.SelectedRows[0].Cells["Berthdate"].Value;
            frm.High = (double)dataGridView1.SelectedRows[0].Cells["High"].Value;
            frm.Weight = (double)dataGridView1.SelectedRows[0].Cells["Weight"].Value;
            frm.Gender = (string)dataGridView1.SelectedRows[0].Cells["Gender"].Value;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    var sql = @"UPDATE Patient SET Name= @Name, Surname=@Surname, Patronymic=@Patronymic, Berthdate=@Berthdate, High=@High, Weight=@Weight, Gender=@Gender WHERE ID=@id;";
                    using (var cn = new SqlConnection(connectionString))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Name", frm.NameAdd);
                        cmd.Parameters.AddWithValue("@Surname", frm.Surname);
                        cmd.Parameters.AddWithValue("@Patronymic", frm.Patronymic);
                        cmd.Parameters.AddWithValue("@Berthdate", frm.Berthdate);
                        cmd.Parameters.AddWithValue("@High", frm.High);
                        cmd.Parameters.AddWithValue("@Weight", frm.Weight);
                        cmd.Parameters.AddWithValue("@Gender", frm.Gender);
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void оАКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new OAKForm();
                GetID.ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                frm.NameBoxText = (string)dataGridView1.SelectedRows[0].Cells["Name"].Value;
                frm.SurnameBoxText = (string)dataGridView1.SelectedRows[0].Cells["Surname"].Value;
                frm.PatronimicBoxText = (string)dataGridView1.SelectedRows[0].Cells["Patronymic"].Value;
                frm.Berthdate = (DateTime)dataGridView1.SelectedRows[0].Cells["Berthdate"].Value;
                //var id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                frm.LoadOAK();

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void биохимияКровиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new BCForm();
                GetID.ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                frm.NameBoxText = (string)dataGridView1.SelectedRows[0].Cells["Name"].Value;
                frm.SurnameBoxText = (string)dataGridView1.SelectedRows[0].Cells["Surname"].Value;
                frm.PatronimicBoxText = (string)dataGridView1.SelectedRows[0].Cells["Patronymic"].Value;
                frm.Berthdate = (DateTime)dataGridView1.SelectedRows[0].Cells["Berthdate"].Value;
                //var id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                frm.LoadBc();

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void загрузитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("Ошибка закгрузки БД");
            }

        }
    }
    
}

            
        
    

