using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCO.Core.Base
{
    public class ResponseDto
    {
        public string SuccessMessage { get; set; }
        public int AutoIdentityKey { get; set; }

        public List<string> ErrorMessages { get; set; }

        public ResponseDto()
        {
            this.ErrorMessages = new List<string>();
        }

        public bool IsSuccess
        {
            get
            {
                return this.ErrorMessages == null || this.ErrorMessages.Count == 0;
            }
        }
    }

    public class ResponseDto<T> : ResponseDto where T : class, new()
    {
        public ResponseDto() : base()
        {
            this.Result = default(T);
        }

        public T Result { get; set; }
    }
}
