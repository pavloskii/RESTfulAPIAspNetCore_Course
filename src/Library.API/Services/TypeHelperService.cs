using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class TypeHelperService
    {
        public bool TypeHasProperties<T>(string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                return true;
            }

            //the field are separated by "," so we split it
            var fieldsAfterSplit = fields.Split(',');

            //check if the requested fields eist on source
            foreach (var field in fieldsAfterSplit)
            {

                //trim each field as it might containt leading or trailing spaces. Cant trim the var in 
                //foreach, so use another var.
                var propertyName = field.Trim();
            }
        }
    }
}
