namespace Search.Models
{
    public class SearchResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public dynamic Result { get; set; }
    }
}
