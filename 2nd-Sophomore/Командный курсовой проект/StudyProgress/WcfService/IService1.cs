using System.Runtime.Serialization;
using System.ServiceModel;
using SharedModel;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        User ReturnActiveUser();

        [OperationContract]
        Subject GetSubject();

        [OperationContract]
        void SetExam(bool b);

        [OperationContract]
        bool Login(string login, string password);

        [OperationContract]
        void AddSubject(User user, Subject subject);

        [OperationContract]
        bool Register(string login, string password);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public bool BoolValue { get; set; } = true;

        [DataMember]
        public string StringValue { get; set; } = "Hello ";
    }
}
