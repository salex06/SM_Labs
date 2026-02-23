using SM_LAB2.models;
using SM_LAB2.utils;


namespace SM_LAB2
{
    using RungeKuttaResult = List<KeyValuePair<double, Vector>>;
    public partial class Lab2 : Form
    {

        IModel model;
        List<IModel> availableModels = new List<IModel>() { 
            new Model1(), 
            new Model2(),
            new Model3(),
            new Model4()
        };

        public Lab2()
        {
            InitializeComponent();
            model = availableModels[0];
        }

        private void firstModelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (firstModelRadio.Checked)
            {
                model = availableModels[0];
            }
        }

        private void secondModelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (secondModelRadio.Checked)
            {
                model = availableModels[1];
            }
        }

        private void thirdModelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (thirdModelRadio.Checked)
            {
                model = availableModels[2];
            }
        }

        private void fourthModelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fourthModelRadio.Checked)
            {
                model = availableModels[3];
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (model == null) model = availableModels[0];
            double h = (double)stepSizeInput.Value;
            var res = CalcWithDelta(h);

            RungeKuttaResult rungeKuttaResult = res.Key;
            double delta = res.Value;
            if (customStepCheckBox.Checked)
            {
                while (delta > 1)
                {
                    h = h / 2;
                    res = CalcWithDelta(h);
                    rungeKuttaResult = res.Key;
                    delta = res.Value;
                }
            }

            ResultVisualisation rf = new(rungeKuttaResult, Math.Round(delta, 2));
            rf.ShowDialog(this);
        }

        private KeyValuePair<RungeKuttaResult, double> CalcWithDelta(double h)
        {
            var res = CalcRungeKutta(h);

            double y0 = res[res.Count - 1].Value.Get(model.GetDeltaIndicatorIndex());

            double enhanced_h = h / 2;
            var res2 = CalcRungeKutta(enhanced_h);
            double enhanced_y0 = res2[res2.Count - 1].Value.Get(model.GetDeltaIndicatorIndex());

            double delta = Math.Abs((enhanced_y0 - y0) / y0) * 100;

            return KeyValuePair.Create(res, delta);
        }

        private RungeKuttaResult CalcRungeKutta(double h)
        {
            RungeKuttaResult res = new();

            double t_start = 0;
            double t_end = model.GetT();

            double curr_t = t_start;
            Vector Y = model.GetInitialVariableVector();

            while (curr_t < t_end)
            {
                Vector K1 = model.Calc(curr_t, Y);

                Vector Y_test = Y + K1 * (h / 2);
                double t_mid = curr_t + h / 2;

                Vector K2 = model.Calc(t_mid, Y_test);

                Y_test = Y + K2 * (h / 2);
                Vector K3 = model.Calc(t_mid, Y_test);

                Y_test = Y + K3 * h;
                double t_end_step = curr_t + h;
                Vector K4 = model.Calc(t_mid, Y_test);

                Vector deltaY = (K1 + K2 * 2 + K3 * 2 + K4) * (h / 6);

                Y = Y + deltaY;
                curr_t = curr_t + h;

                res.Add(KeyValuePair.Create(curr_t, Y));
            }

            return res;
        }
    }
}
