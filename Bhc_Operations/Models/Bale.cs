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
        protected float CalculateGross(List<Bale>bales)
        {
            float gross = 0.0f;

            foreach (Bale bale in bales)
            {
                gross += bale.Mass * bale.Price;
            }
            return gross;
        }

        protected float CalculateTax1(List<Bale> bales)
        {
            float gross = CalculateGross(bales);
            return (float)(gross - (gross * 0.03f));
        }

        protected float CalculateTax2(List<Bale> bales)
        {
            return (float)(CalculateGross(bales) * 0.015f);
        }

        protected float CalcuateTax3(float qty)
        {
            return qty * 5.00f;
        }

        protected float CalculateDebt(Debt debt, float gross, float time )
        {
            return gross - debt.Amount - (debt.Amount *time* debt.InterestRate/100 )- (debt.Amount + debt.InterestRate*0.0005f);
        }

        protected Tuple<float,float> ProcessDebtItems(List<Debt> debt, float gross, float time)
        {
            float remainingGross = 0.00f;
            float totalComission = 0.00f;
            foreach (Debt item in debt)
            {
                for (item.Priority  = 0; item.Priority < debt.Count; item.Priority++)
                {
                    remainingGross += CalculateDebt(item,gross, time);
                    totalComission += item.Amount +item.InterestRate*0.0005f;
                }
            }
            return Tuple.Create(remainingGross, totalComission);
        }
        protected float CalculateRebate1(Debt debt, float gross, float time)
        {
            return CalculateDebt(debt, gross, time) + (0.05f * Mass);
        }

        protected float CalculateRebate2(Debt debt, float gross, float time )
        {
            return CalculateDebt(debt, gross, time) + (10.02f * Mass * Price);
        }


        #endregion
    }

    public class Program
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