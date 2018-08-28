using cangku_01.entity;
using cangku_01.interfaceImp;
using cangku_01.interfaces;
using cangku_01.view.WarehouseManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//指纹设备连接 --饿汉式

namespace cangku_01.GateDrive
{
    class ConnectFingerprint
    {
        
        private static ConnectFingerprint connectFingerprint = new ConnectFingerprint();

       // public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected = false;//连接状态
        private int iMachineNumber = 1;//设备连接的序列号
        Employee em = new Employee();
        Form1 fr;

        private ConnectFingerprint() {

        }

        public static ConnectFingerprint GetInstance()
        {
            return connectFingerprint;
        }

        //TCP\IP连接
        public void GetIPConnect()
        {   
            //bIsConnected = axCZKEM1.Connect_Net("192.168.1.201", 4370);//连接属性IP、端口号
            //if (bIsConnected == true)
            //{
            //    iMachineNumber = 1;
            //    axCZKEM1.RegEvent(iMachineNumber, 65535);
            //    if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            //    {
            //        axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("无法连接到指纹设备" , "错误");
            //}
        }

        #region RealTime Events
        //获取信息
        private void axCZKEM1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode)
        {
            
            em.EmployeeNumber = sEnrollNumber;
            string passtime = iYear.ToString() + "-" + iMonth.ToString() + "-" + iDay.ToString() + " " + iHour.ToString() + ":" + iMinute.ToString() + ":" + iSecond.ToString();
            em.PassDoor = Convert.ToDateTime(passtime);
            SavePassDoorInformation();
           // fr.Tb_id.Text = em.EmployeeNumber;
           // fr.textBox1.Text = passtime; 
        }
        #endregion

        //保存人员过门信息
        public void SavePassDoorInformation()
        {
            EmployeesInterface dao = new EmployeeDataManipulation();
            dao.AddEmployeePassDoorInformation(em);
        }

        //获取展示页面
        public void setfrom(Form1 fr)
        {
            this.fr = fr;

        }

        //关闭连接
        public void CloseConnect()
        {
           // axCZKEM1.Disconnect();
            bIsConnected = false;
        }

    }
}
