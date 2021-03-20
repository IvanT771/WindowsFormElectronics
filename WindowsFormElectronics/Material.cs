using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormElectronics
{
    class Material
    {
        //Константы
        private const double k = 1.380649E-23; // Постоянная Больцмана (Дж/К)  
        //Табличные данные
        private double mun;     //Подвижность электронов
        private double mup;     //Подвижность дырок
        private double Nc;      //Эффективная плотность состояния в зоне проводимости
        private double Nv;      //Эффективная плотность состояния в валентной зоне
        private double phiz;    //Ширина запрещенной зоны
        //Входные данне
        private double Na;      //Концентрация акцепторной примеси
        private double Nd;      //Концентрация донорной примеси
        private double T;       //Температура
        //Выходные данные
        private double ni;      //Концентрация собственных носителей полупроводника
        private double G;       //Проводимость полупроводника

        public Material(int i) // Инициализация табличных данных
        {
            switch (i)
            {
                case 0: //Si
                    mun = 1500;     // (см^2 / B*c)
                    mup = 450;      // (см^2 / B*c)
                    Nc = 2.8E19;    // (см^-3)
                    Nv = 1E19;      // (см^-3)
                    phiz = 1.12;    // (эВ)
                    break;
                case 1: //Ge
                    mun = 3900;     // (см^2 / B*c)
                    mup = 1900;     // (см^2 / B*c)
                    Nc = 1E19;      // (см^-3)
                    Nv = 6E18;      // (см^-3)
                    phiz = 0.66;    // (эВ)
                    break;
                case 2: //GaAs
                    mun = 8500;     // (см^2 / B*c)
                    mup = 400;      // (см^2 / B*c)
                    Nc = 4.7E17;    // (см^-3)
                    Nv = 7E17;      // (см^-3)
                    phiz = 1.424;   // (эВ)
                    break;
                case 3://In - надо найти
                    mun = 0;    // (см^2 / B*c)
                    mup = 0;    // (см^2 / B*c)
                    Nc = 0;     // (см^-3)
                    Nv = 0;     // (см^-3)
                    phiz = 0;   // (эВ)
                    break;
            }
        }

        public void SetInputData(double Na, double Nd, double T)
        {
            this.Na = Na;
            this.Nd = Nd;
            this.T = T;
        }

        public void CalculateNi() // Расчет концентрации собственных носителей
        {
            phiz = 1.12 * 1.6E-19;
            Nc = Math.Sqrt(Math.Pow(1.08, 3)) * Math.Sqrt(Math.Pow(T/300, 3)) * 2.5 * 1E19;
            Nv = Math.Sqrt(Math.Pow(0.56, 3)) * Math.Sqrt(Math.Pow(T/300, 3)) * 2.5 * 1E19;
            ni = Math.Sqrt(Nc * Nv) * Math.Exp(-phiz/(2*k*T));
        }

        public String GetNi()
        {
            return ni.ToString("E");
        }

        public void ShowData()
        {
            Console.WriteLine("mun - " + mun.ToString());
            Console.WriteLine("mup - " + mup.ToString());
            Console.WriteLine("Nc - " + Nc.ToString());
            Console.WriteLine("Nv - " + Nv.ToString());
            Console.WriteLine("phiz - " + phiz.ToString());
            Console.WriteLine("T - " + T.ToString());
            Console.WriteLine("ni - " + ni.ToString());
            Console.WriteLine();
        }
    }
}
