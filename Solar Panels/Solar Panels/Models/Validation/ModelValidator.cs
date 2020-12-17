using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Models.Validation
{
    public abstract class ModelValidator<T> : IModelValidator<T> where T : class
    {
        public virtual bool Validate(T model)
        {
            return model != null;
        }

        protected bool ValidateIfGuidIsEmpty(Guid parameter, string parameterName)
        {
            return parameter != Guid.Empty;
        }

        protected bool ValidateIfStringIsEmpty(string parameter, string parameterName)
        {
            return !string.IsNullOrEmpty(parameter);
        }

        protected bool ValidateIfIntegerIsZero(int parameter, string parameterName)
        {
            return parameter != 0;
        }

        protected virtual string GuidNotValidMessage(string parameterName, Guid value) => $"{parameterName} parameter contains not valid guid: {value}.";

        protected virtual string FieldEmptyMessage(string parameterName) => $"{parameterName} field should not be empty.";

        protected virtual string ZeroValueMessage(string parameterName) => $"{parameterName} field should not be zero.";

        protected virtual string MissingModelMessage => "Model information is missing.";

        protected virtual string InvalidRequestMessage => "Request invalid.";
    }
}
