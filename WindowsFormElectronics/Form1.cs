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
        }
     
        private void ChangeSizeTextBox(RichTextBox box,int indent)
        {

        }
        //Обработчик изменения размера формы
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelLeft.Size = new Size(this.Size.Width/2-20, panelLeft.Size.Height);
            panelRight.Size = new Size(this.Size.Width/2, panelRight.Size.Height);

            panelMaterial.Size = new Size(panelMaterial.Size.Width, (int)((panelLeft.Size.Height + panelMaterial.Size.Height)*0.13f));
            
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



        }
    }
}
