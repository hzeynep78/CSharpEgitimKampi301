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
    public partial class FrmCategory : Form
    {

        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(txtID.Text);
            var updateValue =_categoryService.TGetById(updateID);
            updateValue.CategoryName = txtName.Text;
            updateValue.CategoryStatus = true;
            _categoryService.TUpdate(updateValue);
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var DeleteValue = _categoryService.TGetById(id);
            _categoryService.TDelete(DeleteValue);
            MessageBox.Show("Silme Başarılı");
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtID.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { values };
        }
    }
}
