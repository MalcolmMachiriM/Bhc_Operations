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
        public string palleteNumber { get { return mpalleteNumber; } set { mpalleteNumber = value; } }
        public List<Bale> bales { get { return mbales; } set { mbales = value; } }
        public string warehouse { get { return warehouse; } set { warehouse = value; } }
        public string grade { get { return grade; } set { grade = value; } }
        #endregion
    }
    public class Warehouse
    {
        private List<Pallete> pallets;

        public Warehouse()
        {
            pallets = new List<Pallete>();
        }

        public List<Bale> loadPallet(List<Bale> bales)
        {
            List<Bale> addedBales = new List<Bale>();
            Pallete currentPallet = null;

            foreach (Bale bale in bales)
            {
                if (currentPallet == null || currentPallet.bales.Count == 25)
                {
                    currentPallet = createNewPallet();
                    pallets.Add(currentPallet);
                }

                if (isBaleAllowed(bale))
                {
                    currentPallet.bales.Add(bale);
                    addedBales.Add(bale);
                }
            }

            return addedBales;
        }

        private Pallete createNewPallet()
        {
            int palletNumber = generateUniquePalletNumber();
            return new Pallete { palleteNumber = palletNumber.ToString(), bales = new List<Bale>() };
        }

        private int generateUniquePalletNumber()
        {
            Random random = new Random();
            int palletNumber = random.Next(10000, 99999);
            while (pallets.Exists(p => p.palleteNumber == palletNumber.ToString()))
            {
                palletNumber = random.Next(10000, 99999);
            }
            return palletNumber;
        }

        private bool isBaleAllowed(Bale bale)
        {
            //  checking if the bale grade meets the reqrmts
           
            if (bale.Grade == "TMOS" || bale.Grade == "TLOS" || bale.Grade == "TXLF")
            {
                return true;
            }

            return false;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Bale> bales = new List<Bale>
        {
            new Bale { Barcode = "110000010", Grade = "TMOS", Price = 4.50f, Mass = 120 },
            new Bale { Barcode = "110000011", Grade = "TLOS", Price = 5.50f, Mass = 110 },
            new Bale { Barcode = "110000012", Grade = "TXLF", Price = 350f, Mass = 130 },
            new Bale { Barcode = "110000013", Grade = "TMOX", Price = 0.50f, Mass = 90 },
            new Bale { Barcode = "110000014", Grade = "TM1L", Price = 1.50f, Mass = 80 }
        };

            Warehouse warehouse = new Warehouse();
            List<Bale> addedBales = warehouse.loadPallet(bales);

            Console.WriteLine("Added bales:");
            foreach (Bale bale in addedBales)
            {
                Console.WriteLine($"Barcode: {bale.Barcode}, Grade: {bale.Grade}, Price: {bale.Price}, Mass: {bale.Mass}");
            }
        }
    }
}