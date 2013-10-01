using System;
using System.ServiceModel;
using System.Text;

namespace CustomUsernamePasswordAuth.Service
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CalculatorDuplex : ICalculatorDuplex
    {

        // ++++++++++++++++++++++O+++++++++++++++++++++
        ICalculatorDuplexCallback Callback = OperationContext.Current.GetCallbackChannel<ICalculatorDuplexCallback>();
        double result = 0;
        string equation;
        public void AddTo(double n)
        {
            result += n;
            equation += " + " + n.ToString();
            Callback.NotifyEquals(result);
        }
    }
}
