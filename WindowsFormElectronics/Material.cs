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
        private const double k = 8.617333262E-5; // Постоянная Больцмана (эВ/К)  
        private const double q = 1.6E-19; //Электрический заряд
        //Табличные данные
        private double phiz;    //Ширина запрещенной зоны
        private double eps;     //Температурная чувствительность
        private double mc;      //Эффективная масса электронов
        private double mv;      //Эффективная масса дырок
        private double mun;     //Подвижность электронов
        private double mup;     //Подвижность дырок
        //Входные данные
        private bool isDonor;   //Тип примеси
        private double N;       //Концентрация примеси
        private double T;       //Температура
        private double Lx;      //Ширина
        private double Ly;      //Высота
        private double Lz;      //Длина
        //Вычисляемые данные
        private double ni;      //Концентрация собственного полупроводника
        private double major;   //Концентрация основных носителей
        private double minor;   //Концентрация неосновные носителей
        private double nmu;     //Подвижность электронов
        private double pmu;     //Подвижность дырок
        private double G;       //Проводимость полупроводника
        private double R;       //Сопротивление полупроводника

        public Material(int i) // Инициализация табличных данных
        {
            switch (i)
            {
                case 0: //Si
                    phiz = 1.21;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 1.08;      //+
                    mv = 0.56;      //+
                    mun = 1400;     //+
                    mup = 500;      //+
                    break;
                case 1: //Ge
                    phiz = 0.75;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 0.55;      //+
                    mv = 0.39;      //+
                    mun = 3800;     //+
                    mup = 1800;      //+
                    break;
                case 2: //GaAs
                    phiz = 1.52;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 0.067;     //+
                    mv = 0.45;      //+
                    mun = 11000;     //+
                    mup = 450;      //+
                    break;
                case 3://InP - надо найти
                    mun = 0;    // (см^2 / B*c)
                    mup = 0;    // (см^2 / B*c)
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
            this.Lx = Lx;
            this.Ly = Ly;
            this.Lz = Lz;
        }

        public void CalculateNi() // Расчет концентрации собственного полупроводника
        {
            double Nc = Math.Sqrt(Math.Pow(mc, 3)) * Math.Sqrt(Math.Pow(T/300, 3)) * 2.5 * 1E19;
            double Nv = Math.Sqrt(Math.Pow(mv, 3)) * Math.Sqrt(Math.Pow(T/300, 3)) * 2.5 * 1E19;
            double fz = phiz - eps * T;
            ni = Math.Sqrt(Nc * Nv) * Math.Exp(-fz / (2 * k * T));
            Console.WriteLine("Nc - " + Nc.ToString());
            Console.WriteLine("Nv - " + Nv.ToString());
            Console.WriteLine("fz - " + fz.ToString());
            Console.WriteLine("ni - " + ni.ToString());
            Console.WriteLine();
        }
        public void CalculateG() // Расчет 
        {
            major = N;
            minor = Math.Pow(ni, 2) / major;
            int n = 5;
            double kn = (90 * mun * (n - 1)) / (90 * (90 * (n - 1) + 190));
            double kp = (90 * mup * (n - 1)) / (90 * (90 * (n - 1) + 190));
            nmu = kn * (T - 300) + mun;
            pmu = kp * (T - 300) + mup;
            G = q * (major * (isDonor ? nmu : pmu) + minor * (isDonor ? pmu : nmu));
            Console.WriteLine("kn - " + kn.ToString());
            Console.WriteLine("kp - " + kp.ToString());
            Console.WriteLine("nmu - " + nmu.ToString());
            Console.WriteLine("pmu - " + pmu.ToString());
            Console.WriteLine();
        }

        public void CalculateR() // Расчет 
        {
            double S = Lx * Ly;
            R = Lz / (S * G);
            Console.WriteLine("R - " + R.ToString());
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
            Console.WriteLine();
        }
    }
}
