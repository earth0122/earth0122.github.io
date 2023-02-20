namespace Mvc7_Boostrap_Clone.Models
{
    public class ErrorViewModel
    {
#nullable enable
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}