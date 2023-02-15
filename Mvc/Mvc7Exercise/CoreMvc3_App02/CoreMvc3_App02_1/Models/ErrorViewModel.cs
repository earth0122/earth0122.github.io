namespace CoreMvc3_App02_1.Models
{
    //允許帶入參數可為null ,不用再加?
    #nullable enable
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}