using SM_LAB2.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_LAB2.models
{
    class Model2 : IModel
    {
        const double deltaMax = 0.5;
        const int order = 5;

        private readonly double k = 1;
        private readonly double l = 6;
        private readonly double m = 1;
        private readonly double n = 10;
        private readonly double kt = 80;
        private readonly double b = 22000;
        private readonly double i1 = 10;
        private readonly double i2 = 1;
        private readonly double s = 200;
        private readonly double v = 800;
        private readonly double T = 10;

        private readonly double x1_start = 0.1;
        private readonly double x2_start = 0.1;
        private readonly double x3_start = 0;
        private readonly double x4_start = 0;
        private readonly double x5_start = 900;

       // private readonly double delta_start = 0;

        public Vector Calc(double t, Vector vars)
        {
            if (vars.Size != order)
            {
                throw new Exception($"Ожидалось {order} переменных, получено {vars.Size}");
            }

            double x1 = vars.Get(0);
            double x2 = vars.Get(1);
            double x3 = vars.Get(2);
            double x4 = vars.Get(3);
            double x5 = vars.Get(4);

            double x1_res = k * x2 - k * x1;
            double x2_res = x3;
            double x3_res = l * x1 - l * x2 - m * x3 + n * x4;
            
            double teta = (10000 - x5) / (b - v * t);
            double delta = -kt * x4 - i1 * x2 - i2 * x3 + s * (teta - x2);

            double x4_res = Math.Abs(delta) <= deltaMax ? delta : deltaMax * Math.Sign(delta);
            double x5_res = v * Math.Sin(x1);

            return new Vector(new List<double>() { x1_res, x2_res, x3_res, x4_res, x5_res });
        }

        public Vector GetInitialVariableVector()
        {
            return new Vector(new List<double>() { x1_start, x2_start, x3_start, x4_start, x5_start });
        }

        public int GetOrder()
        {
            return order;
        }

        public double GetT()
        {
            return T;
        }

        public int GetDeltaIndicatorIndex() {
            return 4;
        }
    }
}
