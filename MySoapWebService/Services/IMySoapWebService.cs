using System.ServiceModel;

namespace MySoapWebService.Services
{
    [ServiceContract]
    public interface IMySoapWebService
    {
        [OperationContract]
        string MyOperation(string input);

        [OperationContract]
        void CreateEmployee(Employee employee);
    }
}
