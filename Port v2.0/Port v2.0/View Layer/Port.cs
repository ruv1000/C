using System;
using System.Data;
using System.Windows.Forms;

namespace Port_v2._0
{
    public partial class Port : Form
    {
        public Port()
        {
            InitializeComponent();
        }

        private void Port_Load(object sender, EventArgs e)
        {
            // Скрываем таблицы
            dataGridViewResult.Visible = false;

            // Скрываем кнопку выполения запросов до выбора запроса
            buttonDone.Enabled = false;

            // Скрываем поля ввода груза для транзакции
            textBox1Load.Hide();
            textBoxFind.Hide();
            textBox1Find.Hide();
            textBox2Load.Enabled = false;
            textBox3Load.Enabled = false;
            textBox4Load.Enabled = false;
            textBox5Load.Enabled = false;
            comboBox1Load.Enabled = false;
            comboBox2Load.Enabled = false;

            // Скрываем поля ввода судна для транзакции
            comboBox1Ship.Enabled = false;
            comboBox2Ship.Visible = false;
            textBox1Ship.Enabled = false;
            textBox2Ship.Enabled = false;
            textBox3Ship.Enabled = false;
            monthCalendar1.Enabled = false;
            button1Transaction.Enabled = false;

            // Скрываем поля ввода для запросов
            comboBoxLoad.Enabled = false;
            comboBoxShip.Enabled = false;
            comboBoxTypeLoad.Enabled = false;
            comboBoxRecipient.Enabled = false;
        }

