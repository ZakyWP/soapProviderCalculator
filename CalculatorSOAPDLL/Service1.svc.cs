using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Calculator;

namespace CalculatorSOAPDLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
   
        public double Add(double num1, double num2)
        {
            Calculate add = new Calculate();
            return add.Addition(num1, num2);
        }

        public double Subtract(double num1, double num2)
        {
            Calculate subtract = new Calculate();
            return subtract.Subtraction(num1, num2);
        }

        public double Multiply(double num1, double num2)
        {
        Calculate multiply = new Calculate();
            return multiply.Multiply(num1, num2);
        }

        public double Divide(double num1, double num2)
        {
        Calculate divide = new Calculate();
            return divide.Divide(num1, num2);
        }

        public double Add1(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
