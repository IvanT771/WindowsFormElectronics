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
        }
    }
}
