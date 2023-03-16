using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArtOfCleanCode.CommonCodeSmells
{
    //When you see switch statements based on types always remember polymorphism and replace switch with polymorphic dispatch
    //Use Push member down refactoring
    public class MonthlyStatement
    {
        public float CallCost { get; set; }
        public float SmsCost { get; set; }
        public float TotalCost { get; set; }
    }
    public class MonthlyUsage
    {
        public SwitchCustomer Customer { get; set; }
        public int CallMinutes { get; set; }
        public int SmsCount { get; set; }
    }

    public abstract class SwitchCustomer
    {

        public abstract MonthlyStatement GenerateStatement(MonthlyUsage monthly);
    }

    public class PayAsYouGoCustomer : SwitchCustomer
    { 
    
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var monthlyStatement = new MonthlyStatement();
            monthlyStatement.CallCost = 0.12f * monthlyUsage.CallMinutes;
            monthlyStatement.SmsCost = 0.12f * monthlyUsage.SmsCount;
            monthlyStatement.TotalCost = monthlyStatement.CallCost + monthlyStatement.SmsCost;

            return monthlyStatement;
        }
    }

    public class UnlimitedCustomer : SwitchCustomer
    {
       
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var monthlyStatement = new MonthlyStatement();
            monthlyStatement.TotalCost = 54.90f;
            return monthlyStatement;
        }
    }
}
