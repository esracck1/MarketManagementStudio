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

namespace MarketManagementStudio
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MarketManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string query = "insert into Sellers(Id,Name,Age,Phone,Password) Values('" + txt_ıd.Text+ "','" + txt_name.Text + "','" + txt_age.Text + "','" + txt_phone.Text + "','" + txt_password.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added seller succesfully!");
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            sqlConnection.Open();
            string query = "select * from Sellers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            gridviewseller.DataSource = ds.Tables[0];
            sqlConnection.Close();
        }

     
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gridviewseller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = gridviewseller.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = gridviewseller.SelectedRows[0].Cells[1].Value.ToString();
            txt_age.Text = gridviewseller.SelectedRows[0].Cells[2].Value.ToString();
            txt_phone.Text = gridviewseller.SelectedRows[0].Cells[3].Value.ToString();
            txt_password.Text = gridviewseller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ıd.Text=="")
                {
                    MessageBox.Show("Select the category to deleted. ");
                }
                else
                {
                    sqlConnection.Open();
                    string query = "delete from sellers where id='" + txt_ıd.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted successfully. ");
                    sqlConnection.Close();
                    populate();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ıd.Text==""||txt_age.Text==""||txt_name.Text==""||txt_password.Text==""||txt_phone.Text=="")
                {
                    MessageBox.Show("Missing information!");
                }
                else
                {
                    sqlConnection.Open();
                    string query = "update Sellers set Id=@Id,Name=@Name,Age=@Age,Phone=@Phone,Password=@Password";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", txt_ıd.Text);
                    sqlCommand.Parameters.AddWithValue("@Name", txt_name.Text);
                    sqlCommand.Parameters.AddWithValue("@Age", txt_age.Text);
                    sqlCommand.Parameters.AddWithValue("@Phone", txt_phone.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", txt_password.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Editing successfully.");
                    sqlConnection.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ıd.Text=="")
                {
                    MessageBox.Show("Please enter CustomerId");
                }
                else
                {
                    if (true)
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("select Id from Sellers", sqlConnection);
                    
                        sqlConnection.Close();

                    }
                    
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
