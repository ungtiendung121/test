using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


namespace CustomUsernamePasswordAuth.Service
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICalculatorDuplexCallback))]

    public interface ICalculatorDuplex
    {
        [OperationContract(IsOneWay = true)]
        void AddTo(double n);



    }


    public interface ICalculatorDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotifyEquals(double result);
        [OperationContract(IsOneWay = true)]
        void NotifyEquation(string eqn);
    }

}