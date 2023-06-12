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

    
}