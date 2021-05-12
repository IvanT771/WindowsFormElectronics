using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormElectronics
{
    public partial class Form1 : Form
    {
        private bool isDonor = false; //Тип примеси
        private Material[] materials; //Материалы
        private MathCalculations calculations;

        public Form1()
        {
            calculations = new MathCalculations();
            InitializeComponent();
            MaterialsInitialize();
        }

        public void MaterialsInitialize()
        {
            materials = SaveSystem.LoadData().materials;

            comboBox1.Items.Clear();

            foreach (var item in materials)
            {
                comboBox1.Items.Add(item.name);
            }

            comboBox1.SelectedIndex = 0;
        }

        

        //Метод защиты ввода 
        private bool isProtect()
        {
            if (richTextBox2.Text.Length <= 0 || richTextBox3.Text.Length <= 0
               || richTextBox4.Text.Length <= 0 || richTextBox5.Text.Length <= 0 || richTextBox6.Text.Length <= 0)
            {
                MessageBox.Show("Поля ввода не должны быть путыми!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //Метод обработки нажатия кнопки "Выполнить расчет"
        private void button_Calculation(object obj, EventArgs e)
        {
            if (!isProtect()) { return; }

            double N = 0;   //Концентрация
            double T = 0;   //Температура

            double Lx = 0;  //Длина x
            double Ly = 0;  //Длина y
            double Lz = 0;  //Длина z


            if (!(
                Double.TryParse(richTextBox2.Text, out N) &&
                Double.TryParse(richTextBox3.Text, out T) &&
                Double.TryParse(richTextBox4.Text, out Lx) &&
                Double.TryParse(richTextBox5.Text, out Ly) &&
                Double.TryParse(richTextBox6.Text, out Lz)
                ))
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (T < 0 || T > 1000)
            {
                MessageBox.Show("Данные введены некорректно! Температура должна быть в диапазоне от 0К до 1000К", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (N < 0 || N > 10E25)
            {
                MessageBox.Show("Данные введены некорректно! Концентраци примеси должна быть в диапазоне от 0 до 10Е25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Lx < 0 || Lx > 10 || Ly < 0 || Ly > 10 || Lz < 0 || Lz > 10)
            {
                MessageBox.Show("Данные введены некорректно! Геометрические параметры должна быть в диапазоне от 0 до 10 см", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            calculations.SetInputData(isDonor, N, T, Lx, Ly, Lz);

            //Сами расчеты ->
            calculations.CalculateNi();
            calculations.CalculateG();
            calculations.CalculateR();

            double ni = 0;      //Концентрация собственного полупроводника
            double major = 0;      //Основные носители
            double minor = 0;      //Неосновные носители
            double G = 0;       //Проводимость полупроводника
            double R = 0;       //Сопротивление

            ni = calculations.GetNi();
            G = calculations.GetG();
            major = calculations.GetMajor();
            minor = calculations.GetMinor();
            R = calculations.GetR();

            //Вывод данных
            richTextBox12.Text = G.ToString("#.#####E+0");
            richTextBox11.Text = ni.ToString("#.#####E+0");
            richTextBox10.Text = major.ToString("#.#####E+0");
            richTextBox9.Text = minor.ToString("#.#####E+0");
            richTextBox8.Text = R.ToString("#.#####E+0");
        }



        //Обработчик заполнения полей textBox 
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                if (e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == 'б' || e.KeyChar == 'ю' || e.KeyChar == '/')
                {
                    if (((RichTextBox)sender).Text.IndexOf(',') == -1 && ((RichTextBox)sender).Text.Length > 0 && ((RichTextBox)sender).Text.IndexOf('E') == -1)
                    {
                        e.KeyChar = ',';
                        e.Handled = false;
                        return;
                    }
                }
                if (e.KeyChar == 'E' || e.KeyChar == 'e' || e.KeyChar == 'у' || e.KeyChar == 'У')
                {
                    if (((RichTextBox)sender).Text.IndexOf('E') == -1 && ((RichTextBox)sender).Text.Length > 0)
                    {
                        e.KeyChar = 'E';
                        e.Handled = false;
                        return;
                    }
                }
                if (e.KeyChar == '-')
                {
                    if (((RichTextBox)sender).Text.Length > 0)
                    {
                        if (((RichTextBox)sender).Text[((RichTextBox)sender).Text.Length - 1] == 'E')
                        {
                            e.Handled = false;
                            return;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                        return;
                    }
                }
                e.Handled = true;
            }
        }

        //Кнопка сброса
        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox12.Clear();
            richTextBox8.Clear();
            richTextBox9.Clear();
            richTextBox10.Clear();
            richTextBox11.Clear();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                isDonor = false;
            }
            else
            {
                isDonor = true;
            }

            if (isDonor)
            {
                // N - тип
                label4.Text = "Концентрация примеси Nd (см^-3):";
                label12.Text = "Nn (см^-3):";
                label11.Text = "Pn (см^-3):";
            }
            else
            {
                // P - тип
                label4.Text = "Концентрация примеси Na (см^-3):";
                label12.Text = "Pp (см^-3):";
                label11.Text = "Np (см^-3):";
            }

        }

        //Button close application
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region MoveForm
        private bool isMove = false;
        private Point currentPosition = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            currentPosition = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMove) { return; }
            Point tmp = new Point(this.Location.X, this.Location.Y);
            tmp.X += e.X - currentPosition.X;
            tmp.Y += e.Y - currentPosition.Y;
            this.Location = tmp;

        }
        #endregion

        //Кнопка настройки материалов
        private void button4_Click(object sender, EventArgs e)
        {
            Form f1 = new SettingsMaterial();
            f1.ShowDialog();
        }

        //Смена материала
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(materials == null){  MaterialsInitialize();}
            if(comboBox1.SelectedIndex>= materials.Length || comboBox1.SelectedIndex < 0) { return;}
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            calculations.ChoiceCurrentMaterial(materials[comboBox1.SelectedIndex]);
        }
    }
}
