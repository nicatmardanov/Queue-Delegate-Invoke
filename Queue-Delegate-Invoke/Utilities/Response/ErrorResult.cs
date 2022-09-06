namespace Queue_Delegate_Invoke.Utilities.Response
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false, null)
        {
        }

        public ErrorResult(string? message) : base(false, message)
        {
        }
    }
}
