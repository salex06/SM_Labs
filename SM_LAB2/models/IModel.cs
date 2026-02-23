using SM_LAB2.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_LAB2.models
{
    interface IModel
    {
        Vector Calc(double t, Vector vars);

        double GetT();

        Vector GetInitialVariableVector();

        int GetOrder();

        int GetDeltaIndicatorIndex();
    }
}
