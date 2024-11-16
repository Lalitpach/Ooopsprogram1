using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    public class Paymentcs
    {
        public static string PayBill(double amt)
        {
            return $"Amount paid = {amt} by cash";
        }

        public static string PayBill(double amt, string mode)
        {
            return $"Amount  paid = {amt - (amt * 0.15)} by {mode}";
        }

    }
}
