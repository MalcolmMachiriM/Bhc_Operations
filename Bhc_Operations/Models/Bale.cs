using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhc_Operations.Models
{
    public class Bale
    {
        #region variables
        protected string mBarcode;
        protected string mGrade;
        protected string mGrowerNumber;
        protected float mPrice;
        protected float mMass;
        #endregion

        #region properties
        public string Barcode { get { return mBarcode; } set { mBarcode = value; } }
        public string Grade { get {  return mGrade; } set { mGrade = value; } }
        public float Price { get {  return mPrice; } set { mPrice = value; } }
        public float Mass { get { return mMass; } set { mMass = value; } }
        #endregion

        #region methods
        public static float CalculateGross(List<Bale>bales)
        {
            float gross = 0.0f;

            foreach (Bale bale in bales)
            {
                gross += bale.Mass * bale.Price;
            }
            return gross;
        }


        public static float CalcNetAfterTaxes(float gross)
        {
            float tax1 = 0.003f * gross;
            float tax2 = (0.015f * gross) + (0.02f * CalculateTotalMass(bales));
            float tax3 = 5 * bales.count;
            float net = gross - tax1 - tax2 - tax3;
            return net;
        }
        public static float CalculateTotalMass(List<Bale> bales)
        {
            float totalMass = 0;
            foreach (Bale bale in bales)
            {
                totalMass += bale.Mass;
            }
            return totalMass;
        }

        public static float CalculateDebtWithInterest(float debtAmount, float interestRate)
        {
            float interest = (debtAmount * interestRate) / 100;
            float debtWithInterest = debtAmount + interest;
            return debtWithInterest;
        }

        public static float CalculateCommission(float debtAmount)
        {
            float commission = 0.005f * debtAmount;
            return commission;
        }

        public static float ProcessDebts(List<Debt> debts)
        {
            float totalCommission = 0;
            foreach (Debt debt in debts)
            {
                float debtWithInterest = CalculateDebtWithInterest(debt.Amount, debt.InterestRate);
                float commission = CalculateCommission(debtWithInterest);
                totalCommission += commission;
            }
            return totalCommission;
        }

        public static float ApplyRebate(float gross, Rebate rebate)
        {
            float rebateAmount = rebate.flatAmount + (rebate.ratePerKg * CalculateTotalMass(bales));
            float net = gross - rebateAmount;
            return net;
        }
        public static void ProcessSale(List<Bale> bales, List<Debt> debts, List<Rebate> rebates)
        {
            float gross = CalculateGross(bales);
            Console.WriteLine("Gross Value: $" + gross);

            float netAfterTaxes = CalcNetAfterTaxes(gross);
            Console.WriteLine("Net Value After Taxes: $" + netAfterTaxes);

            float totalCommission = ProcessDebts(debts);
            Console.WriteLine("Total Commission: $" + totalCommission);

            foreach (Rebate rebate in rebates)
            {
                netAfterTaxes = ApplyRebate(netAfterTaxes, rebate);
            }
            Console.WriteLine("Net Proceeds Due to Grower: $" + netAfterTaxes);
        }

        public static void Main()
        {
            // Create a list of bales
            List<Bale> bales = new List<Bale>
        {
            new Bale { mGrowerNumber = "123456", Mass = 115, Price = 2.50f, Grade = "TMOS", Barcode = "110000011" },
            new Bale { mGrowerNumber = "123456", Mass = 85, Price = 4.50f, Grade = "TLOS", Barcode = "110000012" },
            new Bale { mGrowerNumber = "123456", Mass = 95, Price = 5.50f, Grade = "TLOS", Barcode = "110000013 "}
        };

            // Create a list of debts
            List<Debt> debts = new List<Debt>
        {
            new Debt { Amount = 1000, InterestRate = 5, Priority = 1 },
            new Debt { Amount = 500, InterestRate = 3, Priority = 2 }
        };

            // Create a list of rebates
            List<Rebate> rebates = new List<Rebate>
        {
            new Rebate { flatAmount = 50, ratePerKg = 0.02m },
            new Rebate { flatAmount = 20, ratePerKg = 0.01m }
        };

            ProcessSale(bales, debts, rebates);
        }


        #endregion
    }

    public class Calculations
    {
        public static void Main()
        {
            // Example usage
            List<Bale> bales = new List<Bale>
        {
            new Bale { Barcode = "110000013", Mass = 50, Grade = "TMOS", Price = 10 },
            new Bale { Barcode = "110000012", Mass = 40, Grade = "TMOS", Price = 12 },
            new Bale { Barcode = "110000011", Mass = 30, Grade = "TLOS", Price = 8 },
            new Bale { Barcode = "110000010", Mass = 50, Grade = "TLOS", Price = 10 },
            new Bale { Barcode = "110000014", Mass = 80, Grade = "TPOS", Price = 15 }
        };

            reworks(bales);
        }

        public static void reworks(List<Bale> bales)
        {
            List<Bale> mergedBales = new List<Bale>();
            List<Bale> rejectedBales = new List<Bale>();
            double totalMass = 0;
            double totalGross = 0;

            // Sort the bales by grade in ascending order
            bales = bales.OrderBy(bale => bale.Grade).ToList();

            foreach (Bale bale in bales)
            {
                if (totalMass + bale.Mass <= 120)
                {
                    // Check if there is a bale with the same grade to merge
                    Bale mergedBale = mergedBales.FirstOrDefault(m => m.Grade == bale.Grade);
                    if (mergedBale != null)
                    {
                        // Merge the bales
                        mergedBale.Mass += bale.Mass;
                        mergedBale.Barcode += "+" + bale.Barcode;
                        totalMass += bale.Mass;
                        totalGross += bale.Mass * bale.Price;
                    }
                    else
                    {
                        // Add the bale to the merged bales
                        mergedBales.Add(bale);
                        totalMass += bale.Mass;
                        totalGross += bale.Mass * bale.Price;
                    }
                }
                else
                {
                    // Add the bale to the rejected bales
                    rejectedBales.Add(bale);
                }
            }

            // Print the merged bales
            Console.WriteLine("Merged Bales:");
            foreach (Bale mergedBale in mergedBales)
            {
                Console.WriteLine($"Barcode: {mergedBale.Barcode}, Mass: {mergedBale.Mass}, Grade: {mergedBale.Grade}, Price: {mergedBale.Price}");
            }

            // Print the rejected bales
            Console.WriteLine("Rejected Bales:");
            foreach (Bale rejectedBale in rejectedBales)
            {
                Console.WriteLine($"Barcode: {rejectedBale.Barcode}, Mass: {rejectedBale.Mass}, Grade: {rejectedBale.Grade}, Price: {rejectedBale.Price}");
            }

            // Calculate and print the new average price for the merged bales
            double averagePrice = totalGross / totalMass;
            Console.WriteLine($"New Average Price: {averagePrice}");
        }
    }



}