namespace VeeMessenger.Domain.Models.AuthenticationModels
{
    public class AuthenticationResult
    {
        private List<AuthenticationError> errors = new List<AuthenticationError>();

        public bool Succeeded
        {
            get
            {
                return !errors.Any();
            }
        }

        public bool Failed
        {
            get
            {
                return errors.Any();
            }
        }

        public IEnumerable<AuthenticationError> Errors
        {
            get
            {
                return errors;
            }
        }

        public void AddErrors(IEnumerable<AuthenticationError> errorsArray)
        {
            if (errorsArray is not null)
            {
                errors.AddRange(errorsArray);
            }
        }

        public void AddErrors(params AuthenticationError[] errorsArray)
        {
            if (errorsArray is not null)
            {
                errors.AddRange(errorsArray);
            }
        }

        public override string ToString()
        {
            return Succeeded ?
               "Succeeded" :
               string.Format("{0} : {1}", "Failed", string.Join(",", Errors.Select(x => x.Code).ToList()));
        }
    }
}
