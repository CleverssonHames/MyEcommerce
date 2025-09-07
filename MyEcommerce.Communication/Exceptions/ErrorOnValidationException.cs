namespace MyEcommerce.Communication.Exceptions
{
    public class ErrorOnValidationException : MyEcommerceException
    {
        public IList<string> ErrorMessages { get; set; }

        public ErrorOnValidationException(IList<string> errorMessages) : base(string.Empty)
        {
            ErrorMessages = errorMessages;
        }
    }
}
