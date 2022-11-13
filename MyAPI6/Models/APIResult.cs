namespace MyAPI6.Models
{
    public class APIResult
    {
        public bool Status { get; set; }
        public string ErrorMsg { get; set; }
        public object Data { get; set; }
    }
}