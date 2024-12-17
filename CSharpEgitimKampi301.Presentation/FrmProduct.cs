using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.Presentation
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtPrice.Text);
            product.ProductName = txtName.Text;
            product.ProductDescription = txtDescription.Text;
            product.ProductStock = int.Parse(txtStock.Text);
            _productService.TInsert(product);
            MessageBox.Show("Ekleme İşlemi Başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(txtID.Text);
            var updateValue = _productService.TGetById(updateID);
            updateValue.ProductName = txtName.Text;
            updateValue.ProductDescription = txtDescription.Text;
            updateValue.ProductPrice = decimal.Parse(txtPrice.Text);
            updateValue.ProductStock = int.Parse(txtStock.Text);
            updateValue.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
            _productService.TUpdate(updateValue);
            MessageBox.Show("Güncelleme İşlemi Başarılı!");
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = _productService.TGetById(id);
            dataGridView1.DataSource = new List<Product> { value };
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            comboBox1.DataSource = values;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
        }
    }
}
