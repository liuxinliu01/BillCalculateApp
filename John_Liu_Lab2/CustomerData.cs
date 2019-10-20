using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerClass
{
    public class Customer
    {
        public int AccountNo    //client account number; unique identifying number(SKU)
        {
            get
            {
                return accountNo;
            }
            

        }
       
        public string CustomerName  //client account name;
        {
            get                                 //return shadow property
            {
                return customerName;
            }
           
        }

        public string CustomerType   //customer Type
        {
            get
            {
                return customerType;
            }
        }

        public double ChargeAmount;    //charge amount;
        

        public int UsedHoursAmount
        {
            get
            {
                return usedHoursAmount;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalide value in numberic field.");
                }
            }
        }
        public int OffPeakHoursAmount
        {
            get
            {
                return offPeakHoursAmount;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalide value in numberic field.");
                }
            }
        }


        //private shadow properties
        private int accountNo;
        private string customerName;
        private string customerType;
        private double chargeAmount;
        private int usedHoursAmount;
        private int offPeakHoursAmount;

        //Constructors
        public Customer(int id, string name, string type, int hours)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid account number.");
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Name can not be blank.");
            }

            if (hours <= 0)
            {
                throw new ArgumentException("Invalid value in numberic field.");
            }

            accountNo = id;
            customerName = name;
            customerType = type;
            usedHoursAmount = hours;
        }
        public Customer(int id, string name, string type, int hours, int offPeak)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid account number.");
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Name can not be blank.");
            }

            if (hours <= 0)
            {
                throw new ArgumentException("Invalid value in numberic field.");
            }
            if (offPeak <= 0)
            {
                throw new ArgumentException("Invalid value in numberic field.");
            }

            accountNo = id;
            customerName = name;
            customerType = type;
            usedHoursAmount = hours;
            offPeakHoursAmount = offPeak;
            
        }


        public virtual double CalculateCharge()
        {
            //calculate the bill based on the type of customer and kwh used.
            if (CustomerType == "C") //formulation for commercial
            {

                if (UsedHoursAmount <= 1000)  //if hours less than 1000, the bill will be the base price 60.00.
                {
                    chargeAmount = 60.00;
                }
                else
                {
                    chargeAmount = 60.00 + (UsedHoursAmount - 1000) * 0.045; // if hours greater than 1000, calculate cost by excess hours and base price.
                }
                ChargeAmount = chargeAmount;
                return ChargeAmount;
            }
            if (CustomerType == "R") //formulation for Residential
            {
                chargeAmount = 6.00 + UsedHoursAmount * 0.052;
                ChargeAmount = chargeAmount;
                return ChargeAmount;
                
            }
            else if (customerType == "I") //formulation for Industrial
            {
                double peakTotal;
                double offPeakTotal;
                if (UsedHoursAmount <= 1000)
                {
                    peakTotal = 76.00;
                }
                else
                {
                    peakTotal = 76.00 + (UsedHoursAmount - 1000) * 0.065;
                }

                if (OffPeakHoursAmount <= 1000)
                {
                    offPeakTotal = 40.00;
                }
                else
                {
                    offPeakTotal = 40 + (OffPeakHoursAmount - 1000) * 0.028;
                }
                chargeAmount = peakTotal + offPeakTotal;
                ChargeAmount = chargeAmount;

                return ChargeAmount;
            }
            else
            {
                throw new AggregateException("Unable to calculate bill with undefined customer type.");
            }
        }
        public Customer(string fromFile)
        {
            //convert strings to list can be used to add new value for CustomerList.
            char[] delimiters = { '|', ',' };
            string[] tokens = fromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            accountNo = int.Parse(tokens[0].Trim());
            customerName = tokens[1].Trim();
            customerType = tokens[2].Trim();
            usedHoursAmount = int.Parse(tokens[3].Trim());
            if (customerType == "I")
            {
                offPeakHoursAmount = int.Parse(tokens[4].Trim());
            }
            
        }
        public virtual string ToFileString()
        {
            //add a special mark between each value.
            //No charge amount added into the file.
            string theString = "";
            if (customerType == "I")
            {
                theString += $"{accountNo}|";
                theString += $"{customerName}|";
                theString += $"{customerType}|";
                theString += $"{usedHoursAmount}|";
                theString += $"{offPeakHoursAmount}";
            }
            else
            {
                theString += $"{accountNo}|";
                theString += $"{customerName}|";
                theString += $"{customerType}|";
                theString += $"{usedHoursAmount}";
            }
            return theString;
        }
        public virtual string ToFormattedString() //virtual means this is a base one, can be override by others.
        {
            string theString = "";
            if (customerType == "I")
            {
                theString += $"{customerName,-20}";
                theString += $"{accountNo,10}";
                theString += $"{customerType,8}";
                theString += $"{usedHoursAmount,8}";
                theString += $"{offPeakHoursAmount,8}";
                theString += $"{ChargeAmount,20:c2}";
            }
            else
            {
                theString += $"{customerName,-20}";
                theString += $"{accountNo,10}";
                theString += $"{customerType,8}";
                theString += $"{usedHoursAmount,8}";
                theString += $"{ChargeAmount,20:c2}";
            }
            return theString;
        }
        public override string ToString()
        {
            if (customerType == "I")
            {
                return $"Customer Name:'{customerName}', Account No.: {accountNo}, Customer Type: {customerType}, Used kwh in Peak: {usedHoursAmount}, used kwh off Peak: {offPeakHoursAmount}, Charge Amount: {ChargeAmount}";
            }
            else
            {
                return $"Customer Name:'{customerName}', Account No.: {accountNo}, Customer Type: {customerType}, Used kwh in Peak: {usedHoursAmount}, Charge Amount: {ChargeAmount}";

            }

        }
        private bool validateCustomerName(string name)
        {
            //validate customer name
            if (!((name != null) && (name.Length > 0)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool validateAccountNo(int ID)
        {
            //validate accountNo
            if (!((ID >= 100000) && (ID <= 99999999)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool validateKwh(int hours)
        {
            //validate kwh hours.
            if (!(hours > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
