using System.Dynamic;
using System.Net;

namespace IntegracaoBrasilAPI.DTOs
{
    public class GenericResponse<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T? ResponseData { get; set; }
        public ExpandoObject? ResponseError { get; set; }
    }
}
