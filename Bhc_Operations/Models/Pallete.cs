using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhc_Operations.Models
{
    public class Pallete
    {
        #region variables
        protected string mpalleteNumber;
        protected List<Bale> mbales;
        protected string mwarehouse;
        protected List<string> mgrade;
        #endregion

        #region properties
        public string palleteNumber { get { return mpalleteNumber; } set {  mpalleteNumber = value; } }
        public List<Bale> bales { get { return mbales; } set {  mbales = value; } }
        public string warehouse { get { return warehouse; } set {  warehouse = value; } }
        public string grade { get {  return grade; } set {  grade = value; } }
        #endregion
    }
}