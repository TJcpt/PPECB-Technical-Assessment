using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRESTService" in both code and config file together.

    #region IRESTService Interface

    [ServiceContract]
    public interface IRESTSerivce
    {
        //POST operation
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Employee CreateEmployee(Employee createEmployee);


        //Get Operation
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Employee> GetAllEmployee();
        [OperationContract]
        [WebGet(UriTemplate = "{id}")]
        Employee GetAEmployee(string id);

        //PUT Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        Employee UpdateEmployee(string id, Employee updateEmployee);

        //DELETE Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        void DeleteEmployee(string id);

    }

    #endregion
}
