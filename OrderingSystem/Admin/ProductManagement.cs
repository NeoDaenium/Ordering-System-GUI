using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DatabaseController;
using OrderingSystem.Global;

namespace OrderingSystem.Admin
{
    public partial class ProductManagement : Form
    {
        ProductDatabaseController pdc = new ProductDatabaseController();
        BindingSource bs = new BindingSource();
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            loadDatabase();
            productCategoryComboBox.SelectedIndex = 0;
        }

        private Boolean checkInputs()
        {
            double testValue;
            int anotherTestValue;
            if (!double.TryParse(productPriceField.Text, out testValue))
            {
                return false;
            }
            else if (!int.TryParse(productStockField.Text, out anotherTestValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void loadDatabase()
        {
            //bs.DataSource = pdc.viewAllData("SP_VIEWALLPRODUCTDATA").Tables[0];
            productListGridView.DataSource = bs;
        }

        private void productListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.productListGridView.Rows[e.RowIndex];
                byte[] img = (byte[])row.Cells[1].Value;
                MemoryStream ms = new MemoryStream(img);
                productPictureBox.Image = Image.FromStream(ms);   
                productNameField.Text = row.Cells[2].Value.ToString();
                productPriceField.Text = row.Cells[3].Value.ToString();
                productStockField.Text = row.Cells[4].Value.ToString();
                productCategoryComboBox.Text = row.Cells[5].Value.ToString();   
            }
        }

        private void productPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
                dialog.Title = "Select Product Picture";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    productPictureBox.ImageLocation = dialog.FileName.ToString();
                }
            }
            catch (Exception openFileDialogException)
            {
                MessageBox.Show(openFileDialogException.Message);
            }
        }

        private void btnClick(object sender, EventArgs e)//Add button actions here! :D
        {
            Button btn = sender as Button;
            string sbtn = btn.Name;

            switch (sbtn)
            {
                case "btnEdit":
                cbxProductManager.Text = "Edit a Selected Product";

                break;
                case "btnAdd":
                cbxProductManager.Text = "Add a New Product";
                AddProduct goToAddProduct = new AddProduct();
                GlobalClass.CheckMdiChildren(goToAddProduct);
                loadDatabase();
                break;
                case "btnReset":
                resetAllFields();

                break;
                default:
                    //MessageBox.Show("The event is : " + e.GetType().ToString());
                    break;
            }
        }

        private void resetAllFields()
        {
            productCategoryComboBox.Text = "";
            productNameField.Text = "";
            productPriceField.Text = "";
            productStockField.Text = "0";
            //productPictureBox.Image = Image. Reset the image to default ?
        }
    }
}
