using System.ServiceModel;
using WCFTaskOneService.Domain.StudentsManagement;

namespace WCFTaskOneService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentsService" in both code and config file together.
    [ServiceContract]
    public interface IStudentsService
    {
        [OperationContract]
        string AddNewStudent(Student student);
    }
}
