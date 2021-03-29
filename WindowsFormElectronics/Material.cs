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
        private const double k = 8.62E-5; // Постоянная Больцмана (эВ/К)  
        private const double q = 1.6E-19; //Электрический заряд
        //Табличные данные
        private double mun;     //Подвижность электронов
        private double mup;     //Подвижность дырок
        private double Nc;      //Эффективная плотность состояния в зоне проводимости
        private double Nv;      //Эффективная плотность состояния в валентной зоне
        private double phiz;    //Ширина запрещенной зоны
        private double mc;      //Эффективная масса электронов
        private double mv;      //Эффективная масса дырок
        private double B;
        //Входные данне
        private bool isDonor;   //Тип примеси
        private double N;       //Концентрация примеси
        private double T;       //Температура
        private double Lx;      //Ширина
        private double Ly;      //Высота
        private double Lz;      //Длина
        //Выходные данные
        private double ni;      //Концентрация собственного полупроводника
        private double major;   //Основные носители
        private double minor;   //Неосновные носители
        private double G;       //Проводимость полупроводника
        private double R;

        public Material(int i) // Инициализация табличных данных
        {
            switch (i)
            {
                case 0: //Si
                    mun = 1500;     // (см^2 / B*c)
                    mup = 450;      // (см^2 / B*c)
                    Nc = 2.8E19;    // (см^-3)
                    Nv = 1E19;      // (см^-3)
                    phiz = 1.21;    // (эВ)
                    mc = 1.08;
                    mv = 0.56;
                    ni = 1.45E10;
                    B = 3.87E16;
                    break;
                case 1: //Ge
                    mun = 3900;     // (см^2 / B*c)
                    mup = 1900;     // (см^2 / B*c)
                    Nc = 1E19;      // (см^-3)
                    Nv = 6E18;      // (см^-3)
                    phiz = 0.785;    // (эВ)
                    mc = 0.55;
                    mv = 0.37;
                    ni = 2.4E13;
                    B = 1.76E16;
                    break;
                case 2: //GaAs
                    mun = 8500;     // (см^2 / B*c)
                    mup = 400;      // (см^2 / B*c)
                    Nc = 4.7E17;    // (см^-3)
                    Nv = 7E17;      // (см^-3)
                    phiz = 1.52;   // (эВ)
                    mc = 1.08;
                    mv = 0.56;
                    ni = 1.79E6;
                    break;
                case 3://InP - надо найти
                    mun = 0;    // (см^2 / B*c)
                    mup = 0;    // (см^2 / B*c)
                    Nc = 0;     // (см^-3)
                    Nv = 0;     // (см^-3)
                    phiz = 1.29;   // (эВ)
                    mc = 0;
                    mv = 0;
                    break;
            }
        }

        public void SetInputData(bool isDon, double N, double T, double Lx, double Ly, double Lz)
        {
            this.isDonor = isDon;
            this.N = N;
            this.T = T;
        }

        public void CalculateNi() // Расчет концентрации собственного полупроводника
        {
            //Nc = Math.Sqrt(Math.Pow(mc, 3)) * Math.Sqrt(Math.Pow(T/300, 3)) * 2.5 * 1E19;
            //Nv = Math.Sqrt(Math.Pow(mv, 3)) * Math.Sqrt(Math.Pow(T/300, 3)) * 2.5 * 1E19;
            ni = B * Math.Sqrt(Math.Pow(T, 3)) * Math.Exp(-phiz/(2*k*T));
        }
        public void CalculateG() // Расчет 
        {
            major = N;
            minor = Math.Pow(ni, 2) / major;
            G = q * (major * (isDonor ? mun : mup) + minor * (isDonor ? mup : mun));
        }

        public void CalculateR() // Расчет 
        {
            major = N;
            minor = Math.Pow(ni, 2) / major;
            double S = Lx * Ly;
            R = Lz/(S*major*(isDonor?mun:mup));
        }

        public double GetNi()
        {
            return ni;
        }

        public double GetG()
        {
            return G;
        }
        public double GetMajor()
        {
            return major;
        }
        public double GetMinor()
        {
            return minor;
        }
        public double GetR()
        {
            return R;
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
