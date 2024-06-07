using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace validationUsingAnnotation_Ex.Models
{
    
    public class customerror:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            decimal pr=Convert.ToDecimal(value);
            if(pr%2==0)
            {
                return true;
            }
            else
            {
                return false;                                                                                                                                                                                                                                                                                                                                           
            }
           
        }
    }
}