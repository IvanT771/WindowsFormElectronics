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
        public Form1()
        {
            InitializeComponent();
            Form1_Resize(null,null);

            //Инициализация табличных данных
            for (int i = 0; i < COUNT; i++)
                MatArray[i] = new Material(i);
            MatArray[0].ShowData();
        }

        const int COUNT = 4; //Количество материалов

        enum IndexMaterial //Индексация материалов (Чтобы знать под каким номером какой материал)
        {
            Si = 0,
            Ge = 1,
            GaAs = 2,
            InP = 3
        }
        int currentMaterial = 0; //Индекс текущего материала
        Material[] MatArray = new Material[4];

        //Метод обработки нажатия на кнопки с материалом
        private void ChoiceMaterial(object obj, EventArgs e)
        {
            buttonSi.FlatAppearance.BorderSize = 0;
            buttonGe.FlatAppearance.BorderSize = 0;
            buttonGaAs.FlatAppearance.BorderSize = 0;
            buttonInP.FlatAppearance.BorderSize = 0;

            ((Button)obj).FlatAppearance.BorderSize = 5;
            currentMaterial = ((Button)obj).TabIndex;
        }

        //Метод обработки нажатия кнопки "Выполнить расчет"
        private void button_Calculation(object obj,EventArgs e)
        {
            double Na = Double.Parse(richTextBox1.Text);
            double Nd = Double.Parse(richTextBox2.Text);
            double T = Double.Parse(richTextBox3.Text);
            MatArray[currentMaterial].SetInputData(Na, Nd, T);
            MatArray[currentMaterial].CalculateNi();
            MatArray[currentMaterial].ShowData();
            richTextBox11.Text = MatArray[currentMaterial].GetNi();
        }
        //Обработчик изменения размера формы
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelLeft.Size = new Size(this.Size.Width/2-20, panelLeft.Size.Height);
            panelRight.Size = new Size(this.Size.Width/2, panelRight.Size.Height);

            panelMaterial.Size = new Size(panelMaterial.Size.Width, (int)((panelLeft.Size.Height + panelMaterial.Size.Height)*0.13f));
            panelRightTop.Size = panelMaterial.Size;


            int width = (int)(panelMaterial.Size.Width/4) - 8;
            int height = (int)(panelMaterial.Size.Height) - 10;
            buttonSi.Width = width;
            buttonSi.Height = height;
            buttonSi.Font = new Font(buttonSi.Font.FontFamily,width/6, buttonSi.Font.Style);
            buttonSi.Location = new Point(5,5);

            buttonGe.Width = width;
            buttonGe.Height = height;
            buttonGe.Font = buttonSi.Font;
            buttonGe.Location = new Point(width+10,5);

            buttonGaAs.Width = width;
            buttonGaAs.Height = height;
            buttonGaAs.Font = buttonSi.Font;
            buttonGaAs.Location = new Point(width*2+15,5);

            buttonInP.Width = width;
            buttonInP.Height = height;
            buttonInP.Font = buttonSi.Font;
            buttonInP.Location = new Point(width*3+20,5);

            height = (int)(panelInput.Height/6) - 11;
            width = (int)(panelInput.Width*0.4f);

            richTextBox1.Width = width;
            richTextBox1.Height = height;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, height / 2, richTextBox1.Font.Style); 
            richTextBox1.Location = new Point(panelInput.Width - richTextBox1.Width,10);

            richTextBox2.Width = width;
            richTextBox2.Height = height;
            richTextBox2.Font = richTextBox1.Font;
            richTextBox2.Location = new Point(panelInput.Width - richTextBox1.Width, height+15);

            richTextBox3.Width = width;
            richTextBox3.Height = height;
            richTextBox3.Font = richTextBox1.Font;
            richTextBox3.Location = new Point(panelInput.Width - richTextBox1.Width, height*2+20);

            richTextBox4.Width = width;
            richTextBox4.Height = height;
            richTextBox4.Font = richTextBox1.Font;
            richTextBox4.Location = new Point(panelInput.Width - richTextBox1.Width, height*3+25);

            richTextBox5.Width = width;
            richTextBox5.Height = height;
            richTextBox5.Font = richTextBox1.Font;
            richTextBox5.Location = new Point(panelInput.Width - richTextBox1.Width, height*4+30);

            richTextBox6.Width = width;
            richTextBox6.Height = height;
            richTextBox6.Font = richTextBox1.Font;
            richTextBox6.Location = new Point(panelInput.Width - richTextBox1.Width, height*5+35);

            width = (int)(panelInput.Width * 0.58f);

            label3.Width = width;
            label3.Height = height;
            label3.Font = new Font(label3.Font.FontFamily, (height+width) / 23f, label3.Font.Style);
            label3.Location = new Point(0, 10);

            label4.Width = width;
            label4.Height = height;
            label4.Font = label3.Font;
            label4.Location = new Point(0, height + 15);

            label5.Width = width;
            label5.Height = height;
            label5.Font = label3.Font;
            label5.Location = new Point(0, height * 2 + 20);

            label6.Width = width;
            label6.Height = height;
            label6.Font = label3.Font;
            label6.Location = new Point(0, height * 3 + 25);

            label7.Width = width;
            label7.Height = height;
            label7.Font = label3.Font;
            label7.Location = new Point(0, height * 4 + 30);

            label8.Width = width;
            label8.Height = height;
            label8.Font = label3.Font;
            label8.Location = new Point(0, height * 5 + 35);

            richTextBox12.Size = richTextBox1.Size;
            richTextBox12.Location = richTextBox1.Location;
            richTextBox12.Font = richTextBox1.Font;

            label14.Size = label3.Size;
            label14.Location = label3.Location;
            label14.Font = label3.Font;

            richTextBox11.Size = richTextBox1.Size;
            richTextBox11.Location = richTextBox2.Location;
            richTextBox11.Font = richTextBox2.Font;

            label13.Size = label4.Size;
            label13.Location = label4.Location;
            label13.Font = label4.Font;

            richTextBox10.Size = richTextBox1.Size;
            richTextBox10.Location = richTextBox3.Location;
            richTextBox10.Font = richTextBox3.Font;

            label12.Size = label5.Size;
            label12.Location = label5.Location;
            label12.Font = label5.Font;

            richTextBox9.Size = richTextBox1.Size;
            richTextBox9.Location = richTextBox4.Location;
            richTextBox9.Font = richTextBox3.Font;

            label11.Size = label5.Size;
            label11.Location = label6.Location;
            label11.Font = label5.Font;

            richTextBox8.Size = richTextBox1.Size;
            richTextBox8.Location = richTextBox5.Location;
            richTextBox8.Font = richTextBox3.Font;

            label10.Size = label5.Size;
            label10.Location = label7.Location;
            label10.Font = label5.Font;

        }

        //Обработчик заполнения полей textBox 
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                if(e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == 'б' || e.KeyChar == 'ю' || e.KeyChar == '/')
                {
                    if(((RichTextBox)sender).Text.IndexOf(',') == -1 && ((RichTextBox)sender).Text.Length > 0 && ((RichTextBox)sender).Text.IndexOf('E') == -1)
                    {
                        e.KeyChar = ',';
                        e.Handled = false;
                        return;
                    }
                }
                if(e.KeyChar == 'E' || e.KeyChar == 'e' || e.KeyChar == 'у' || e.KeyChar == 'У')
                {
                    if(((RichTextBox)sender).Text.IndexOf('E') == -1 )
                    {
                        e.KeyChar = 'E';
                        e.Handled = false;
                        return;
                    }
                }
                if(e.KeyChar == '-')
                {
                    if (((RichTextBox)sender).Text.Length > 0)
                    {
                        if(((RichTextBox)sender).Text[((RichTextBox)sender).Text.Length-1] == 'E')
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
            richTextBox1.Clear();
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
    }
}
