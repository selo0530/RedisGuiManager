using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisGuiManager
{
    public class OperateResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public OperateResult(bool is_success, string message)
        {
            IsSuccess = is_success;
            Message = message;
        }
    }
}
