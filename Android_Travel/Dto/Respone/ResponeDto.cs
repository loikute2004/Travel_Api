namespace Android_Travel.Dto.Respone
{
    public class ResponeDto<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
        public Boolean Success { get; set; }
    }
}
