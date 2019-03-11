using Medit.Services;
using System;

namespace Medit.Implementations
{
    /// <summary>
    /// Play Implementation
    /// 服务端负责Service的实现
    /// </summary>
    public class Piano : IPlayable
    {
        public bool Play()
        {
            Console.WriteLine("Play piano.");
            return true;
        }
    }
}
