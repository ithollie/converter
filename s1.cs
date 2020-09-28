using System;
using System.Diagnostics;

namespace converter
{
    internal class s1
    {
        private double answer;
        private double weightOnEarth;
        private double weightOnMars;
        private double temp;

        private String result1;
        private String result2;

        public s1(String weightOnEarth, String weightOnMars)
        {

            this.result1 = weightOnEarth;
            this.result2 = weightOnMars;
            this.weightOnEarth = double.Parse(weightOnEarth);
            this.weightOnMars =  double.Parse(weightOnMars);
            
            this.temp = 0;


        }
        public bool checkNumber()
        {
            Boolean condition = true; 
            int temp = 0;
            bool res1 = int.TryParse(result1,out temp);
            bool res2 = int.TryParse(result2, out temp);

            if (res1 == false  && res2 == false)
            {
                condition = false;
            }
            return condition;
        }
        // function  that return  weight on earth.
        public double earthWeightfun()
        {
            return weightOnEarth;
        }
        // function that  return  weight on mars
        public double weightOnMarsfun()
        {
            return weightOnMars;
        }
        //function  that has  the formula and  return a   result.
        public double calcuate()
        {
            //try catch
            try
            {
                double value = (this.weightOnEarth / 9.81) * 3.711;
                temp += value;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught", e);
            }
            finally
            {
                Console.WriteLine("Result:", temp);
            }

            return temp;
          
        }
        
    }
}