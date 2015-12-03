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
using System.Runtime.Serialization.Formatters.Binary;

namespace Лабораторная_работа__13
{    
    public partial class Form1 : Form
    {
        public List<Transport> transports = new List<Transport>();
        public List<Driver> drivers = new List<Driver>();
        public List<Company> companies = new List<Company>();

        public Form1()
        {
            InitializeComponent();
            rbShowTransports.Checked = true;
        }

        private void rbShowPatients_CheckedChanged(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            cbAttach.Items.Clear();
            lbHeader.Text = "";
            listView.Items.Clear();
            listView.Columns.Clear();
        }

        private void rbShowDoctors_CheckedChanged(object sender, EventArgs e)
        {
            rbShowPatients_CheckedChanged(sender, e);
        }

        private void rbCompany_CheckedChanged(object sender, EventArgs e)
        {
            rbShowPatients_CheckedChanged(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e) // Вызов окна добавления пациента/доктора
        {
            AddPatient add = new AddPatient();
            add.Owner = this;
            add.ShowDialog();
        }

        private void comboBox_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();            
            if (rbShowTransports.Checked && transports.Count > 0)
            {
                for (int i = 0; i < transports.Count; i++) // Вывод в comboBox списка транспорта
                    comboBox.Items.Add(transports[i].Number + " (" + transports[i].Route.ToString() + ", " + transports[i].Model + ")"); 
            }
            else if (rbShowDrivers.Checked && drivers.Count > 0)
            {
                for (int i = 0; i < drivers.Count; i++) // Вывод в comboBox списка водителей
                {
                    if (drivers[i].Machine == null)
                        comboBox.Items.Add(drivers[i].Fio + " (" + drivers[i].Category + ")");
                    else
                        comboBox.Items.Add(drivers[i].Fio + " (" + drivers[i].Category + ", " + drivers[i].Machine.Number + ")");
                }
            }
            else if (rbShowCompanies.Checked && companies.Count > 0) // Вывод в comboBox списка компаний
            {
                for (int i = 0; i < companies.Count; i++)
                    comboBox.Items.Add(companies[i].Name);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox.SelectedIndex;
            if (comboBox.SelectedItem != null) // Если выбран какой-либо элемент в comboBox
            {
                listView.Items.Clear();     // Полная очистка listView
                listView.Columns.Clear();
                cbAttach.Items.Clear();
                if (rbShowTransports.Checked)
                {
                    #region Заполнение таблицы сведениями о транспорте (информация + вычисление компании-владельца)

                    lbHeader.Text = "Сведения о транспортном средстве " + transports[index].Number;
                    listView.Columns.Add("Маршрут.", 60);
                    listView.Columns.Add("Водитель", 100);
                    listView.Columns.Add("Модель", 50);
                    listView.Columns.Add("Компания", 60);

                    ListViewItem lvi = new ListViewItem(transports[index].Route.ToString());
                    if (transports[index].Driver != null)
                        lvi.SubItems.Add(transports[index].Driver.Fio);
                    else
                        lvi.SubItems.Add("-");
                    lvi.SubItems.Add(transports[index].Model);
                    string companyName = null;
                    foreach (Company c in companies)
                    {
                        if (c.whoIsOwner(transports[index]) != null)
                        {
                            companyName = c.whoIsOwner(transports[index]);
                            break;
                        }
                    }

                    if (companyName != null)
                        lvi.SubItems.Add(companyName);
                    else
                        lvi.SubItems.Add("-");

                    listView.Items.Add(lvi);
                    #endregion

                    #region Добавление в cbAttach списка водителей
                    for (int i = 0; i < drivers.Count; i++)
                    {
                        if (drivers[i].Machine == null)
                            cbAttach.Items.Add(drivers[i].Fio + " (" + drivers[i].Category + ")");
                        else
                            cbAttach.Items.Add(drivers[i].Fio + " (" + drivers[i].Category + ", " + drivers[i].Machine.Number + ")");
                    };
                    #endregion
                }
                else if (rbShowDrivers.Checked)
                {
                    #region Заполнение таблицы сведениями о водителе (информация + вычисление компании-работодателя)
                    lbHeader.Text = "Сведения о водителе " + drivers[index].Fio;
                    listView.Columns.Add("Категория", 100);
                    listView.Columns.Add("№ Транспорта", 80);
                    listView.Columns.Add("Компания", 100);

                    ListViewItem lvi = new ListViewItem(drivers[index].Category);

                    if (drivers[index].Machine != null)
                        lvi.SubItems.Add(drivers[index].Machine.Number.ToString());
                    else
                        lvi.SubItems.Add("-");

                    string companyName = null;
                    foreach (Company c in companies)
                    {
                        if (c.whoIsOwner(drivers[index]) != null)
                        {
                            companyName = c.whoIsOwner(drivers[index]);
                            break;
                        }
                    }

                    if (companyName != null)
                        lvi.SubItems.Add(companyName);
                    else
                        lvi.SubItems.Add("-");

                    listView.Items.Add(lvi);

                    //Transport.FillListView(ref listView, ref doctors[index].patients, index);
                    #endregion

                    #region Добавление в cbAttach списка транспорта
                    for (int i = 0; i < transports.Count; i++) 
                        cbAttach.Items.Add(transports[i].Number + " (" + transports[i].Route.ToString() + ", " + transports[i].Model + ")");
                    #endregion
                }
                else if (rbShowCompanies.Checked)
                {
                    #region Заполнение таблицы списками водителей и транспорта
                    lbHeader.Text = "Сведения о компании " + companies[index].Name;
                    listView.Columns.Add("Элементы", 150);

                    if (companies[index].Autopark.Count > 0)
                    {
                        ListViewItem l = new ListViewItem("Транспорт:");                 
                        foreach (Transport t in companies[index].Autopark)
                        {
                            ListViewItem lvi = new ListViewItem(t.Number + " (" + t.Route.ToString() + ", " + t.Model + ")");                            
                            listView.Items.Add(lvi);
                        }
                    }

                    if (companies[index].Staff.Count > 0)
                    {
                        ListViewItem l = new ListViewItem("Водители:");
                        foreach (Driver d in companies[index].Staff)
                        {
                            ListViewItem lvi = new ListViewItem(d.Fio + " (" + d.Category + ")");
                            listView.Items.Add(lvi);
                        }
                    }
                    #endregion

                    #region Добавление в cbAttach списков транспорта и водителей
                    for (int i = 0; i < transports.Count; i++)
                        cbAttach.Items.Add(transports[i].Number + " (" + transports[i].Route.ToString() + ", " + transports[i].Model + ")");
                    for (int i = 0; i < drivers.Count; i++)
                    {
                        if (drivers[i].Machine == null)
                            cbAttach.Items.Add(drivers[i].Fio + " (" + drivers[i].Category + ")");
                        else
                            cbAttach.Items.Add(drivers[i].Fio + " (" + drivers[i].Category + ", " + drivers[i].Machine.Number + ")");
                    };
                    #endregion
                }
            }
        }       

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (comboBox.Items.Count > 0 && cbAttach.Items.Count > 0)
            {
                if (cbAttach.SelectedItem != null && comboBox.SelectedItem != null)
                {
                    if (rbShowTransports.Checked)
                    {                       
                        if (transports[comboBox.SelectedIndex] == drivers[cbAttach.SelectedIndex].Machine)
                            MessageBox.Show("Этот водитель уже закреплен за выбранным транспортом");
                        else
                        {
                            if (transports[comboBox.SelectedIndex].Driver != null) // Если к данному транспорту уже прикреплен водитель,
                                transports[comboBox.SelectedIndex].Driver.Machine = null; // то его нужно снять с этой машины

                            if (drivers[cbAttach.SelectedIndex].Machine != null) // Если к водителю, к которому нужно прикрепить транспорт, уже приписан другой транспорт,
                                drivers[cbAttach.SelectedIndex].Machine.Driver = null; // то необходимо освободить эту связь

                            bool same = false;
                            foreach (Company c in companies)
                            {
                                if (c.whoIsOwner(transports[comboBox.SelectedIndex]) == c.whoIsOwner(drivers[cbAttach.SelectedIndex]) && (c.whoIsOwner(transports[comboBox.SelectedIndex]) != null || c.whoIsOwner(drivers[cbAttach.SelectedIndex]) != null))
                                {
                                    transports[comboBox.SelectedIndex].Driver = drivers[cbAttach.SelectedIndex];
                                    drivers[cbAttach.SelectedIndex].Machine = transports[comboBox.SelectedIndex];

                                    ListViewItem lvi = new ListViewItem(transports[comboBox.SelectedIndex].Route.ToString());
                                    lvi.SubItems.Add(transports[comboBox.SelectedIndex].Driver.Fio);
                                    lvi.SubItems.Add(transports[comboBox.SelectedIndex].Model);
                                    string companyName = null;
                                    foreach (Company com in companies)
                                    {
                                        if (c.whoIsOwner(transports[comboBox.SelectedIndex]) != null)
                                        {
                                            companyName = c.whoIsOwner(transports[comboBox.SelectedIndex]);
                                            break;
                                        }
                                    }

                                    if (companyName != null)
                                        lvi.SubItems.Add(companyName);
                                    else
                                        lvi.SubItems.Add("-");

                                    listView.Items.Add(lvi);
                                    same = true;
                                    break;
                                }
                            }
                            if (!same)
                                MessageBox.Show("Невозможно добавить. Элементы принадлежат разным компаниям, либо не принадлежат вовсе. Убедитесь, что все элементы являются собственностью одной компании.");                           
                        }
                    }
                    else if (rbShowDrivers.Checked)
                    {
                        if (drivers[comboBox.SelectedIndex] == transports[cbAttach.SelectedIndex].Driver)
                            MessageBox.Show("Этот транспорт уже закреплен за выбранным водителем");
                        else
                        {
                            if (drivers[comboBox.SelectedIndex].Machine != null)
                                drivers[comboBox.SelectedIndex].Machine.Driver = null;

                            if (transports[cbAttach.SelectedIndex].Driver != null)
                                transports[cbAttach.SelectedIndex].Driver.Machine = null;

                            bool same = false;
                            foreach (Company c in companies)
                            {
                                if (c.whoIsOwner(drivers[comboBox.SelectedIndex]) == c.whoIsOwner(transports[cbAttach.SelectedIndex]) && (c.whoIsOwner(drivers[comboBox.SelectedIndex]) != null || c.whoIsOwner(transports[cbAttach.SelectedIndex]) != null))
                                {
                                    drivers[comboBox.SelectedIndex].Machine = transports[cbAttach.SelectedIndex];
                                    transports[cbAttach.SelectedIndex].Driver = drivers[comboBox.SelectedIndex];

                                    ListViewItem lvi = new ListViewItem(drivers[comboBox.SelectedIndex].Category);
                                    lvi.SubItems.Add(drivers[comboBox.SelectedIndex].Machine.Number.ToString());

                                    string companyName = null;
                                    foreach (Company com in companies)
                                    {
                                        if (c.whoIsOwner(drivers[comboBox.SelectedIndex]) != null)
                                        {
                                            companyName = c.whoIsOwner(drivers[comboBox.SelectedIndex]);
                                            break;
                                        }
                                    }

                                    if (companyName != null)
                                        lvi.SubItems.Add(companyName);
                                    else
                                        lvi.SubItems.Add("-");

                                    listView.Items.Add(lvi);
                                    same = true;
                                    break;
                                }
                            }
                            if (!same)
                                MessageBox.Show("Невозможно добавить. Элементы принадлежат разным компаниям, либо не принадлежат вовсе. Убедитесь, что все элементы являются собственностью одной компании.");

                        }
                    }
                    else if (rbShowCompanies.Checked)
                    {
                        if (cbAttach.SelectedIndex < transports.Count) // Значит выбран транспорт
                        {
                            if (companies[comboBox.SelectedIndex].whoIsOwner(transports[cbAttach.SelectedIndex]) != null)
                                MessageBox.Show("Этот объект уже закреплен за выбранной компанией");
                            else
                            {
                                foreach (Company c in companies)
                                {
                                    if (c.whoIsOwner(transports[cbAttach.SelectedIndex]) != null)
                                    {                                       
                                        c.Autopark.Remove(transports[cbAttach.SelectedIndex]);
                                    }
                                }

                                if (transports[cbAttach.SelectedIndex].Driver != null) // Разрыв машины с водителем
                                {
                                    transports[cbAttach.SelectedIndex].Driver.Machine = null;
                                    transports[cbAttach.SelectedIndex].Driver = null;
                                }
                                companies[comboBox.SelectedIndex].Autopark.Add(transports[cbAttach.SelectedIndex]);

                                ListViewItem lvi = new ListViewItem(transports[cbAttach.SelectedIndex].Number + " (" + transports[cbAttach.SelectedIndex].Route.ToString() + ", " + transports[cbAttach.SelectedIndex].Model + ")");
                                
                                listView.Items.Add(lvi);
                            }
                        }
                        else // Значит выбран водитель
                        {
                            if (companies[comboBox.SelectedIndex].whoIsOwner(drivers[cbAttach.SelectedIndex - transports.Count]) != null)
                                MessageBox.Show("Этот объект уже закреплен за выбранной компанией");
                            else
                            {
                                foreach (Company c in companies)
                                {
                                    if (c.whoIsOwner(drivers[cbAttach.SelectedIndex - transports.Count]) != null)
                                    {                                        
                                        c.Staff.Remove(drivers[cbAttach.SelectedIndex - transports.Count]);
                                    }
                                }

                                if (drivers[cbAttach.SelectedIndex - transports.Count].Machine != null) // Разрыв водителя с машиной
                                {
                                    drivers[cbAttach.SelectedIndex - transports.Count].Machine.Driver = null; 
                                    drivers[cbAttach.SelectedIndex - transports.Count].Machine = null;
                                }
                                companies[comboBox.SelectedIndex].Staff.Add(drivers[cbAttach.SelectedIndex - transports.Count]);                                

                                ListViewItem lvi = new ListViewItem(drivers[cbAttach.SelectedIndex - transports.Count].Fio + " (" + drivers[cbAttach.SelectedIndex - transports.Count].Category + ")");
                            
                                listView.Items.Add(lvi);
                            }
                        }

                    }                                     
                }
                else
                    MessageBox.Show("Выберите элемент из списка для прикрепления");
            }
            else
                MessageBox.Show("Список пуст. Прежде чем прикреплять, убедитесь, что имеется достаточно данных.");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.InitialDirectory = Application.StartupPath;
            svf.Filter = "Файл базы данных больницы (*.hdb)|*.hdb";

            if (svf.ShowDialog() == DialogResult.OK)
            {
                if (svf.FileName != "")
                {
                    try
                    {
                        using (Stream st = File.OpenWrite(svf.FileName))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(st, transports);
                            bin.Serialize(st, drivers);
                            bin.Serialize(st, companies);
                            st.Dispose();
                            MessageBox.Show("Файл успешно сохранен");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            svf.Dispose();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Файл базы данных больницы (*.hdb)|*.hdb";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    try
                    {
                        using (Stream st = File.OpenRead(ofd.FileName))
                        {
                            transports.Clear();
                            drivers.Clear();
                            companies.Clear();
                            BinaryFormatter bin = new BinaryFormatter();
                            transports = (List<Transport>)bin.Deserialize(st);
                            drivers = (List<Driver>)bin.Deserialize(st);
                            companies = (List<Company>)bin.Deserialize(st);
                            st.Dispose();
                            MessageBox.Show("Файл успешно загружен");
                            comboBox.Items.Clear();
                            cbAttach.Items.Clear();
                            lbHeader.Text = "";
                            listView.Items.Clear();
                            listView.Columns.Clear();
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            ofd.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                if (rbShowTransports.Checked)
                    transports.RemoveAt(comboBox.SelectedIndex);
                else if (rbShowDrivers.Checked)
                    drivers.RemoveAt(comboBox.SelectedIndex);
                else if (rbShowCompanies.Checked)
                    companies.RemoveAt(comboBox.SelectedIndex);

                comboBox.Items.RemoveAt(comboBox.SelectedIndex);
                cbAttach.Items.Clear();
                listView.Items.Clear();
                lbHeader.Text = "";
            }
            else
                MessageBox.Show("Выберите элемент для удаления");
        }

        private void удалитьЭлементыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (rbShowTransports.Checked)
            //{
            //    if (listView.SelectedItems.Count != 0)
            //    {
            //        foreach (ListViewItem lvi in listView.SelectedItems) // Удаление всех выбранных в таблице элементов
            //        {
            //            patients[comboBox.SelectedIndex].doctors.RemoveAt(lvi.Index); // Из списка
            //            lvi.Remove();                                                 // Из таблицы
            //        }
            //    }
            //}
            //else if (rbShowDrivers.Checked)
            //{
            //    if (listView.SelectedItems.Count != 0)
            //    {
            //        foreach (ListViewItem lvi in listView.SelectedItems) // Удаление всех выбранных в таблице элементов
            //        {
            //            doctors[comboBox.SelectedIndex].patients.RemoveAt(lvi.Index); // Из списка
            //            lvi.Remove();                                                 // Из таблицы
            //        }
            //    }
            //}
        }

    }
}