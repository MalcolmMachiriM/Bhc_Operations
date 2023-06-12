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
        protected float CalculateGross(float quantity, float mass, float price)
        {
            float gross = mass * quantity * price;
            return gross;
        }

        protected float CalculateTax1(float quantity, float mass, float price)
        {
            float gross = CalculateGross(quantity, mass, price);
            return (float)(gross - (gross * 0.03));
        }

        protected float CalculateTax2(float quantity, float mass, float price)
        {
            return (float)(CalculateGross(quantity, mass, price) * 0.015);
        }
        #endregion
    }
}