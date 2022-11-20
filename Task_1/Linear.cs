using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct Linear
    {
        double k;
        double b;

        public Linear(double k1, double b1)
        {
            this.k = k1;
            this.b = b1;
        }
        public string Root()
        {
            if (k == 0 && b == 0)
                return "Решений бесконечно много";
            else if (k == 0)
                return "Решений нет";
            else return $"Решение уравнения: {-b/k}";
        }

    }
}
