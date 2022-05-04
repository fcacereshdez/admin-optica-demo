using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ClientAccount
    {
        public static Int64 id_client_account;
        public static Int64 invoice_id;
        public static decimal balance;
        public static DateTime last_payment;
        public static decimal accumulated;
        public static int n_payments;
        public static decimal fee;
        public static string client_name;
        public static string client_lastname;
        public static int invoice_number;
        public static DateTime invoice_date;
        public static decimal invoice_total;
        public static string company_name;
    }
}
