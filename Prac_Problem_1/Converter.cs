using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Problem_1
{
    class Converter
    {
        //Properties
        private double pMoney;

        private Double ppMoney;
        private double ppCurrency;
        private String pCurrency1;
        private String pCurrency2;

        //constructor
        public Converter(double aMoney,String aCurrency1, String aCurrency2)
        {
            pMoney = aMoney;
            pCurrency1 = aCurrency1;
            pCurrency2 = aCurrency2;
        }

        //Method
        public double GetConversion()
        {
            double dRate = 0;
            if (pCurrency1 == "ZAR")
            {
                switch (pCurrency2)
                {
                    case "USD":
                        dRate = 0.66; 
                        break;

                    case "EUR":
                        dRate = 0.60;
                        break;
                }
            }
            else if (pCurrency1 == "USD")
            {
                switch (pCurrency2)
                {
                    case "ZAR":
                        dRate = 15.11;
                        break;

                    case "EUR":
                        dRate = 0.91;
                        break;
                }
            }
            else {
                switch (pCurrency2)
                {
                    case "ZAR":
                        dRate = 16.54;
                        break;

                    case "USD":
                        dRate = 1.09;
                        break;
                }
            }
            return (pMoney* dRate);
        }

        //Method
        public String getAmount()
        {
            String sAmount = null; 
            switch (pCurrency2)
            {
                case "ZAR":
                    sAmount = GetConversion().ToString("C",CultureInfo.CreateSpecificCulture("en-ZA"));
                    break;
                case "USD":
                    sAmount = GetConversion().ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    break;
                case "EUR":
                    sAmount = GetConversion().ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                    break;
            }
            return sAmount;
        }
    }
}
