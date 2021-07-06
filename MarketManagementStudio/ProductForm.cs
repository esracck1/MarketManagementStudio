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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MarketManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string query = "insert into Products(Id,Name,quantity) Values('"+txt_ıd.Text+ "','"+txt_name.Text+ "','"+txt_quantıty.Text+"')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added seller succesfully!");
                sqlConnection.Close();
                populate();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
   private void populate()
    {
        sqlConnection.Open();
        string query = "select * from Products";
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
        var ds = new DataSet();
        sqlDataAdapter.Fill(ds);
        gridviewproduct.DataSource = ds.Tables[0];
        sqlConnection.Close();
    }
        private void fillcombo()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select Name from Categories",sqlConnection);
            SqlDataReader rdr;
            rdr = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Load(rdr);
            cbx_select.ValueMember = "Name";
            cbx_select.DataSource = dataTable;
            sqlConnection.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void gridviewproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = gridviewproduct.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = gridviewproduct.SelectedRows[0].Cells[1].Value.ToString();
            txt_quantıty.Text = gridviewproduct.SelectedRows[0].Cells[2].Value.ToString();
            
           

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ıd.Text=="")
                {
                    MessageBox.Show("Select the product to delete.");
                }
                else
                {
                    sqlConnection.Open();
                    string query = "delete from products where Id='" + txt_ıd.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully.");
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
                if (txt_ıd.Text==""||txt_name.Text==""||txt_quantıty.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    sqlConnection.Open();
                    string query = "update Products set Id=@ıd,Name=@name,Quantity=@quantity";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ıd", txt_ıd.Text);
                    sqlCommand.Parameters.AddWithValue("@name", txt_name.Text);
                    sqlCommand.Parameters.AddWithValue("@quantity", txt_quantıty.Text);
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

        private void btn_seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

      
    }

 

}
