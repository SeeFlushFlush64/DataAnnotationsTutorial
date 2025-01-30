using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsTutorial.ValidationClasses
{
    public class ValidationMessage
    {
        public string ErrorMessage { get; set; }
        public string PropertyName { get; set; }
        public override string ToString()
        {
            return $"{ErrorMessage}"; 
        }
    }

}
