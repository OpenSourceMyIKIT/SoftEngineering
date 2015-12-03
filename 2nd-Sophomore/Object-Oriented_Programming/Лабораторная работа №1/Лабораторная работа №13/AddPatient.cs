using System;
using System.Windows.Forms;

namespace Лабораторная_работа__13
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }       

        private void btnEndAdd_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;
            if (rbTransport.Checked)
            {
                if (tbTNumber.Text != "" && tbTRoute.Text != "" && tbTModel.Text != "")
                {
                    try
                    {
                        Transport currTransport = new Transport(tbTNumber.Text, Convert.ToInt32(tbTRoute.Text), tbTModel.Text);                        
                        mainForm.transports.Add(currTransport); // Добавления нового транспортного средства в основной список
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Все поля обязательны для заполнения");
            }
            else if (rbDriver.Checked)
            {
                if (tbDFio.Text != "" && tbDCategory.Text != "")
                {
                    try
                    {
                        Driver currDriver = new Driver(tbDFio.Text, tbDCategory.Text);                        
                        mainForm.drivers.Add(currDriver); // Добавления нового водителя в основной список
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Все поля обязательны для заполнения");
            }
            else if (rbCompany.Checked)
            {
                if (tbCName.Text != "")
                {
                    try
                    {
                        Company currCompany = new Company(tbCName.Text);
                        mainForm.companies.Add(currCompany);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Все поля обязательны для заполнения");
            }
            else
                MessageBox.Show("Выберите режим добавления");
        }

        private void cbAddDoctorPatient_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
