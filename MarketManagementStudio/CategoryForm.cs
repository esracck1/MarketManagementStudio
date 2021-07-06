using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MarketManagementStudio
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MarketManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
            private void btn_add_Click(object sender, EventArgs e)
            {
            
            try
            {
                sqlConnection.Open();
                string query = "insert into Categories(id,name,description) values('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_description.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added category succesfully!");
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
                string query = "select * from Categories";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                var ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                gridviewcategories.DataSource = ds.Tables[0];
                sqlConnection.Close();
            }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gridviewcategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = gridviewcategories.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = gridviewcategories.SelectedRows[0].Cells[1].Value.ToString();
            txt_name.Text = gridviewcategories.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text=="")
                {
                    MessageBox.Show("Select the category to delete.");
                }
                else
                {
                    sqlConnection.Open();
                    string query = "delete from categories where Id='" + txt_id.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully. ");
                    populate();
                    sqlConnection.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }

        private void gridviewcategories_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = gridviewcategories.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = gridviewcategories.SelectedRows[0].Cells[1].Value.ToString();
            txt_description.Text = gridviewcategories.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text=="" ||txt_name.Text==""||txt_id.Text=="")
                {
                    MessageBox.Show("Information missing!");
                }
                sqlConnection.Open();
                string query = "update  categories set name=@name,description=@description,Id=@ıd";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ıd", txt_id.Text);
                sqlCommand.Parameters.AddWithValue("@name", txt_name.Text);
                sqlCommand.Parameters.AddWithValue("@description", txt_description.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Editing successfully.");
                sqlConnection.Close();
                populate();                    
                    }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void btn_selling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            this.Hide();
            sellingForm.Show();
        }
    }
}
