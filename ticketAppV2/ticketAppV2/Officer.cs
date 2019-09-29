/*
 * Note to self:
 *  When doing a lamda expression from a delegate this will be the format:
 *  [delegate object] = [variable in function] => Expression result to store in variable
 *      finecalc f    =     doubleResult       => 100 + dollarAddAmount
 *      
 *      
 *      
 * Need to create an overloaded function in order to make delegate take function
 * in a way needed to calculate in the middle of the return statement.
 * 
 * Need to fix the lamda boolean expression. For some reason I can't get the result properly to 
 * say true or false despite how ive written it previously. 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketAppV2
{
    class Officer : IRoadPatroler
    {
        double detectedSpeed;
        double enforcedSpeed;
        

        public double DetectedSpeed { set { detectedSpeed = value; } }
        public double EnforedSpeed { set { enforcedSpeed = value; } }

        delegate double fineCalc(double fast, double fastLimit);
        delegate bool feeThreshold(double fee);

        public Officer()
        {

        }

        //interface function
        public double fine()
        {
            return (enforcedSpeed <= detectedSpeed) ? (detectedSpeed - enforcedSpeed) * 20 : 0;
        }
        
        public double fine(double seenSpeed, double speedlimit)
        {
            
            return (speedlimit <= seenSpeed) ? (seenSpeed - enforcedSpeed) * 20 : 0;
        }

        //delegate expression result
        public string DelegateResult()
        {
            fineCalc someFineCalc = fine; //needs an overloaded function of this

            return $"Fine is delegate\n{someFineCalc(detectedSpeed, enforcedSpeed):C}";


        }

        //lamda expression result
        public string LamdaResult()
        {
            fineCalc f = (detectedSpeed, enforcedSpeed) => (detectedSpeed - enforcedSpeed) * 20;

            return $"Fine is lamda expression\n{f:C}";
        }

        //lamda boolean result
        public string LamdaBoolResult()
        {
            double fee = (enforcedSpeed - detectedSpeed) * 20;
            feeThreshold boolfee = ans => (fee > 200);


            return "";

        }

        //string manipulation id portion
        public string validateID(string id)
        {
            string result;

            var idValidation = (id.Length == 5 && id.Substring(2, 1) == "5" && id.Substring(3, 1) == "5");

            return result = (!idValidation) ? "Invalid ID" : "Valid ID";
        }

        public string fineMessage()
        {
            return $"Fee is using interface! {fine():C}";
        }

    }
}
