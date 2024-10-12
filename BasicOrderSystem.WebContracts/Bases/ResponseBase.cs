namespace BasicOrderSystem.WebContracts.Bases
{
    public class ResponseBase
    {
        public bool HasError { get; set; } = false;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}