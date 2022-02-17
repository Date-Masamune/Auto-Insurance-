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
       public string State; // two-letter state abbreviation

      //constructor
      public AutoPolicy(int accountNumber, string makeAndModel, string state)
      {
         AccountNumber = accountNumber;
         MakeAndModel = makeAndModel;
         State = state;
      }

      public string state
      {
         get
         {
            return State;
         }

         set
         {
            if()
            {

            }

            else
            {

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
            switch (State) // get AutoPolicy object's state abbreviation
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
