using System.Runtime.Serialization;

namespace WCFTaskOneService.Domain.StudentsManagement
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }
    }
}