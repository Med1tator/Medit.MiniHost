using Medit.Implementations;
using Medit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Medit.MiniHost
{
    internal class PlayServiceHost: IDisposable
    {
        private ServiceHost serviceHost;
        public const string baseAddress = "net.pipe://localhost";
        public const string serviceAddress = "play";
        public static readonly Type serviceType = typeof(Piano);//服务契约实现类型
        public static readonly Type contractType = typeof(IPlayable);//服务契约接口
        public static readonly Binding binding = new NetNamedPipeBinding();//服务绑定

        public PlayServiceHost()
        {
            CreateHost();
        }

        protected void CreateHost()
        {
            serviceHost = new ServiceHost(serviceType, new Uri[] { new Uri(baseAddress) });
            serviceHost.AddServiceEndpoint(contractType, binding, serviceAddress);
        }
        public void OpenService()
        {
            Console.WriteLine("PlayService Started...");
            serviceHost.Open();
            Console.WriteLine("PlayService Running...");
        }

        public void Dispose()
        {
            if (serviceHost != null)
            {
                (serviceHost as IDisposable).Dispose();
            }
        }
    }
}
