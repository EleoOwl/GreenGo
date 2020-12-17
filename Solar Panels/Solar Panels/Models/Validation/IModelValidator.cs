using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Models.Validation
{
    public interface IModelValidator<in T> where T : class
    {
        bool Validate(T model);
    }
}
