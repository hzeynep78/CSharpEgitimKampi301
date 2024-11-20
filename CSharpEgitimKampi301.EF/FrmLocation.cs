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
    public partial class FrmLocation : Form
    {

        EgitimKampiEfDBEntities db = new EgitimKampiEfDBEntities();
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TBL_LOCATION.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TBL_GUIDE.Select(x => new
            {
                x.Id, // ValueMember için gerekli
                FullName = x.Id + ". " + x.Name + " " + x.Surname
            }).ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = values;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBL_LOCATION location = new TBL_LOCATION();
            location.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = (int)comboBox1.SelectedValue;
            db.TBL_LOCATION.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location added successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var location = db.TBL_LOCATION.Find(id);
            db.TBL_LOCATION.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Location deleted successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var location = db.TBL_LOCATION.Find(id);
            location.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = (int)comboBox1.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Location updated successfully.");
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var location = db.TBL_LOCATION.Where(x => x.Id == id).ToList();
            dataGridView1.DataSource=location;
        }
    }
}
