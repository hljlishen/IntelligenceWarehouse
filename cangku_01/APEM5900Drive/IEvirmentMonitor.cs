
namespace cangku_01
{
    public delegate void EvirmentDataHandler(double temperature, double humidity);
    interface IEvirmentMonitor
    {
        event EvirmentDataHandler NewDataReceived;

        void StopReading();

        void StartReading();
    }
}
