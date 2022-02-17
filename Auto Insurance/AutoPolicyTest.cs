using System;

namespace Auto_Insurance
{
   class AutoPolicyTest
   {
      static void Main(string[] args)
      {
         //creat two AutoPolicy objects
         AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
         AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");

         //display wether each policy is in a no-fault state
         PolicyInNoFaultState(policy1);
         PolicyInNoFaultState(policy2);
      }

      //method that displays whether an AutoPolicy
      //is in a state with no-fault auto insurance
      public static void PolicyInNoFaultState(AutoPolicy policy)
      {
         Console.WriteLine("The auto policy");
         Console.WriteLine($"Account #: {policy.AccountNumber};");
         Console.WriteLine($"Car: {policy.MakeAndModel};");
         Console.WriteLine($"State {policy.state}; ");
         Console.WriteLine($"({(policy.IsNoFaultState ? "is": " is not ")})");
         Console.WriteLine("a no-fault state\n");
         
      }
   }
}
