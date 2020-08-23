using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Calcul
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitCalculator();
            this.KeyPreview = true;
            справкаToolStripMenuItem1.ShortcutKeys = Keys.F1;
        }
        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
        //    if (e.KeyCode == Keys.F1)
        //    {
        //        MessageBox.Show("Тест");
        //        e.Handled = true;
        //    }
        //}

        //Очистить поле ввода/вывода (кнопка CE) 
        private void Clear()
        {
            _digits.Clear();
            _negative = false;
            provdisplayNumber();
        }
        //Поменять знак значения значения в поле ввода/вывода (кнопка btnPlusMinus)
        private void ChangeSign()
        {
            _negative = !_negative;
            provdisplayNumber();
        }
        // Удалить последний введенный символ (кнопка  BackSpace)
        private void RemoveLastDigit()
        {
            if (_digits.Count > 0)
            {
                _digits.Pop();
            }
            provdisplayNumber();
        }
             // перечесление для выбора винарных операций	
        public enum Operations
        {
            Add, Sub, Mul, Div, Sqrt, Proc, Div_na_x
        }
        //какая операция
        private Operations _currentOperation;

        //переменные для операндов (вычислений)
        private double X;
        private double Y;
        private double Z;//mamory
        // стек для ввода цифр в поле ввода/вывода
        private Stack _digits; 
        

        //переменная равна TRUE, если введено отрицательное число (нажата кнопка btnPlusMinus)
        private bool _negative;
        private void InitCalculator()
                 { //операнды положительны
            _negative = false;
            //стек цифр операнда инициализирован 
            _digits = new Stack();
            
            //в поле ввода/вывода - ноль
         textBox1.Text = "0";
            //выбрана десятичная система счисления
          //  cmbSystem.SelectedIndex = 1;
        }
        private void bequally_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip2.Show("   =   ", this.bequally);
        }

        private void bsub_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("   -   ", this.bsub);
        }

        private void badd_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip3.Show("   +   ", this.badd);
        }

        private void bznak_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip4.Show("   +/-   ", this.bznak);
        }

        private void bdiv_x_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip5.Show("   1/x   ", this.bdiv_x);
        }

        private void bproc_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip6.Show("   %   ", this.bproc);
        }

        private void bsqrt_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip7.Show("   sqrt   ", this.bsqrt);
        }

        private void bpoint_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip8.Show("   .   ", this.bpoint);
        }

        private void bmul_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip9.Show("   *   ", this.bmul);
        }

        private void bdiv_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip10.Show("   /   ", this.bdiv);
        }

        private void bMC_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip11.Show("   MC   ", this.bMC);
        }

        private void bMR_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip12.Show("   MR    ", this.bMR);
        }

        private void bMS_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip13.Show("   MS   ", this.bMS);
        }

        private void bM_add_1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip14.Show("   M+   ", this.bMAdd);
        }

        private void bBackSpace_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip15.Show("BackSpace", this.bBackSpace);
        }

        private void bce_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip16.Show("   CE    ", this.bce);
        }

        private void bc_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip17.Show("   C   ", this.bc);

        }

        private void bMC_MouseLeave(object sender, EventArgs e)
        {
            toolTip11.Hide(this.bMC);
        }

        private void bMR_MouseLeave(object sender, EventArgs e)
        {
            toolTip12.Hide(this.bMR);
        }

        private void bMS_MouseLeave(object sender, EventArgs e)
        {
            toolTip13.Hide(this.bMS);
        }

        private void bM_add_1_MouseLeave(object sender, EventArgs e)
        {
            toolTip14.Hide(this.bMAdd);
        }

        private void bBackSpace_MouseLeave(object sender, EventArgs e)
        {
            toolTip15.Hide(this.bBackSpace);
        }

        private void bce_MouseLeave(object sender, EventArgs e)
        {
            toolTip16.Hide(this.bce);
        }

        private void bc_MouseLeave(object sender, EventArgs e)
        {
            toolTip17.Hide(this.bc);
        }

        private void bsub_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this.bsub);
        }

        private void bequally_MouseLeave(object sender, EventArgs e)
        {
            toolTip2.Hide(this.bequally);
         }

        private void badd_MouseLeave(object sender, EventArgs e)
        {
            toolTip3.Hide(this.badd);
        }

        private void bznak_MouseLeave(object sender, EventArgs e)
        {
            toolTip4.Hide(this.bznak);
        }

        private void bdiv_x_MouseLeave(object sender, EventArgs e)
        {
            toolTip5.Hide(this.bdiv_x);
        }

        private void bproc_MouseLeave(object sender, EventArgs e)
        {
            toolTip6.Hide(this.bproc);
        }

        private void bsqrt_MouseLeave(object sender, EventArgs e)
        {
            toolTip7.Hide(this.bsqrt);
        }

        private void bpoint_MouseLeave(object sender, EventArgs e)
        {
            toolTip8.Hide(this.bpoint);
        }

        private void bmul_MouseLeave(object sender, EventArgs e)
        {
            toolTip9.Hide(this.bmul);
        }

        private void bdiv_MouseLeave(object sender, EventArgs e)
        {
            toolTip10.Hide(this.bdiv);
        }
        
        private void provdisplayNumber()
        {

            if ((((textBox1.Text[0].ToString() == "0") || (textBox1.Text[0].ToString() == "-" && textBox1.Text[1].ToString() == "0")) && _digits.Contains(",")))// || (_digits.Count < 3 && _digits.Contains(",")&&textBox1.Text=="-0"||textBox1.Text=="0"))
            {
                textBox1.Text = "0";

                    object[] s = _digits.ToArray();
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        textBox1.Text += s[i].ToString();
                    }

                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "0";
                    }
                    if (_negative == true)
                    {
                        textBox1.Text = "-" + textBox1.Text;
                    }
                }
            else
            {
                textBox1.Text = "";
                // Проход по стеку разрядов (приведено три варианта кода) и формирование
                // строки вывода для поля ввода/вывода
                object[] s = _digits.ToArray();
                for (int i = s.Length - 1; i >= 0; i--)
                {

                    textBox1.Text += s[i].ToString();
                }

                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (_negative == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }

        
        }
     
        //Обработка нажатия числовой кнопки
        private void NumericButtonPress(object sender, EventArgs e)
        { //разблокирование кнопки "равно"	
            
           bequally.Enabled = true;

            //какая числовая кнопка нажата
            if (sender == b0)
            { NumberKeyPress0("0"); }
            else if (sender == b1)
            { NumberKeyPress("1"); }
            else if (sender == b2)
            { NumberKeyPress("2"); }
            else if (sender == b3)
            { NumberKeyPress("3"); }
            else if (sender == b4)
            { NumberKeyPress("4"); }
            else if (sender == b5)
            { NumberKeyPress("5"); }
            else if (sender == b6)
            { NumberKeyPress("6"); }
            else if (sender == b7)
            { NumberKeyPress("7"); }
            else if (sender == b8)
            { NumberKeyPress("8"); }
            else if (sender == b9)
            { NumberKeyPress("9"); }

            else if (sender == bpoint)
            { NumberKeyPress1(","); }
        }
        private double PullNumber()
        {
            double number = 0;
                 
                    number = Convert.ToDouble(textBox1.Text);
            _negative = false;
            _digits.Clear();
            return number;
        }
        private void NumberKeyPress(string Digit)
        {
            _digits.Push(Digit);
            provdisplayNumber();
        }
         private void NumberKeyPress0(string Digit)
        {
            
                if (textBox1.Text=="0"||textBox1.Text=="-0")
                {
                    

                }
                else
                {
                    _digits.Push(Digit);
                    provdisplayNumber();
                }
            }
        //По нажатию числовой кнопки в стек заносится значение, соответствующее
        //этой кнопке
        private void NumberKeyPress1(string Digit)
        {
            int i;
            for (i = 0; i <= _digits.Count; i++)
            {
                if (_digits.Contains(","))
                {
                    break;

                }
                else
                {
                    _digits.Push(Digit);
                    provdisplayNumber();
                }
            }

        return;
        }
       
     
     
        private void AdditionalButtonPress(object sender, EventArgs e)
        {
            if (sender == bce)
            {
                Clear();
            }
            else if (sender == bc)
            {
                InitCalculator();
                X = 0;
                Y = 0;
                ChangeFunctionsVisible(true);
            }
            else if (sender == bznak)
            {
                ChangeSign();
            }
            else if (sender == bBackSpace)
            {
                RemoveLastDigit();
            }
            else if (sender == bsqrt)
            {
                SqrtDispleyedNumber();
            }
            else if (sender == bdiv_x)
            {
                Div_X_DispleyedNumber();
            }
        }
        //Обработка кнопок (+, -, *, /)

        private void OperationButtonPress(object sender, EventArgs e)
        {
           
            // Из поля ввода/вывода взяли первый операнд - X 
            X = PullNumber();

            // Заблокировать функциональные кнопки
            ChangeFunctionsVisible(false);

            //указать операцию
            if (sender == badd)
            {
                _currentOperation = Operations.Add;
            }
            else if (sender == bsub)
            {
                _currentOperation = Operations.Sub;
            }
            else if (sender == bmul)
            {
                _currentOperation = Operations.Mul;
            }
            else if (sender == bdiv)
            {
                _currentOperation = Operations.Div;
            }
            else if (sender == bproc)
            {
                _currentOperation = Operations.Proc;
            }
            else
            {
                return;
            }

            // заблокировать кнопку равно (пока есть только первый операнд)
            // эта блокировка будет снята нажатием любой числовой кнопки -  то есть вводом 
            // второго операнда

            EqualKey_Block();
            textBox1.Text = "0";
        }
        // Обработка нажатия кнопки "равно"
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result = 0;

            //Взять второй операнд - Y
            Y = PullNumber();

            //выполнить операцию
            switch (_currentOperation)
            {
                case Operations.Add:
                    result = X + Y;
                    break;
                case Operations.Div:
                    result = X / Y;
                    break;
                case Operations.Sub:
                    result = X - Y;
                    break;
                case Operations.Mul:
                    result = X * Y;
                    break;
                case Operations.Proc:
                    result = X * Y / 100;
                    break;
                    
                
            }

            //вывести результат
            displayNumber(result);

            //разблокировать функциональные кнопки
            ChangeFunctionsVisible(true);
        }
        private void displayNumber(double number)
        { textBox1.Text = Convert.ToString(number); 
        }
        // процедура для отключения части функциональных кнопок 

        private void ChangeFunctionsVisible(bool visibility)
        {
            bsqrt.Enabled = visibility; 
            bdiv_x.Enabled = visibility;

            
        }

        private void EqualKey_Block()
        {
            bequally.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Div_X_DispleyedNumber()
        {
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Деление на ноль не возможно");
                Clear();
                return;
            }
            else
            {
                double number = Convert.ToDouble(textBox1.Text);
                displayNumber(1 / number);
                _digits.Clear();
            }
        }
        private void SqrtDispleyedNumber()
        {
            double number = Convert.ToDouble(textBox1.Text);
            if (number >= 0)
            {
                displayNumber(Math.Pow(number, 0.5));
                _digits.Clear();
                
            }
            else
            {
                MessageBox.Show("Недопустимый ввод");
                Clear();
                return;
            }
        }
             
        private void bequally_Click(object sender, EventArgs e)
        {

        }

        // Работа с кнопками памяти - здесь нет кода 
        private void MemoryButtonPress(object sender, EventArgs e)
         {
             if (sender == bMAdd)
             {
                 AddMemory();
             }
             else if (sender == bMS)
              {
                  ShiftMemory();
                  
             }
             else if (sender == bMR)
             {
                 textBox1.Text = Z.ToString();
             }
             else if (sender == bMC)
             {
                 ClearMemory();
             }
         }
        private void ClearMemory()
        {
            Z = 0;
            label3.Text = "0";

        }

       

        private void ShiftMemory()
        {
            Z = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            _digits.Clear();
            label3.Text = Z.ToString();
        }

        private void AddMemory()
        {
            Z=Z+Convert.ToDouble(textBox1.Text);
            label3.Text = Z.ToString();
            
                  
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show(this);
        }

        private void bproc_Click(object sender, EventArgs e)
        {
            if (X != 0)
            {

            }
            else
            {
                Clear();
                return;
            }
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Справка Spravka = new Справка();
            Spravka.ShowDialog(this);
        }

       

        
    }
}
