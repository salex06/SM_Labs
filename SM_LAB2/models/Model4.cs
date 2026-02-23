using SM_LAB2.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SM_LAB2.models
{
    class Model4 : IModel
    {
        private const int order = 3;
        private const double g = 9.81;

        private readonly double c = 6500;
        private readonly double u = 35;
        private readonly double T = 12;
        private readonly double htv = 9990;

        private readonly double x1_start = 1000;
        private readonly double x2_start = 0;
        private readonly double x3_start = 1090;

        private readonly List<KeyValuePair<double, double>> interp = new() {
            KeyValuePair.Create(0.0, 0.015),
            KeyValuePair.Create(500.0, 0.0135),
            KeyValuePair.Create(1000.0, 0.012),
            KeyValuePair.Create(1500.0, 0.0107),
            KeyValuePair.Create(2000.0, 0.0096),
            KeyValuePair.Create(2500.0, 0.0088),
            KeyValuePair.Create(3000.0, 0.0077),
            KeyValuePair.Create(3500.0, 0.0069),
            KeyValuePair.Create(4000.0, 0.0061),
            KeyValuePair.Create(4500.0, 0.0055),
            KeyValuePair.Create(5000.0, 0.0049),
            KeyValuePair.Create(5500.0, 0.0044),
            KeyValuePair.Create(6000.0, 0.0039),
            KeyValuePair.Create(6500.0, 0.0035),
            KeyValuePair.Create(7000.0, 0.0031),
            KeyValuePair.Create(7500.0, 0.0028),
            KeyValuePair.Create(8000.0, 0.0025),
            KeyValuePair.Create(8500.0, 0.0022),
            KeyValuePair.Create(9000.0, 0.0018),
            KeyValuePair.Create(10000.0, 0.0016)
        };

        public Vector Calc(double t, Vector vars)
        {
            if (vars.Size != order)
            {
                throw new Exception($"Ожидалось {order} переменных, получено {vars.Size}");
            }

            double x1 = vars.Get(0);
            double x2 = vars.Get(1);
            double x3 = vars.Get(2);

            double x1_res = x2;

            double r = 0;
            if (x1 < 0) r = 0.015;
            else if (x1 > 10000) r = 0.0016;
            else {
                for (int i = 0; i < interp.Count - 1; ++i) {
                    var first = interp[i];
                    var second = interp[i + 1];

                    double x_left = first.Key;
                    double x_right = second.Key;

                    double r_left = first.Value;
                    double r_right = second.Value;

                    if (x_left <= x1 && x1 <= x_right) {
                        r = r_left + (x1 - x_left) * ((r_right - r_left) / (x_right - x_left));
                        break;
                    }
                }
            }
            double x2_res = (c * u) / x3 - g - (r * x2 * x2) / x3;
            double x3_res = -u;

            return new Vector(new List<double>() { x1_res, x2_res, x3_res });
        }

        public int GetDeltaIndicatorIndex()
        {
            return 0;
        }

        public Vector GetInitialVariableVector()
        {
            return new Vector(new List<double>() { x1_start, x2_start, x3_start });
        }

        public int GetOrder()
        {
            return order;
        }

        public double GetT()
        {
            return T;
        }
    }
}
