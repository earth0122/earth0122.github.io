namespace CoreMvc3_App02_1.Models
{
    //���\�a�J�Ѽƥi��null ,���ΦA�[?
    #nullable enable
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}