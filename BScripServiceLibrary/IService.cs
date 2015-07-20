using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace BScripServiceLibrary {
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IBSService {
        [OperationContract]
        string GetPath();

        [OperationContract]
        void SaveConf(int userid, string[] hostnames);

        [OperationContract]
        void SetSaveConfTime(int userid, string hostname, long span);

        [OperationContract]
        void SetMonitorTime(int userid, string hostname, long span);

        [OperationContract]
        Host[] GetHosts(int userid);

        [OperationContract]
        Host[] GetBackUpHosts();

        [OperationContract]
        Host[] GetDBHosts(int userid);

        [OperationContract]
        DateTime[] GetConSaveDate(string ip, DateTime begin, DateTime end);

        [OperationContract]
        ROccupy[] GetCpuMemOccupy(Host h, DateTime begintime, DateTime endtime);

        [OperationContract]
        string GetConf(string ip, DateTime checkdate);

        [OperationContract]
        void AddHost(Host item);

        [OperationContract]
        void UpdateHost(Host item);

        [OperationContract]
        int CheckUser(string name, string pw);

        [OperationContract]
        int[] GeConfCount(Host[] hl, DateTime begin, DateTime end);

        // TODO: 在此添加您的服务操作
    }

    // 使用下面示例中说明的数据协定将复合类型添加到服务操作
    [DataContract]
    public class ROccupy {
        string ip;
        string slotname;
        int cpuoccupy;
        int memoccupy;

        [DataMember]
        public string IP {
            get { return ip; }
            set { ip = value; }
        }

        [DataMember]
        public string SlotName {
            get { return slotname; }
            set { slotname = value; }
        }

        [DataMember]
        public int CpuOccupy {
            get { return cpuoccupy; }
            set { cpuoccupy = value; }
        }

        [DataMember]
        public int MemOccupy {
            get { return memoccupy; }
            set { memoccupy = value; }
        }
    }
}
