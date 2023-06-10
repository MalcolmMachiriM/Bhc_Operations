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
    }
}