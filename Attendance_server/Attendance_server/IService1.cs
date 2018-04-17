using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Attendance_server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void registerstudent(string name, string password, string email, string question, string answer, string s_class);

        [OperationContract]
        bool isvaliduser(string username, string password);
        [OperationContract]
        void addclass(bool check, string s_class, string subject);
        [OperationContract]
        List<@class> d();
        [OperationContract]
        void delete(int a);
        [OperationContract]
        void registerteacher(string name, string password, string email, string qualification);

        // string retclass();
        string GetData(int value);


        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
