using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private readonly Joint _joint1 = new Joint(12, "J12-5213-12B", "Samsung", new Detail(213, "detail1"));
        private readonly Joint _joint2 = new Joint(5, "J5-6793-89F", "Philips", new Detail(192, "detail2"));
        private readonly Mechanism _mechanism1 = new Mechanism(30, "M30-3984-93K", "Nissan", new Detail(721, "detail3"));
        private readonly Mechanism _mechanism2 = new Mechanism(50, "M50-9623-21T", "SpaceX", new Detail(912, "detail4"));

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMechanism_Click(object sender, EventArgs e)
        {
            _mechanism2.AddDetail(new Detail(793, "detail5"));
            _mechanism2.AddDetail(new Detail(832, "detail6"));
            _mechanism1.AddDetail(new Detail(120, "detail7"));
            Product.AddProduct(_joint1);
            Product.AddProduct(_mechanism1);
            Product.AddProduct(_joint2);
            Product.AddProduct(_mechanism2);

            for(var i = 0; i < Product.ProductsCount; ++i)
            {
                comboBox1.Items.Add(Product.GetProduct(i).SerialNumber);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = comboBox1.SelectedIndex;
            lbWeight.Text = Product.GetProduct(i).Info(i, textBox1.Text);
        }
    }
}