using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

//指纹设备连接 --饿汉式

namespace cangku_01.FingerprintDrive
{
    class ConnectFingerprint
    {
        
        private static ConnectFingerprint connectFingerprint = new ConnectFingerprint();

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//连接状态
        private int iMachineNumber = 1;//设备连接的序列号
        Employee em = new Employee();
        List<IDataDisplayer> displayers;

        private ConnectFingerprint() {
            displayers = new List<IDataDisplayer>();
        }

        public void AddDisplayer(IDataDisplayer displayer)
        {
            if (displayers.Contains(displayer)) return;

            displayers.Add(displayer);
        }

        public static ConnectFingerprint GetInstance()
        {
            return connectFingerprint;
        }

        //TCP\IP连接
        public void GetIPConnect()
        {
            bIsConnected = axCZKEM1.Connect_Net("192.168.1.201", 4370);//连接属性IP、端口号
            if (bIsConnected == true)
            {
                iMachineNumber = 1;
                axCZKEM1.RegEvent(iMachineNumber, 65535);
                if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                {
                    axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                }
            }
            else
            {
                MessageBox.Show("无法连接到指纹设备", "错误");
            }
        }

        #region RealTime Events
        //获取信息
        private void axCZKEM1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode)
        {
            Fingerprint fingerprint = new Fingerprint(DbLinkManager.GetLinkFactory());
            fingerprint.fi_employeenumber = sEnrollNumber;
            string passtime = iYear.ToString() + "-" + iMonth.ToString() + "-" + iDay.ToString() + " " + iHour.ToString() + ":" + iMinute.ToString() + ":" + iSecond.ToString();
            fingerprint.fi_passtime = Convert.ToDateTime(passtime);
            Employee employee = new Employee();
            employee.EmployeeNumber = sEnrollNumber;
            DataTable datatable = employee.EmployeeNumberFindEmployee();
            DataRow myDr = datatable.Rows[0];
            fingerprint.fi_name = myDr["em_name"].ToString();
            fingerprint.Insert();
            foreach (var From1 in displayers)
                From1.FingerprintUpdate(fingerprint);
        }
        #endregion

        //关闭连接
        public void CloseConnect()
        {
            axCZKEM1.Disconnect();
            bIsConnected = false;
        }

    }
}
