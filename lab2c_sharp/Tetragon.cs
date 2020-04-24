using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2c_sharp
{
    class Tetragon
    {
        public double[] pX;
        public double[] pY;
        

        public Tetragon()
            {
            pX = new double[4];
            pY = new double[4];
            Random randP = new Random();

            for (int i = 0; i < 4; i++)
            {
                pX[i] = randP.Next(-5, 10);
                pY[i] = randP.Next(-5, 10);
            }

            

        }

        public double GetSideAB()
        {
            double K1 = ((pX[1] - pX[0]) * (pX[1] - pX[0])) + ((pY[1] - pY[0]) * (pY[1] - pY[0]));
            return Math.Sqrt(K1);
        }

       

        public double GetSideAD()
        {
            double K2 = ((pX[3] - pX[0]) * (pX[3] - pX[0])) + ((pY[3] - pY[0]) * (pY[3] - pY[0]));

            return Math.Sqrt(K2);
        }

        public double GetSideBC()
        {
            double K3 = ((pX[2] - pX[1]) * (pX[2] - pX[1])) + ((pY[2] - pY[1]) * (pY[2] - pY[1]));
            return Math.Sqrt(K3);

        }

        public double GetSideCD()
        {
            double K4 = ((pX[3] - pX[2]) * (pX[3] - pX[2])) + ((pY[3] - pY[2]) * (pY[3] - pY[2]));
            return Math.Sqrt(K4);

        }
        //диагонали ищем как сумму 2х векторов
        public double GetDiagonale1()
        {
            double D1 = GetSideAB() + GetSideAD();
            return D1;
        }

        public double GetDiagonale2()
        {
            double D2 = GetSideBC() + GetSideCD();
            return D2;
        }

        public double GetPerimeter()
        {
            double P = GetSideAB() + GetSideAD() + GetSideBC() + GetSideCD();
            return P;
        }

        public double GetHalfPerimeter()
        {
            return GetPerimeter() / 2;
        }
        

        public double GetSquare()
        {
            //вычисление площади с помощью полпериметра

            return Math.Sqrt((GetHalfPerimeter() - GetSideAB()) * (GetHalfPerimeter() - GetSideAD()) * (GetHalfPerimeter() - GetSideBC()) * (GetHalfPerimeter() - GetSideCD()));

        }

        public void PrintTetragon()
        {
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"X: {pX[i]}\t Y: {pY[i]}\t Точка {i + 1}");
            }
            Console.WriteLine($" Side AB: {String.Format("{0:0.00}", GetSideAB())}\n Side BC: {String.Format("{0:0.00}", GetSideBC())}\n Side AD: {String.Format("{0:0.00}", GetSideAD())}\n Side CD: {String.Format("{0:0.00}", GetSideCD())}\n Diagonal 1(AC): {String.Format("{0:0.00}", GetDiagonale1())}\n Diagonal 2(BD): {String.Format("{0:0.00}", GetDiagonale2())}\n Perimeter: {String.Format("{0:0.00}", GetPerimeter())}\n Square: {String.Format("{0:0.00}", GetSquare())} ");
        }
    }
}
