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
        //连接读写器
        void OpenConnectReader();

        //关闭读写器
        void CloseConnectReader();

        //开始读取卡片TagId
        string StartReadTagId();

        //卡片信息写入
        void WriteCardInformation(string writedatas);

        event TagConnectedHandler TagConnected;
    }
}
