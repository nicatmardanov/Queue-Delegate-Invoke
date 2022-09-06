namespace Queue_Delegate_Invoke.Utilities.Response
{
    public interface IResult
    {
        bool Success { get; }
        string? Message { get; }
    }
}
