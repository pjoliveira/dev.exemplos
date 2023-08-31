using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaServices
{
    public sealed class ModelValidate
    {

        public ICollection<ValidationResult> ValidationResults { get; private set; }
        public bool IsValid { get; private set; }
        public ModelValidate(object model)
        {
            ValidationResults = new List<ValidationResult>();
            IsValid = Validator.TryValidateObject(model,
                new ValidationContext(model),
                ValidationResults, true);
        }

        public ModelValidate(object model, bool throwIfExists) : this(model)
        {
            if (throwIfExists) ThrowException();
        }

        public void ThrowException()
        {
            throw new ValidationException(ErrorMessages());
        }

        public string ErrorMessages()
        {
            string message = string.Empty;
            if (!IsValid)
            {
                if (ValidationResults != null &&
                    ValidationResults.Count > 0)
                {
                    IEnumerator<ValidationResult> results =
                        ValidationResults.GetEnumerator();
                    while (results.MoveNext())
                    {
                        ValidationResult vr = results.Current;
                        message += vr.ErrorMessage + System.Environment.NewLine;
                    }
                }
            }

            return message;
        }
    }
}
