using cangku_01.entity;
using cangku_01.UHFReader09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.UHFReader09CSharp
{
    public delegate void TagConnectedHandler(string tagId);

    public interface UHFReader09Interface
    {
        void OpenConnectReader();

        void CloseConnectReader();

        string StartRead();

        event TagConnectedHandler TagConnected;
    }
}
