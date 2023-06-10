using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhc_Operations.Models
{
    public class Debt
    {
        #region variables
        protected int mPriority;
        protected float mAmount;
        protected float mInterestRate;
        #endregion

        #region properties
        public int Priority { get { return mPriority; } set {  mPriority = value; } }
        public float Amount { get {  return mAmount; } set { mAmount = value; } }
        public float InterestRate { get {  return mInterestRate; } set { mInterestRate = value; } }
        #endregion
    }
}