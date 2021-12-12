using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApplication
{
    public class ObjectResponse<T> where T : class, new()
    {
        public ObjectResponse()
        {
            CorrelationId = Guid.NewGuid();
            Data = new T();
            OkResult = true;
        }

        public Guid CorrelationId { get; }
        public bool OkResult { get; set; }
        public T Data { get; set; }
    }

}
