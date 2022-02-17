using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Insurance
{
   class AutoPolicy
   {
      public int AccountNumber { get; set; } //policy account number
      public string MakeAndModel { get; set; } //car that policy applies to
      public string state; // two-letter state abbreviation

      //constructor
      public AutoPolicy(int accountNumber, string makeAndModel, string State)
      {
         AccountNumber = accountNumber;
         MakeAndModel = makeAndModel;
         state = State;
      }

      public string State
      {
         get
         {
            return state;
         }

         set
         {
            if(value == "CT" || value == "MA" || value == "ME" || value == "NH" || value == "NJ" || value == "NY" || value == "PA" || value == "VT")
            {
               state = value;
            }

            else
            {
               Console.WriteLine("This is not not a state");
            }

         }
      }




      // returns whether the state had no-fault insurance
      public bool IsNoFaultState
      {

         get
         {
            bool noFaultState;

            //determine whether state has no-fault auto insurance
            switch (state) // get AutoPolicy object's state abbreviation
            {
               case "CT": 
               case "MA":
               case "ME":
               case "NH": 
               case "NJ": 
               case "NY": 
               case "PA":
               case "VT":
                  noFaultState = true;
                  break;
               default:
                  noFaultState = false;
                  break;
            }

            return noFaultState;
         }

      }
      

   }
}
