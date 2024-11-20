using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EF
{
    public partial class Form1 : Form
    {
        EgitimKampiEfDBEntities db = new EgitimKampiEfDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TBL_GUIDE.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBL_GUIDE guide = new TBL_GUIDE();
            guide.Name = txtName.Text;
            guide.Surname = txtSurname.Text;
            db.TBL_GUIDE.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide added successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var removeValue = db.TBL_GUIDE.Find(id);
            db.TBL_GUIDE.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Guide deleted successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var updateValue = db.TBL_GUIDE.Find(id);
            updateValue.Name = txtName.Text;
            updateValue.Surname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide updated successfully.");
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var values = db.TBL_GUIDE.Where(x => x.Id == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
