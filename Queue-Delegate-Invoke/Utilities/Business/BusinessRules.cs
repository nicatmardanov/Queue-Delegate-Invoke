using Queue_Delegate_Invoke.Utilities.Invoke;
using Queue_Delegate_Invoke.Utilities.Response;

namespace Queue_Delegate_Invoke.Utilities.Business
{
    public class BusinessRules
    {
        public IResult? Run(params IInvoke[] invokes)
        {
            foreach (IInvoke invoke in invokes)
            {
                IResult? result = (IResult)invoke.Run();
                if (result?.Success != true)
                    return result;
            }

            return null;
        }
    }
}
