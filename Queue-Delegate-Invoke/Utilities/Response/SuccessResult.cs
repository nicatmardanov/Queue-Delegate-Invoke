namespace Queue_Delegate_Invoke.Utilities.Response
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true, null)
        {
        }

        public SuccessResult(string? message) : base(true, message)
        {
        }
    }
}
