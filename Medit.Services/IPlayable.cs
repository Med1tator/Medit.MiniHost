using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Medit.Services
{
    /// <summary>
    /// Play Service
    /// 该服务暴露给客户端，客户端只需要知道接口的方法便可
    /// Service需要使用ServiceContract修饰，暴露的方法需要用OperationContract修饰
    /// </summary>
    [ServiceContract]
    public interface IPlayable
    {
        [OperationContract]
        bool Play();
    }
}
