using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrices
{
    public class DosPorDos
    {
        public double Fila_1_Igualar_A_Uno_X(double X1)
        {
            double X = X1 / X1;
            return X;
        }
        public double Fila_1_Igualar_A_Uno_Y(double Y1, double X1)
        {
            double Y = Y1 / X1;
            return Y;
        }
        public double Fila_1_Igualar_A_Uno_T(double T1, double X1)
        {
            double T = T1 / X1;
            return T;
        }
        public double Fila_2_Igualar_A_Cero_X(double X1, double X2)
        {
            double X = X1 * (X2 * -1) + X2;
            return X;
        }
        public double Fila_2_Igualar_A_Cero_Y(double Y1, double X2, double Y2)
        {
            double Y = Y1 * (X2 * -1) + Y2;
            return Y;
        }
        public double Fila_2_Igualar_A_Cero_T(double T1, double X2, double T2)
        {
            double T = T1 * (X2 * -1) + T2;
            return T;
        }
        public double Fila_2_Igualar_A_Uno_Y(double Y1)
        {
            double Y = Y1 / Y1;
            return Y;
        }
        public double Valor_Y(double Y2, double T2)
        {
            double T = T2 / Y2;
            return T;
        }
        public double Fila_1_Igualar_A_Cero_Y(double Y2, double Y1)
        {
            double Y = Y2 * (Y1 * -1) + Y1;
            return Y;
        }
        public double Valor_X(double T2, double Y1, double T1)
        {
            double T = T2 * (Y1 * -1) + T1;
            return T;
        }
    }
    public class TresPorTres
    {
        public double Fila_1_Igualar_A_Uno_X(double X1)
        {
            double X = X1 / X1;
            return X;
        }
        public double Fila_1_Igualar_A_Uno_Y(double Y1, double X1)
        {
            double Y = Y1 / X1;
            return Y;
        }
        public double Fila_1_Igualar_A_Uno_Z(double Z1, double X1)
        {
            double Z = Z1 / X1;
            return Z;
        }
        public double Fila_1_Igualar_A_Uno_T(double T1, double X1)
        {
            double T = T1 / X1;
            return T;
        }
        public double Fila_2_Igualar_A_Cero_X(double X1, double X2)
        {
            double X = X1 * (X2 * -1) + X2;
            return X;
        }
        public double Fila_2_Igualar_A_Cero_Y(double Y1, double X2, double Y2)
        {
            double Y = Y1 * (X2 * -1) + Y2;
            return Y;
        }
        public double Fila_2_Igualar_A_Cero_Z(double Z1, double X2, double Z2)
        {
            double Z = Z1 * (X2 * -1) + Z2;
            return Z;
        }
        public double Fila_2_Igualar_A_Cero_T(double T1, double X2, double T2)
        {
            double T = T1 * (X2 * -1) + T2;
            return T;
        }
        public double Fila_3_Igualar_A_Cero_X(double X1, double X3)
        {
            double X = X1 * (X3 * -1) + X3;
            return X;
        }
        public double Fila_3_Igualar_A_Cero_Y(double Y1, double X3, double Y3)
        {
            double Y = Y1 * (X3 * -1) + Y3;
            return Y;
        }
        public double Fila_3_Igualar_A_Cero_Z(double Z1, double X3, double Z3)
        {
            double Z = Z1 * (X3 * -1) + Z3;
            return Z;
        }
        public double Fila_3_Igualar_A_Cero_T(double T1, double X3, double T3)
        {
            double T = T1 * (X3 * -1) + T3;
            return T;
        }
        public double Fila_2_Igualar_A_Uno_Y(double Y2)
        {
            double Y = Y2 / Y2;
            return Y;
        }
        public double Fila_2_Igualar_A_Uno_Z(double Z2, double Y2)
        {
            double Z = Z2 / Y2;
            return Z;
        }
        public double Fila_2_Igualar_A_Uno_T(double T2, double Y2)
        {
            double T = T2 / Y2;
            return T;
        }
        public double Fila_3_Igualar_A_Cero_Y_2do(double Y2, double Y3)
        {
            double Y = Y2 * (Y3 * -1) + Y3;
            return Y;
        }
        public double Fila_3_Igualar_A_Cero_Z_2do(double Z2, double Y3, double Z3)
        {
            double Z = Z2 * (Y3 * -1) + Z3;
            return Z;
        }
        public double Fila_3_Igualar_A_Cero_T_2do(double T2, double Y3, double T3)
        {
            double T = T2 * (Y3 * -1) + T3;
            return T;
        }
        public double Fila_3_Igualar_A_Uno_Z(double Z3)
        {
            double Z = Z3 / Z3;
            return Z;
        }
        public double Valor_Z(double T3, double Z3)
        {
            double T = T3 / Z3;
            return T;
        }
        public double Fila_2_Igualar_A_Cero_Z_2do(double Z3, double Z2)
        {
            double Z = Z3 * (Z2 * -1) + Z2;
            return Z;
        }
        public double Valor_Y(double T3, double Z2, double T2)
        {
            double T = T3 * (Z2 * -1) + T2;
            return T;
        }
        public double Fila_1_Igualar_A_Cero_Y(double Y2, double Y1)
        {
            double Y = Y2 * (Y1 * -1) + Y1;
            return Y;
        }
        public double Fila_1_Igualar_A_Cero_Z(double Z3, double Y1, double Z1)
        {
            double Z = Z3 * (Z1 * -1) + Z1;
            return Z;
        }
        public double Fila_1_Igualar_A_Cero_T(double T3, double Z1, double T1)
        {
            double T = T3 * (Z1 * -1) + T1;
            return T;
        }
        public double Valor_X(double T2, double Y1, double T1)
        {
            double T = T2 * (Y1 * -1) + T1;
            return T;
        }
    }
}
