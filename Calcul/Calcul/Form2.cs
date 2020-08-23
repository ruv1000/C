using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Справка : Form
    {
        public Справка()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Данное приложение реализует работу обыкновенного калькулятора \n  ФУНКЦИОНАЛЬНЫЕ КЛАВИШИ:\n '+' - операция сложения; \n '-' - операция вычитания; \n '*' - операция умножения; \n '/' - операция деления;\n РАБОТА С ПАМЯТЬЮ: \n 'MS' - занесения в память; \n 'MR' - вывод значения, хранящегося в памяти; \n 'MC' - очистка памяти; \n 'M+' - сложение данного числа, со значение, хранящимся в памяти; \n";
            //richTextBox1.Text = "Данное приложение может быть использовано для мониторинга файловой системы.Список на экране уведомляет о создании,удалении, изменении или перейменовании файла/директории\n КАК ЭТО РАБОТАЕТ?\n1).Введите в TextReader имя файла/путь к каталогу.Или нажмите кнопку <Обзор> и выберите необходимый объект для отслеживания;\n" +
            //  "2).Нажмите кнопку <Начать наблюдение>;\n3).Если вы хотите прервать отслеживание, нажмите кнопку <Прекратить наблюдение>;" +
            //  "\n4).Ниже на экране появится иформация о последних изменеиях файла/каталога;\n5).Если вы хотите сохранить информацию об изменениях нажмите кнопку<Запись>.";
        }

        private void Form2_HelpButtonClicked(object sender, CancelEventArgs e)
        {
        }

        private void bok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
