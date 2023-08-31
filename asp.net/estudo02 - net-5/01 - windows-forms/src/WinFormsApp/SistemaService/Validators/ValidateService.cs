namespace SistemaServices
{
    public class ValidateService
    {
        //private ModelStateDictionary _modelState;
        private readonly object _model;

        public ValidateService(object model)
        {
            //_modelState = modelState;
            _model = model;
        }

        public string ValidaModel()
        {
            string ErrorMessages = string.Empty;

            ModelValidate modelValid = new ModelValidate(_model);
            if (!modelValid.IsValid)
            {
                ErrorMessages = modelValid.ErrorMessages();
            }
           

            return ErrorMessages; 

        }

    }
}
