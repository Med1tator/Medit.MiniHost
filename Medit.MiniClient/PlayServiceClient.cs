using Medit.Services;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Medit.MiniClient
{
    internal class PlayServiceClient : ClientBase<IPlayable>
    {
        public static EndpointAddress endpointAddress = new EndpointAddress(new Uri("net.pipe://localhost/play"));
        public static readonly Binding binding = new NetNamedPipeBinding();//服务绑定
        public PlayServiceClient()
            : base(binding, endpointAddress)
        { }

        public void Play()
        {
            Console.WriteLine(Channel.Play()
                ? "Play completely."
                : "Play not yet.");
        }
    }
}
