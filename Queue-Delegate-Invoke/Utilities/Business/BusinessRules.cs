using Queue_Delegate_Invoke.Utilities.Invoke;
using Queue_Delegate_Invoke.Utilities.Response;

namespace Queue_Delegate_Invoke.Utilities.Business
{
    public class BusinessRules
    {
        public async Task<IResult?> Run(params IInvoke[] invokes)
        {
            foreach (IInvoke invoke in invokes)
            {
                object invokeResult = invoke.Run();
                IResult? result;

                if (invokeResult.GetType().BaseType!.Name == "Task" || invokeResult.GetType().BaseType!.BaseType!.Name == "Task")
                    result = await (Task<IResult>)invokeResult;
                else
                    result = (IResult)invokeResult;

                if (result?.Success != true)
                    return result;
            }

            return null;
        }
    }
}
