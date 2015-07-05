using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
        void AddHost(Host item);

        [OperationContract]
        void UpdateHost(Host item);

        [OperationContract]
        int CheckUser(string name, string pw);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: 在此添加您的服务操作
    }

    // 使用下面示例中说明的数据协定将复合类型添加到服务操作
    [DataContract]
    public class CompositeType {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
