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
    public partial class SettingsMaterial : Form
    {
        Material[] materials;

        public SettingsMaterial()
        {
            InitializeComponent();
            MaterialInit();
        }

        //Метод инициализации материалов
        private void MaterialInit()
        {
            comboBox1.Items.Clear();

            materials = SaveSystem.LoadData().materials;

            foreach (var item in materials)
            {
                comboBox1.Items.Add(item.name);
            }

            comboBox1.Items.Add("Добавить новый материал");
            comboBox1.SelectedIndex = 0;
            FuellData(0);
        }

        //Метод добавления нового материала
        private void AddNewMaterial()
        {
            if(materials == null) { materials = SaveSystem.LoadData().materials; }

            Material[] mat = new Material[materials.Length+1];

            for (int i = 0; i < materials.Length; i++)
            {
                mat[i] = materials[i];
            }

            double phiz;    //Ширина запрещенной зоны
            double eps;     //Температурная чувствительность
            double mc;      //Эффективная масса электронов
            double mv;      //Эффективная масса дырок
            double mun;     //Подвижность электронов
            double mup;     //Подвижность дырок
            double Tion;    //Температура полной ионизации
            double Tmin;    //Температура при которой начинается ионизация

            if(!(double.TryParse(richTextBox1.Text,out phiz) &&
                 double.TryParse(richTextBox2.Text,out eps) &&
                 double.TryParse(richTextBox3.Text,out mc) &&
                 double.TryParse(richTextBox4.Text,out mv) &&
                 double.TryParse(richTextBox5.Text,out mun) &&
                 double.TryParse(richTextBox6.Text,out mup) &&
                 double.TryParse(richTextBox7.Text,out Tmin) &&
                 double.TryParse(richTextBox8.Text,out Tion)))
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rnd = new Random();
            mat[mat.Length - 1] = new Material();

            mat[mat.Length-1].phiz = phiz;
            mat[mat.Length-1].eps = eps;
            mat[mat.Length-1].mc = mc;
            mat[mat.Length-1].mv = mv;
            mat[mat.Length-1].mun = mun;
            mat[mat.Length-1].mup = mup;
            mat[mat.Length-1].Tion = Tion;
            mat[mat.Length-1].Tmin = Tmin;
            mat[mat.Length-1].name = "material"+rnd.Next(0,999);

            SaveSystem.SaveData(mat);
            MaterialInit();
            if (comboBox1.Items.Count >= 2) { 
            comboBox1.SelectedIndex = comboBox1.Items.Count-2; }

    }


        //Метод закрытия формы "Настройка материала"
        private void buttonCLoseApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        //Метод заполнения полей с данными о материале
        public void FuellData(int i)
        {
            if (materials == null) { materials = SaveSystem.LoadData().materials; }
            if (i >= materials.Length || i < 0) { return; }

            richTextBox1.Text = materials[i].phiz.ToString();
            richTextBox2.Text = materials[i].eps.ToString();
            richTextBox3.Text = materials[i].mc.ToString();
            richTextBox4.Text = materials[i].mv.ToString();
            richTextBox5.Text = materials[i].mun.ToString();
            richTextBox6.Text = materials[i].mup.ToString();
            richTextBox7.Text = materials[i].Tmin.ToString();
            richTextBox8.Text = materials[i].Tion.ToString();
            richTextBox9.Text = materials[i].name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexAddMaterial = comboBox1.FindString("Добавить новый материал");

            if (comboBox1.SelectedIndex == indexAddMaterial)
            {
                AddNewMaterial();
            }
            else
            {
                FuellData(comboBox1.SelectedIndex);
            }
        }

        //Кнопка возврата к значениям по умолчанию
        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите сбросить все настройки к начальным? ","Предупреждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveSystem.SaveData(SaveSystem.LoadDefaultData().materials);
                MaterialInit();
            }
            
        }

        //Кнопка сохранения изменений
        private void button2_Click(object sender, EventArgs e)
        {
            if(materials == null) { return;}
            if(comboBox1.SelectedIndex >= materials.Length || comboBox1.SelectedIndex<0) { return;}

            double phiz;    //Ширина запрещенной зоны
            double eps;     //Температурная чувствительность
            double mc;      //Эффективная масса электронов
            double mv;      //Эффективная масса дырок
            double mun;     //Подвижность электронов
            double mup;     //Подвижность дырок
            double Tion;    //Температура полной ионизации
            double Tmin;    //Температура при которой начинается ионизация

            if (!(double.TryParse(richTextBox1.Text, out phiz) &&
                 double.TryParse(richTextBox2.Text, out eps) &&
                 double.TryParse(richTextBox3.Text, out mc) &&
                 double.TryParse(richTextBox4.Text, out mv) &&
                 double.TryParse(richTextBox5.Text, out mun) &&
                 double.TryParse(richTextBox6.Text, out mup) &&
                 double.TryParse(richTextBox7.Text, out Tmin) &&
                 double.TryParse(richTextBox8.Text, out Tion)))
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rnd = new Random();
            materials[comboBox1.SelectedIndex] = new Material();

            materials[comboBox1.SelectedIndex].phiz = phiz;
            materials[comboBox1.SelectedIndex].eps = eps;
            materials[comboBox1.SelectedIndex].mc = mc;
            materials[comboBox1.SelectedIndex].mv = mv;
            materials[comboBox1.SelectedIndex].mun = mun;
            materials[comboBox1.SelectedIndex].mup = mup;
            materials[comboBox1.SelectedIndex].Tion = Tion;
            materials[comboBox1.SelectedIndex].Tmin = Tmin;
            materials[comboBox1.SelectedIndex].name = richTextBox9.Text.Length<=0?"material" + rnd.Next(0, 999): richTextBox9.Text;

            var b = comboBox1.SelectedIndex;
            SaveSystem.SaveData(materials);
            MessageBox.Show("Данные успешно сохранены","Уведомление",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MaterialInit();
            comboBox1.SelectedIndex = b;
        }

        private void richTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
