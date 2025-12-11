namespace ProductClientHub.Exceptions.ExceptionBase
{
    public class ErrorOnValidationException : ProductClientHubException
    {
        private readonly List<string> errors;
        public ErrorOnValidationException(string errorMessage) : base(errorMessage)
        {

        }
    }
}
