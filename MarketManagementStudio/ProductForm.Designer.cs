
namespace MarketManagementStudio
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_product = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cbxcategory = new System.Windows.Forms.ComboBox();
            this.gridviewproduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbx_select = new System.Windows.Forms.ComboBox();
            this.txt_quantıty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ıd = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_quantıty = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ıd = new System.Windows.Forms.Label();
            this.lbl_manage = new System.Windows.Forms.Label();
            this.btn_seller = new System.Windows.Forms.Button();
            this.btn_selling = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_product
            // 
            this.pnl_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_product.Controls.Add(this.btn_refresh);
            this.pnl_product.Controls.Add(this.cbxcategory);
            this.pnl_product.Controls.Add(this.gridviewproduct);
            this.pnl_product.Controls.Add(this.btn_delete);
            this.pnl_product.Controls.Add(this.btn_edit);
            this.pnl_product.Controls.Add(this.btn_add);
            this.pnl_product.Controls.Add(this.cbx_select);
            this.pnl_product.Controls.Add(this.txt_quantıty);
            this.pnl_product.Controls.Add(this.txt_name);
            this.pnl_product.Controls.Add(this.guna2TextBox2);
            this.pnl_product.Controls.Add(this.txt_ıd);
            this.pnl_product.Controls.Add(this.lbl_category);
            this.pnl_product.Controls.Add(this.lbl_quantıty);
            this.pnl_product.Controls.Add(this.lbl_name);
            this.pnl_product.Controls.Add(this.lbl_ıd);
            this.pnl_product.Controls.Add(this.lbl_manage);
            this.pnl_product.Location = new System.Drawing.Point(216, 22);
            this.pnl_product.Name = "pnl_product";
            this.pnl_product.Size = new System.Drawing.Size(896, 608);
            this.pnl_product.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.Location = new System.Drawing.Point(725, 142);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(85, 29);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // cbxcategory
            // 
            this.cbxcategory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbxcategory.FormattingEnabled = true;
            this.cbxcategory.Location = new System.Drawing.Point(485, 150);
            this.cbxcategory.Name = "cbxcategory";
            this.cbxcategory.Size = new System.Drawing.Size(199, 21);
            this.cbxcategory.TabIndex = 15;
            this.cbxcategory.Text = "Select Category";
            // 
            // gridviewproduct
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridviewproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewproduct.BackgroundColor = System.Drawing.Color.White;
            this.gridviewproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridviewproduct.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewproduct.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridviewproduct.EnableHeadersVisualStyles = false;
            this.gridviewproduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewproduct.Location = new System.Drawing.Point(485, 177);
            this.gridviewproduct.Name = "gridviewproduct";
            this.gridviewproduct.RowHeadersVisible = false;
            this.gridviewproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewproduct.Size = new System.Drawing.Size(374, 414);
            this.gridviewproduct.TabIndex = 14;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewproduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewproduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewproduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewproduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewproduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewproduct.ThemeStyle.HeaderStyle.Height = 4;
            this.gridviewproduct.ThemeStyle.ReadOnly = false;
            this.gridviewproduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewproduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewproduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewproduct.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewproduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewproduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewproduct_CellContentClick);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(196, 422);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 39);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.Location = new System.Drawing.Point(338, 422);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(92, 39);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_add.Location = new System.Drawing.Point(53, 422);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 39);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbx_select
            // 
            this.cbx_select.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbx_select.FormattingEnabled = true;
            this.cbx_select.Location = new System.Drawing.Point(230, 363);
            this.cbx_select.Name = "cbx_select";
            this.cbx_select.Size = new System.Drawing.Size(200, 21);
            this.cbx_select.TabIndex = 10;
            this.cbx_select.Text = "Select Category";
       
            // 
            // txt_quantıty
            // 
            this.txt_quantıty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantıty.DefaultText = "";
            this.txt_quantıty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantıty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantıty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantıty.DisabledState.Parent = this.txt_quantıty;
            this.txt_quantıty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantıty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantıty.FocusedState.Parent = this.txt_quantıty;
            this.txt_quantıty.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_quantıty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantıty.HoverState.Parent = this.txt_quantıty;
            this.txt_quantıty.Location = new System.Drawing.Point(230, 301);
            this.txt_quantıty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_quantıty.Name = "txt_quantıty";
            this.txt_quantıty.PasswordChar = '\0';
            this.txt_quantıty.PlaceholderText = "";
            this.txt_quantıty.SelectedText = "";
            this.txt_quantıty.ShadowDecoration.Parent = this.txt_quantıty;
            this.txt_quantıty.Size = new System.Drawing.Size(200, 36);
            this.txt_quantıty.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.Parent = this.txt_name;
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.FocusedState.Parent = this.txt_name;
            this.txt_name.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.HoverState.Parent = this.txt_name;
            this.txt_name.Location = new System.Drawing.Point(230, 239);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.ShadowDecoration.Parent = this.txt_name;
            this.txt_name.Size = new System.Drawing.Size(200, 36);
            this.txt_name.TabIndex = 7;
            this.txt_name.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(907, 365);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox2.TabIndex = 6;
            // 
            // txt_ıd
            // 
            this.txt_ıd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ıd.DefaultText = "";
            this.txt_ıd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ıd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ıd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ıd.DisabledState.Parent = this.txt_ıd;
            this.txt_ıd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ıd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ıd.FocusedState.Parent = this.txt_ıd;
            this.txt_ıd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_ıd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ıd.HoverState.Parent = this.txt_ıd;
            this.txt_ıd.Location = new System.Drawing.Point(230, 177);
            this.txt_ıd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.PasswordChar = '\0';
            this.txt_ıd.PlaceholderText = "";
            this.txt_ıd.SelectedText = "";
            this.txt_ıd.ShadowDecoration.Parent = this.txt_ıd;
            this.txt_ıd.Size = new System.Drawing.Size(200, 36);
            this.txt_ıd.TabIndex = 5;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_category.Location = new System.Drawing.Point(49, 364);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(84, 20);
            this.lbl_category.TabIndex = 4;
            this.lbl_category.Text = "CATEGORY";
            // 
            // lbl_quantıty
            // 
            this.lbl_quantıty.AutoSize = true;
            this.lbl_quantıty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_quantıty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_quantıty.Location = new System.Drawing.Point(49, 307);
            this.lbl_quantıty.Name = "lbl_quantıty";
            this.lbl_quantıty.Size = new System.Drawing.Size(82, 20);
            this.lbl_quantıty.TabIndex = 3;
            this.lbl_quantıty.Text = "QUANTITY";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(49, 250);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 20);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "NAME";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.AutoSize = true;
            this.lbl_ıd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ıd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ıd.Location = new System.Drawing.Point(49, 193);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(24, 20);
            this.lbl_ıd.TabIndex = 1;
            this.lbl_ıd.Text = "ID";
            // 
            // lbl_manage
            // 
            this.lbl_manage.AutoSize = true;
            this.lbl_manage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_manage.Location = new System.Drawing.Point(328, 11);
            this.lbl_manage.Name = "lbl_manage";
            this.lbl_manage.Size = new System.Drawing.Size(215, 30);
            this.lbl_manage.TabIndex = 0;
            this.lbl_manage.Text = "MANAGE PRODUCTS";
            // 
            // btn_seller
            // 
            this.btn_seller.BackColor = System.Drawing.SystemColors.Control;
            this.btn_seller.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_seller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_seller.Location = new System.Drawing.Point(41, 78);
            this.btn_seller.Name = "btn_seller";
            this.btn_seller.Size = new System.Drawing.Size(140, 31);
            this.btn_seller.TabIndex = 1;
            this.btn_seller.Text = "Seller";
            this.btn_seller.UseVisualStyleBackColor = false;
            this.btn_seller.Click += new System.EventHandler(this.btn_seller_Click);
            // 
            // btn_selling
            // 
            this.btn_selling.BackColor = System.Drawing.SystemColors.Control;
            this.btn_selling.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_selling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_selling.Location = new System.Drawing.Point(41, 205);
            this.btn_selling.Name = "btn_selling";
            this.btn_selling.Size = new System.Drawing.Size(140, 31);
            this.btn_selling.TabIndex = 2;
            this.btn_selling.Text = "Selling";
            this.btn_selling.UseVisualStyleBackColor = false;
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.SystemColors.Control;
            this.btn_category.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_category.Location = new System.Drawing.Point(41, 140);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(140, 31);
            this.btn_category.TabIndex = 3;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.btn_selling);
            this.Controls.Add(this.btn_seller);
            this.Controls.Add(this.pnl_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.pnl_product.ResumeLayout(false);
            this.pnl_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_product;
        private System.Windows.Forms.Label lbl_manage;
        private System.Windows.Forms.Button btn_seller;
        private System.Windows.Forms.Button btn_selling;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_quantıty;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ıd;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox txt_ıd;
        private System.Windows.Forms.ComboBox cbx_select;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantıty;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cbxcategory;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewproduct;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
    }
}