using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnCallingGET_ReturnEmployeeList()
        {
            EmployeeWebService service = new EmployeeWebService();
            IRestResponse response = service.GetEmployeeList();
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
            List<Employee> dataResponse = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(14, dataResponse.Count);
        }
    }
}
