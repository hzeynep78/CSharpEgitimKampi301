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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfDBEntities db = new EgitimKampiEfDBEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.TBL_LOCATION.Count().ToString();

            //Toplam Kapasite
            lblSumCapacity.Text = db.TBL_LOCATION.Sum(x => x.Capacity).ToString();

            //Toplam Rehber Sayısı
            lblGuideCount.Text = db.TBL_GUIDE.Count().ToString();

            //Ortalama Kapasite
            lblAvgCapacity.Text = db.TBL_LOCATION.Average(x => x.Capacity).ToString();

            //Ortalama Tur Fiyatı
            lblAvgPrice.Text = db.TBL_LOCATION.Average(x => x.Price)?.ToString("0.00");

            //Eklenen Son Ülke
            var lastCountry = db.TBL_LOCATION.Max(x => x.Id);
            lblLastCountry.Text = db.TBL_LOCATION.Find(lastCountry).Country;

            //Belirtilen Tura Göre Kapasite
            var tour = db.TBL_LOCATION.Where(x => x.City == "Seul").FirstOrDefault();
            lblCapacityforTour.Text = tour.Capacity.ToString();

            //Ülkeye göre Ortalama Kapasite
            lblCapacityforCountry.Text = db.TBL_LOCATION.Where(x => x.Country == "Türkiye").Average(x => x.Capacity).ToString();

            //Şehir turuna göre tur rehberi
            var tour2= db.TBL_LOCATION.Where(x => x.City == "London").FirstOrDefault();
            lblGuideforTour.Text = tour2.TBL_GUIDE.Name+ " " + tour2.TBL_GUIDE.Surname;

            //En Fazla Kapasiteli Tur
            lblMaxCapacity.Text = db.TBL_LOCATION.OrderByDescending(x => x.Capacity).FirstOrDefault().City;

            //En Pahalı Tur
            lblMaxPrice.Text = db.TBL_LOCATION.OrderByDescending(x => x.Price).FirstOrDefault().City;

            //Rehberin tur sayısı
            var guide = db.TBL_GUIDE.Where(x => x.Name == "Hilal").FirstOrDefault();
            lblCountforGuide.Text = guide.TBL_LOCATION.Count().ToString();
        }
    }
}
