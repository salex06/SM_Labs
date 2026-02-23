using SM_LAB2.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_LAB2.models
{
    class Model1 : IModel
    {
        const double g = 9.81;
        private const int order = 5;

        private readonly double p = 2 * Math.Pow(10, 4);
        private readonly double a = 1.1;
        private readonly double m = 1100;
        private readonly double u = 10;
        private readonly double cx = 0.02;
        private readonly double cy = 0.005;
        private readonly double m1 = 0.03;
        private readonly double m2 = 0.003;
        private readonly double T = 11;

        private readonly double x1_start = 1100;
        private readonly double x2_start = 1;
        private readonly double x3_start = 0;
        private readonly double x4_start = 200;
        private readonly double x5_start = 1;

        public int GetOrder() {
            return order;
        }

        public double GetT() {
            return T;
        }

        public Vector GetInitialVariableVector() { 
            return new Vector(new List<double>(){ x1_start, x2_start, x3_start, x4_start, x5_start});
        }

        public Vector Calc(double t, Vector vars) {
            if (vars.Size != order) {
                throw new Exception($"Ожидалось {order} переменных, получено {vars.Size}");
            }

            double x1 = vars.Get(0);
            double x2 = vars.Get(1);
            double x3 = vars.Get(2);
            double x4 = vars.Get(3);
            double x5 = vars.Get(4);

            double x1_res = -g * Math.Sin(x2) + (p - a * cx * x1 * x1) / (m - u * t);
            double x2_res = (-g + (p * Math.Sin(x5 - x2) + a * cy * x1 * x1) / (m - u * t)) / x1;
            double x3_res = (m1 * a * (x2 - x5) * x1 * x1 - m2 * a * x1 * x1 * x3) / (m - u * t);
            double x4_res = x1 * Math.Sin(x2);
            double x5_res = x3;

            return new Vector(new List<double>() { x1_res, x2_res, x3_res, x4_res, x5_res });
        }

        public int GetDeltaIndicatorIndex() {
            return 3;
        }
    }
}
