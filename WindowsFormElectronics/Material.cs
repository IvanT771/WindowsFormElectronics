using System;



namespace WindowsFormElectronics
{
    [System.Serializable]
    public class Material
    {
        //Константы
        private const double k = 8.617333262E-5; // Постоянная Больцмана (эВ/К)  
        private const double q = 1.6E-19; //Электрический заряд
        //Табличные данные
        public double phiz;    //Ширина запрещенной зоны
        public double eps;     //Температурная чувствительность
        public double mc;      //Эффективная масса электронов
        public double mv;      //Эффективная масса дырок
        public double mun;     //Подвижность электронов
        public double mup;     //Подвижность дырок
        public double Tion;    //Температура полной ионизации
        public double Tmin;    //Температура при которой начинается ионизация
        //Данные управления
        public string name = "-";


        public void SetDefaultData(int i)
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
                    Tmin = 90;
                    Tion = 180;
                    name = "Si";
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
                    name = "Ge";
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
                    name = "GaAs";
                    break;

                default:
                    phiz = 1.21;    //+ (эВ)
                    eps = 3E-4;     //+
                    mc = 1.08;      //+
                    mv = 0.56;      //+
                    mun = 1400;     //+
                    mup = 500;      //+
                    Tmin = 90;
                    Tion = 180;
                    name = "Si";
                    break;

            }
        }
       
    }

}
