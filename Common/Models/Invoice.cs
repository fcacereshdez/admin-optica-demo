using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   public class Invoice
    {
        public static Int64 id_invoice;
        public static DateTime date;
        //public static int number_invoice;
        //public static Int64 client_id;
        public static string client_name;
        public static Int64 payment_method;
        public static int recurrence;
        public static string first_pay_day;
        public static string secondary_pay_day;
        public static int n_payments;
        public static decimal fee;
        public static string optometrist;
        public static Int64 optometrist_id;
        public static string consultant;
        public static Int64 consultant_id;
        public static string manager;
        public static Int64 manager_id;
        public static decimal subtotal;
        public static decimal discount;
        public static decimal total;
        public static string notes;
    }
}