        // обработка события для просмотра таблицы
        private void SelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectTable.SelectedIndex >= 1)
            {
                dataGridViewResult.Visible = true;
                switch (SelectTable.SelectedIndex)
                {
                    case 1: dataGridViewResult.DataSource = Query.GetShip(); break;
                    case 2: dataGridViewResult.DataSource = Query.GetLoad(); break;
                    case 3: dataGridViewResult.DataSource = Query.GetHistory_Ship(); break;
                }
            }
            else
                dataGridViewResult.DataSource = null;
        }

        // обработка события радиобатона 1-го запроса
        private void radioButtonQuery1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLoad.Enabled = false;
            comboBoxShip.Enabled = true;
            comboBoxTypeLoad.Enabled = true;
            comboBoxRecipient.Enabled = false;
            buttonDone.Enabled = true;

            //очистка содержимого comboBox
            comboBoxLoad.Items.Clear();
            comboBoxShip.Items.Clear();
            comboBoxTypeLoad.Items.Clear();
            comboBoxRecipient.Items.Clear();

            // заполнение comboBoxShip данными
            DataTable Res = Query.GetNameShip();
            foreach (DataRow row in Res.Rows)
            {
                comboBoxShip.Items.Add(row.ItemArray[0].ToString());
            }

            // заполнение comboBoxTypeLoad данными
            DataTable Res2 = Query.GetTypeLoad();
            foreach (DataRow row in Res2.Rows)
            {
                comboBoxTypeLoad.Items.Add(row.ItemArray[0].ToString());
            }

            comboBoxShip.SelectedIndex = 5; // выбор 6-th значения из списка в comboBoxShip
            comboBoxTypeLoad.SelectedIndex = 1; // выбор 2-th значения из списка в comboBoxTypeLoad
        }

        // обработка события радиобатона 2-го запроса
        private void radioButtonQuery2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxTypeLoad.Enabled = true;
            comboBoxShip.Enabled = false;
            comboBoxLoad.Enabled = false;
            comboBoxRecipient.Enabled = false;
            buttonDone.Enabled = true;

            //очистка содержимого comboBox
            comboBoxLoad.Items.Clear();
            comboBoxShip.Items.Clear();
            comboBoxTypeLoad.Items.Clear();
            comboBoxRecipient.Items.Clear();

            // заполнение comboBoxTypeLoad данными
            DataTable Res = Query.GetTypeLoad();
            foreach (DataRow row in Res.Rows)
            {
                comboBoxTypeLoad.Items.Add(row.ItemArray[0].ToString());
            }

            comboBoxTypeLoad.SelectedIndex = 2; // выбор 3-th значения из списка в comboBoxTypeLoad
        }

        // обработка события радиобатона 3-го запроса
        private void radioButtonQuery3_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLoad.Enabled = false;
            comboBoxShip.Enabled = false;
            comboBoxTypeLoad.Enabled = false;
            comboBoxRecipient.Enabled = true;
            buttonDone.Enabled = true;

            //очистка содержимого comboBox
            comboBoxLoad.Items.Clear();
            comboBoxShip.Items.Clear();
            comboBoxTypeLoad.Items.Clear();
            comboBoxRecipient.Items.Clear();

            // заполнение comboBoxRecipient данными
            DataTable Res = Query.GetRecipient();
            foreach (DataRow row in Res.Rows)
            {
                comboBoxRecipient.Items.Add(row.ItemArray[0].ToString());
            }

            comboBoxRecipient.SelectedIndex = 12; // выбор 13-th значения из списка в comboBoxRecipient
        }

        // обработка события радиобатона 4-го запроса
        private void radioButtonQuery4_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLoad.Enabled = true;
            comboBoxShip.Enabled = false;
            comboBoxTypeLoad.Enabled = false;
            comboBoxRecipient.Enabled = false;
            buttonDone.Enabled = true;

            //очистка содержимого comboBox
            comboBoxLoad.Items.Clear();
            comboBoxShip.Items.Clear();
            comboBoxTypeLoad.Items.Clear();
            comboBoxRecipient.Items.Clear();

            // заполнение comboBoxTypeLoad данными
            DataTable Res = Query.GetInfoLoad();
            foreach (DataRow row in Res.Rows)
            {
                comboBoxLoad.Items.Add(row.ItemArray[0].ToString());
            }

            comboBoxLoad.SelectedIndex = 12; // выбор 13-th значения из списка в comboBoxTypeLoad
        }

        // обработка события радиобатона 5-го запроса
        private void radioButtonQuery5_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLoad.Enabled = false;
            comboBoxShip.Enabled = true;
            comboBoxTypeLoad.Enabled = false;
            comboBoxRecipient.Enabled = false;
            buttonDone.Enabled = true;

            //очистка содержимого comboBox
            comboBoxLoad.Items.Clear();
            comboBoxShip.Items.Clear();
            comboBoxTypeLoad.Items.Clear();
            comboBoxRecipient.Items.Clear();

            // заполнение comboBoxShip данными
            DataTable Res = Query.GetNameShip();
            foreach (DataRow row in Res.Rows)
            {
                comboBoxShip.Items.Add(row.ItemArray[0].ToString());
            }

            comboBoxShip.SelectedIndex = 5; // выбор 6-th значения из списка в comboBoxShip
        }

        // Обработка выбора в comboBoxLoad
        private void comboBoxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBoxShip
        private void comboBoxShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBoxTypeLoad
        private void comboBoxTypeLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBoxRecipient
        private void comboBoxRecipient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBox1T
        private void comboBox1T_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmploye = (string)comboBox2Ship.SelectedItem;
            if (selectedEmploye == null)
            {
                // заполнение comboBoxShip данными
                DataTable Res = Query.GetNameShip();
                foreach (DataRow row in Res.Rows)
                {
                    comboBox2Ship.Items.Add(row.ItemArray[0].ToString());
                }
            }

            string selectedEmployee = (string)comboBox.SelectedItem;
            if (selectedEmployee == "Прибытие") // Транзакция №1 
            {
                textBox2Load.Enabled = true;
                textBox3Load.Enabled = true;
                textBox4Load.Enabled = true;
                textBox5Load.Enabled = true;
                comboBox1Load.Enabled = true;
                comboBox2Load.Enabled = true;
                textBox1Ship.Visible = true;

                comboBox1Ship.Enabled = true;
                comboBox2Ship.Visible = false;
                textBox1Find.Visible = false;
                comboBox1Ship.Visible = true;
                textBox1Ship.Enabled = true;
                textBox2Ship.Enabled = true;
                textBox3Ship.Enabled = true;
                monthCalendar1.Enabled = true;
                comboBox2Ship.Visible = false;
                button1Transaction.Enabled = true;

                textBox2Load.Clear();
                textBox3Load.Clear();
                textBox4Load.Clear();
                textBox5Load.Clear();
                textBox1Ship.Clear();
                comboBox1Load.SelectedIndex = 0;
                comboBox2Load.SelectedIndex = 2;

                textBox1Ship.Clear();
                textBox2Ship.Clear();
                textBox3Ship.Clear();
                comboBox1Ship.SelectedIndex = 0;
                comboBox2Ship.SelectedIndex = 5; // выбор 6-th значения из списка в comboBoxShip
            }
            else // Транзакция №2
            {
                textBox2Load.Enabled = false;
                textBox3Load.Enabled = false;
                textBox4Load.Enabled = false;
                textBox5Load.Enabled = false;
                comboBox1Load.Enabled = false;
                comboBox2Load.Enabled = false;

                comboBox1Ship.Enabled = false;
                comboBox2Ship.Visible = true;
                textBox1Find.Visible = false;
                comboBox1Ship.Visible = true;
                textBox1Ship.Visible = false;
                textBox2Ship.Enabled = false;
                textBox3Ship.Enabled = false;
                monthCalendar1.Enabled = true;
                button1Transaction.Enabled = true;


                textBox2Load.Clear();
                textBox3Load.Clear();
                textBox4Load.Clear();
                textBox5Load.Clear();
                textBox1Ship.Clear();
                comboBox1Load.SelectedIndex = -1;
                comboBox2Load.SelectedIndex = -1;

                textBox1Ship.Clear();
                textBox2Ship.Clear();
                textBox3Ship.Clear();
                comboBox1Ship.SelectedIndex = -1;
                comboBox2Ship.SelectedIndex = 5;

            }
        }
        

        // Обработка выбора в comboBox
        private void comboBox1Load_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBox
        private void comboBox2Load_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBox
        private void comboBox1Ship_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox.SelectedItem;
        }

        // Обработка выбора в comboBox
        private void comboBox2Ship_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox.SelectedItem;
        }

        // Запретить ввод букв в textBox3Load
        private void textBox3Load_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        // Запретить ввод цифр в textBox4Load
        private void textBox4Load_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        // Запретить ввод цифр в textBox5Load
        private void textBox5Load_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        // Запретить ввод цифр в textBox1Ship
        private void textBox1Ship_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        // Запретить ввод цифр в textBox2Ship
        private void textBox2Ship_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        // Запретить ввод цифр в textBox3Ship
        private void textBox3Ship_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        // Запретить ввод цифр в textBox2Load
        private void textBox2Load_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        // Проверка на существование судна if true автоматическое заполнение полей
        private void comboBox1Ship_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1Find.Visible = true;
            comboBox1Ship.Visible = false;

            // заполнение textBoxFind данными
            DataTable Res = Query.GetExistNameShip(textBox1Ship.Text);
            foreach (DataRow row in Res.Rows)
            {
                textBoxFind.Text = (row.ItemArray[0].ToString());
            }

            // заполнение textBox1Find данными
            DataTable Res1 = Query.GetDISTINCTNameShip(textBoxFind.Text);
            foreach (DataRow row in Res1.Rows)
            {
                textBox1Find.Text = (row.ItemArray[0].ToString());
            }

            if (textBoxFind.Text == "")
            {
                textBox1Find.ReadOnly = false;
                textBox1Find.Clear();
            }
            textBoxFind.Clear();
        }

        // Проверка на существование судна if true автоматическое заполнение полей
        private void textBox1Find_MouseEnter(object sender, EventArgs e)
        {
            textBox1Find.Visible = true;
            comboBox1Ship.Visible = false;

            // заполнение textBoxFind данными
            DataTable Res = Query.GetExistNameShip(textBox1Ship.Text);
            foreach (DataRow row in Res.Rows)
            {
                textBoxFind.Text = (row.ItemArray[0].ToString());
            }

            // заполнение textBox1Find данными
            DataTable Res1 = Query.GetDISTINCTNameShip(textBoxFind.Text);
            foreach (DataRow row in Res1.Rows)
            {
                textBox1Find.Text = (row.ItemArray[0].ToString());
            }

            if (textBoxFind.Text == "")
            {
                textBox1Find.ReadOnly = false;
                textBox1Find.Clear();
                textBox1Find.Visible = false;
                comboBox1Ship.Visible = true;

            }
            else
            {
                textBox1Find.ReadOnly = true;
            }
            textBoxFind.Clear();
        }

        // обработка кнопки About
        private void AboutBox_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        // обработка собития кнопки Info
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info forma = new Info(); forma.ShowDialog();
        }

        // Очистка всех полей ввода
        private void button1Reset_Click(object sender, EventArgs e)
        {
            textBox2Load.Clear();
            textBox3Load.Clear();
            textBox4Load.Clear();
            textBox5Load.Clear();
            textBox1Ship.Clear();
            textBox1Ship.Clear();
            textBox2Ship.Clear();
            textBox3Ship.Clear();
            comboBox1Ship.SelectedIndex = -1;
            comboBox2Ship.SelectedIndex = -1;
            comboBox1T.SelectedIndex = -1;
            comboBox2Ship.SelectedIndex = -1;
            comboBox1Load.SelectedIndex = -1;
            comboBox2Load.SelectedIndex = -1;
            textBox1Load.Hide();
            textBoxFind.Hide();
            textBox1Find.Hide();
            monthCalendar1.Enabled = false;
            button1Transaction.Enabled = false;
            comboBox1Ship.Visible = true;
            dataGridViewResult.Visible = false;
            buttonDone.Enabled = false;
            textBox2Load.Enabled = false;
            textBox3Load.Enabled = false;
            textBox4Load.Enabled = false;
            textBox5Load.Enabled = false;
            comboBox1Load.Enabled = false;
            comboBox2Load.Enabled = false;
            comboBox1Ship.Enabled = false;
            comboBox2Ship.Enabled = false;
            textBox1Ship.Enabled = false;
            textBox2Ship.Enabled = false;
            textBox3Ship.Enabled = false;
            monthCalendar1.Enabled = false;
            button1Transaction.Enabled = false;
            comboBoxLoad.Enabled = false;
            comboBoxShip.Enabled = false;
            comboBoxTypeLoad.Enabled = false;
            comboBoxRecipient.Enabled = false;
            dataGridViewResult.DataSource = null;
        }

        // обработка события (выполнение запросов) кнопки Done
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Visible = true;
            if (radioButtonQuery1.Checked)
            {
                dataGridViewResult.DataSource = Query.GetDataTableQuery1(comboBoxTypeLoad.SelectedItem.ToString(), comboBoxShip.SelectedItem.ToString());
            }
            if (radioButtonQuery2.Checked)
            {
                dataGridViewResult.DataSource = Query.GetDataTableQuery2(comboBoxTypeLoad.SelectedItem.ToString());
            }
            if (radioButtonQuery3.Checked)
            {
                dataGridViewResult.DataSource = Query.GetDataTableQuery3(comboBoxRecipient.SelectedItem.ToString());
            }
            if (radioButtonQuery4.Checked)
            {
                dataGridViewResult.DataSource = Query.GetDataTableQuery4(comboBoxLoad.SelectedItem.ToString());
            }
            if (radioButtonQuery5.Checked)
            {
                dataGridViewResult.DataSource = Query.GetDataTableQuery5(comboBoxShip.SelectedItem.ToString());
            }
        }

        // обработка события (выполнение транзакций) кнопки Done
        private void button1Transaction_Click(object sender, EventArgs e)
        {
            if (comboBox1T.Text == "Прибытие") // Транзакция 1
            {
                try
                {
                    DataTable Res = Query.GetMaxID_Ship();
                    foreach (DataRow row in Res.Rows)
                    {
                        textBox1Load.Text = (row.ItemArray[0].ToString());
                    }
                    if (textBoxFind.Text == "")
                    {
                        textBox1Find.Visible = false;
                        comboBox1Ship.Visible = true;

                        string ID_Ship = textBox1Load.Text;
                        string Info_Load = textBox2Load.Text;
                        string Type_Load = comboBox1Load.Text;
                        string Amount_of_cargo = textBox3Load.Text;
                        string Units = comboBox2Load.Text;
                        string FIO_Recipient = textBox4Load.Text;
                        string Frome = textBox5Load.Text;

                        string Type_Ship = comboBox1Ship.Text;
                        string Capitan = textBox2Ship.Text;
                        string Country = textBox3Ship.Text;
                        string Name_Ship = textBox1Ship.Text;

                        string datePatt = @"yyyy-MM-dd";

                        monthCalendar1.MinDate = DateTime.Today;
                        datePatt = monthCalendar1.SelectionStart.ToString(datePatt);

                        if (textBox2Load.Text == "") throw new Exception("Заполните поле <Груз>");
                        if (textBox3Load.Text == "") throw new Exception("Заполните поле <Количество>");
                        if (textBox4Load.Text == "") throw new Exception("Заполните поле <Получатель>");
                        if (textBox5Load.Text == "") throw new Exception("Заполните поле <Страна отправления>");
                        if (comboBox1Load.Text == "") throw new Exception("Выберите поле <Тип груза>");
                        if (comboBox2Load.Text == "") throw new Exception("Выберите поле <Единицы измерения>");

                        if (textBox1Ship.Text == "") throw new Exception("Заполните поле <Название судна>");
                        if (textBox2Ship.Text == "") throw new Exception("Заполните поле <Капитан>");
                        if (textBox3Ship.Text == "") throw new Exception("Заполните поле <Страна>");
                        if (comboBox1Ship.Text == "") throw new Exception("Выберите поле <Тип судна>");

                        Query.T1_IN(ID_Ship, Info_Load, Type_Load, Amount_of_cargo, Units, FIO_Recipient, Frome, Type_Ship, Name_Ship, Capitan, Country, datePatt);
                        button1Transaction.Enabled = false;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else // Транзакция 2
            {
                try
                {
                    string datePatt = @"yyyy-MM-dd";
                    monthCalendar1.MinDate = DateTime.Today;
                    datePatt = monthCalendar1.SelectionStart.ToString(datePatt);
                    string Name_Ship = (string)comboBox2Ship.SelectedItem;
                    if (comboBox2Ship.Text == "") throw new Exception("Выберите поле <Название судна>");

                    Query.T2_IN(Name_Ship, datePatt);
                    button1Transaction.Enabled = false;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        
        private void Port_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}