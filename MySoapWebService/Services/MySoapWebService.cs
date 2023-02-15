using System.Drawing.Printing;

namespace MySoapWebService.Services
{
    public class MySoapWebService : IMySoapWebService
    {
        public string MyOperation(string input)
        {
            return "Hello, " + input + "!";
        }
        
        public void CreateEmployee(Employee emp)
        {
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }

    }
}
