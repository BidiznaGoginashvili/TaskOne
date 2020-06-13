using System;
using System.Data.Entity.Validation;
using System.Linq;
using WCFTaskOneService.DataBase;
using WCFTaskOneService.Domain.StudentsManagement;

namespace WCFTaskOneService
{
    public class StudentsService : IStudentsService
    {
        private readonly WCFTaskOneContext _context;

        public StudentsService()
        {
            _context = new WCFTaskOneContext();
        }

        public string GetValidations(DbEntityValidationException exception)
        {
            var entityValidationErrors = exception.EntityValidationErrors
                      .SelectMany(validation => validation.ValidationErrors
                          .Select(error => error.ErrorMessage));

            return string.Join(";", entityValidationErrors.ToArray());
        }

        public string AddNewStudent(Student student)
        {
            try
            {
                _context.Student.Add(student);
                _context.SaveChanges();
                return "succeded";
            }
            catch (DbEntityValidationException exception)
            {
                return GetValidations(exception);
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
