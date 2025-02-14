namespace Mango.Web.Models.Dto
{
    public class RequestDto
    {
        public string ApiType { get; set; } = "Get";

        public string Url { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
