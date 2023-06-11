using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FlightApp
{
    public class Entities
    {
        private DateTime flightDate;

        public DateTime FlightDate
        {
            get { return flightDate; }
            set
            {
                flightDate = value;
            }
        }
        private DateTime returnDate;
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set
            {
                if (FlightDate >= value)
                {
                    throw new Exception("تاریخ برگشت نباید از تاریخ رفت عقب تر باشد");
                }
                returnDate = value;
            }
        }
        private decimal infantCount;
        private decimal childCount;
        private decimal adultCount;
        public decimal ChildCount
        {
            get { return childCount; }
            set { childCount = value; }
        }

        public decimal AdultCount
        {
            get { return adultCount; }
            set
            {
                adultCount = value;
            }
        }

        public decimal InfantCount
        {

            get { return infantCount; }
            set
            {
                if (value > adultCount)
                {
                    throw new Exception("تعداد شیرخوار نباید از تعداد بزرگسال بیشتر باشد");
                }
                else if (value + childCount + adultCount > 9)
                {
                    throw new Exception("تعداد مسافر نباید بزرگتر از 9 باشد");
                }


                infantCount = value;
            }
        }

        private string origin;
        public string Origin
        {
            get { return origin; }
            set
            {
                if (value.Length != 3)
                    throw new Exception("ورودی مبدا باید برابر 3 کاراکتر باشد");

                else if (value == "TLV")
                    throw new Exception("مبدا نمی تواند تلاویو باشد");

                origin = value;
            }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set
            {
                if (value.Length != 3)
                    throw new Exception("ورودی مقصد باید برابر 3 کاراکتر باشد");

                else if (value == "TLV")
                    throw new Exception("مقصد نمی تواند تلاویو باشد");

                destination = value;
            }
        }


    }
}

