namespace vendor_store_web_api.Dtos
{
    public class ServiceResponse
    {
        public int Status { get; set; }
        public string StatusMessage { get; set; }
    }

    public class ServiceResponse<T>:ServiceResponse
    {
        public T Payload { get; set; }
    }
}
