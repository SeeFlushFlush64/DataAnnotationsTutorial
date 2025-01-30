 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsTutorial.ValidationClasses
{
    public static class ValidationHelper
    {
        #region Validate<T> method

        public static List<ValidationResult> Validate<T>(T entity) where T : class
        {
            List<ValidationResult> ret = new();
            ValidationContext context = new(entity);
            Validator.TryValidateObject(entity, context, ret, true);
            return ret;
        }
        #endregion
    }
}
