using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace cangku_01
{
    class Apem5900 : IEvirmentMonitor
    {
        private Thread _readThread;
        private Socket _socket;
        public event EvirmentDataHandler NewDataReceived;

        public Apem5900()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 13001);
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Bind(ip);
        }

        void IEvirmentMonitor.StartReading()
        {
            _readThread = new Thread(Read);
            _readThread.IsBackground = true;
            _readThread.Start();
        }

        //读取数据
        private void Read()
        {
            while(true)
            {
                byte[] receiveData = new byte[100];
                _socket.Receive(receiveData);
                double temp = ((double)receiveData[12] * 256 + receiveData[13]) / 10;
                double humi = ((double)receiveData[14] * 256 + receiveData[15]) / 10;
                NewDataReceived?.Invoke(temp, humi);
            }
        }

        public void StopReading() => _readThread.Abort();
    }
}
