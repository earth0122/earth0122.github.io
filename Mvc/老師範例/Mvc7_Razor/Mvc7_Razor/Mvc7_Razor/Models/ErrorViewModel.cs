namespace Mvc7_Razor.Models
{
    public class ErrorViewModel
    {
        #nullable enable
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}