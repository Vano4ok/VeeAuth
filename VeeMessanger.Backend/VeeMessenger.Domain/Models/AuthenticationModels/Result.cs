namespace VeeMessenger.Domain.Models.AuthenticationModels
{
    public class Result
    {
        private List<Error> errors = new List<Error>();

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

        public IEnumerable<Error> Errors
        {
            get
            {
                return errors;
            }
        }

        public void AddErrors(IEnumerable<Error> errorsArray)
        {
            if (errorsArray is not null)
            {
                errors.AddRange(errorsArray);
            }
        }

        public void AddErrors(params Error[] errorsArray)
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

    public class Result<T> : Result
    {
        public T Data { get; set; }

        public Result(T data)
        {
            Data = data;
        }

        public Result() { }
    }
}
