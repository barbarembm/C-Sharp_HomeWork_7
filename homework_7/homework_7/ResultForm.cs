using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_7
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Productebis sruli sia

            var products = (from p in DBSimulator.GetProducts()
                            join c in DBSimulator.GetProductCategories()
                            on p.Categoty_ID equals c.Id
                            orderby p.Code ascending
                            select new
                            {
                                Category = c.Name,
                                Name = p.Name,
                                Code = p.Code,
                                Measure = p.Measuring,
                                Amount = p.Price * p.Quantity,
                                Valute = p.Valute,
                                ExpirationDate = p.Expiration,
                            }).ToList();
            dataGridView1.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var product = (from p in DBSimulator.GetProducts()
                           where p.Price>300
                           orderby p.Expiration descending
                            select new
                            {
                                Name = p.Name,
                                Code = p.Code,
                                Price=p.Price,
                                ExceptionDate=p.Expiration
                            }).ToList();
            dataGridView1.DataSource = product;
        }
    }
}
