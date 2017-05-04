using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices.Contracts
{
    [ServiceContract(Name = "CalculatorService", Namespace = "http://www.cnblogs.com/artech/archive/2007/02/26/656901.html")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);

        [OperationContract]
        double Subtract(double x, double y);

        [OperationContract]
        double Multiply(double x, double y);

        [OperationContract]
        double Divide(double x, double y);
    }
}