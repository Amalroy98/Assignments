using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{/*1.Create a class called furniture which has Data Members like
•	OrderId
•	OrderDate
•	FurnitureType
•	Qty
•	TotalAmt
•	PaymentMode (credit/debit card)
Furniture Type can be Chair/Cot
•	Derive the Chair and Cot class from Furniture class
If Chair Class then data members are
Chair type – Wood/Steel/Plastic
•	purpose – Home/office
•	If Wood Chair then Wood Type would be Teak Wood/Rose Wood
•	If Steel Chair then it would be Gray Steel/Green Steel/Brown Steel
•	If Plastic Color would be Green/Red/Blue/White
•	Rate
 
If Cot class then Data Members are
•	Cot Type – Wood / Steel
Same Data Members defined for Wood/Steel chair will be applicable for this.
•	Capacity – Single/Double
•	Rate
All the classes should have GetData() to accept user input and ShowData() to display the details .
Create  a Console Application to arrive at the Solution.
•	Hint : Implement the solution using Inheritance Concept.
 
*/
    public class Furniture
    {
        public int OrderId;
        public DateTime OrderDate;
        public string FurnitureType;
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;

        public virtual void GetData()
        {
            Console.WriteLine("Enter Order Id:");
            OrderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Order Date:");
            OrderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Furniture Type (Chair/Cot):");
            FurnitureType = Console.ReadLine();
            Console.WriteLine("Enter Quantity:");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Total Amount:");
            TotalAmt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Payment Mode (credit/debit card):");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate}");
            Console.WriteLine($"Furniture Type: {FurnitureType}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }
    }
    public class Chair : Furniture
    {
        public string ChairType;
        public string Purpose;
        public double Rate;
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic):");
            ChairType = Console.ReadLine();
            Console.WriteLine("Enter Purpose (Home/Office):");
            Purpose = Console.ReadLine();
            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDouble(Console.ReadLine());
        }
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Chair Type: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }
    class Cot : Furniture
    {
        public string CotType;
        public string Capacity;
        public double Rate;
        public override void GetData()
        {
            base.GetData();

            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            CotType = Console.ReadLine();
            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();
            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDouble(Console.ReadLine());
        }
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Cot Type: {CotType}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }
    class Furniture_main
    {
        static void Main()
        {
            Furniture furniture = null;

            Console.WriteLine("Enter Furniture Details:");
            Console.WriteLine("Choose Furniture Type (Chair/Cot):");
            string furnitureType = Console.ReadLine();

            if (furnitureType.ToLower() == "chair")
            {
                furniture = new Chair();
            }
            else if (furnitureType.ToLower() == "cot")
            {
                furniture = new Cot();
            }
            if (furniture != null)
            {
                furniture.GetData();
                Console.WriteLine("\nFurniture Details:");
                furniture.ShowData();
            }
            else
                Console.WriteLine("Invalid Details");
        }
    }

}