using cangku_01.entity;
using System;
using System.Windows.Forms;

namespace cangku_01
{
    class EvirmentDataRecorder
    {
        private Timer timer;
        bool shouldRecord = true;

        public EvirmentDataRecorder(IEvirmentMonitor monitor)
        {
            monitor.NewDataReceived += Monitor_NewDataReceived;
            timer = new Timer();
            timer.Interval = 300000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        //5分钟添加一条温湿度数据到数据库中
        private void Monitor_NewDataReceived(double temperature, double humidity)
        {
            if(shouldRecord)
            {
                TemperatureAndHumidity tempAndHum = new TemperatureAndHumidity();
                tempAndHum.tem_temperature = temperature;
                tempAndHum.tem_humidity = humidity;
                tempAndHum.tem_time = DateTime.Now;
                tempAndHum.Insert();
            }
            shouldRecord = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            shouldRecord = true;
        }
    }
}
