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

        /// <summary>
        /// 
        /// Receives an entity (e.g. Product) then validates all the properties of the entity
        /// ret = stores all the error messages after a failed validation
        /// context = is an instance of ValidationContext that receives the entity
        /// TryValidateObject = receives 4 arguments
        /// - entity = the entity to be validated
        /// - context = the instance of ValidationContext
        /// - ret = the list that will store the error messages
        /// - true = all of the properties of the entity will be validated
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns>List<ValidationResult></returns>
        public static List<ValidationResult> Validate<T>(T entity) where T : class
        {
            List<ValidationResult> ret = new();
            ValidationContext context = new(entity);
            Validator.TryValidateObject(entity, context, ret, true);
            return ret;
        }
        #endregion

        #region ValidateToValidationMessage method
        public static List<ValidationMessage> ValidateToValidationMessage<T>(T entity) where T : class
        {

            List<ValidationMessage> ret = new();
            List<ValidationResult> results = Validate(entity);
            
  
            if (results.Count != 0)
            {
                foreach (ValidationResult result in results)
                {
                    string propName = "Unknown Property";
                    if (result.MemberNames.Any())
                    {
                        propName = result.MemberNames.ToArray()[0];
                    }
                    ret.Add(new()
                    {
                        PropertyName = propName,
                        ErrorMessage = result.ErrorMessage ?? "Unknown Validation Error" 
                    });
                }
            }
            
            return ret;
        }
        #endregion
    }
}
