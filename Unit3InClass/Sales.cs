using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3InClass
{
    class Sales
    {
        DateTime saleTime;
        float amount;

        public Sales(DateTime saleTime, float amount)
        {
            this.saleTime = saleTime;
            this.amount = amount;
        }

        public DateTime SaleTime { get => saleTime; set => saleTime = value; }
        public float Amount { get => amount; set => amount = value; }
    }
}
