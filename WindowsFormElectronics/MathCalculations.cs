using System;

namespace WindowsFormElectronics
{
    public class MathCalculations
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
        private double Tion;    //Температура полной ионизации
        private double Tmin;    //Температура при которой начинается ионизация
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

        public MathCalculations() // Инициализация табличных данных
        {
            switch (0)
            {
                case 0: //Si
                    phiz = 1.21;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 1.08;      //+
                    mv = 0.56;      //+
                    mun = 1400;     //+
                    mup = 500;      //+
                    Tmin = 90;
                    Tion = 180;
                    break;
                case 1: //Ge
                    phiz = 0.75;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 0.55;      //+
                    mv = 0.39;      //+
                    mun = 3800;     //+
                    mup = 1800;      //+
                    Tmin = 90;
                    Tion = 170;
                    break;
                case 2: //GaAs
                    phiz = 1.52;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 0.067;     //+
                    mv = 0.45;      //+
                    mun = 11000;     //+
                    mup = 450;      //+
                    Tmin = 90;
                    Tion = 170;
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

        //Метод смены материала
        public void ChoiceCurrentMaterial(Material material)
        {
            phiz = material.phiz;   
            eps = material.eps;     
            mc = material.mc;      
            mv = material.mv;      
            mun = material.mun;     
            mup = material.mup;      
            Tmin = material.Tmin;
            Tion = material.Tion;
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
            double Nc = Math.Sqrt(Math.Pow(mc, 3)) * Math.Sqrt(Math.Pow(T / 300, 3)) * 2.5 * 1E19;
            double Nv = Math.Sqrt(Math.Pow(mv, 3)) * Math.Sqrt(Math.Pow(T / 300, 3)) * 2.5 * 1E19;
            double fz = phiz - eps * T;
            ni = Math.Sqrt(Nc * Nv) * Math.Exp(-fz / (2 * k * T));
        }
        public void CalculateG() // Расчет 
        {
            if (T < Tmin)
            {
                major = 0;
                minor = 0;
            }
            else if (T > Tmin && T < Tion)
            {
                major = N * (T - Tmin) / (Tion - Tmin);
                minor = Math.Pow(ni, 2) / major;
            }
            else
            {
                major = Math.Sqrt(N * N / 4 + ni * ni) + N / 2;
                minor = Math.Pow(ni, 2) / major;
            }
            major = major < 1 ? 0 : major;
            minor = minor < 1 ? 0 : minor;
            int n = 5;
            double kn = (90 * mun * (n - 1)) / (90 * (90 * (n - 1) + 190));
            double kp = (90 * mup * (n - 1)) / (90 * (90 * (n - 1) + 190));
            nmu = kn * (T - 300) + mun;
            pmu = kp * (T - 300) + mup;
            G = q * (major * (isDonor ? nmu : pmu) + minor * (isDonor ? pmu : nmu));
        }

        public void CalculateR() // Расчет 
        {
            double S = Lx * Ly;
            R = Lz / (S * G);
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
    }
}
