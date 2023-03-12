using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Firm
{
    public class Commission : Hourly
    {
        private double totalSalesMade;
        private double _commissionRateInPrc;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,double commissionRateInPrc) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            this._commissionRateInPrc = commissionRateInPrc;
        }
        public void addSales(double totalSales)
        {
            totalSalesMade+= totalSales;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales : " + totalSalesMade;
            return result;
        }
        public override double Pay()
        {
            var payment = base.Pay();

            payment += payment * _commissionRateInPrc;
            
            return payment;
        }


    }
}
