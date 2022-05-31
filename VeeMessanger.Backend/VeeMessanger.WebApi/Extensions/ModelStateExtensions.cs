using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace VeeMessanger.WebApi.Extensions
{
    public static class ModelStateExtensions
    {
        public static IEnumerable<string> GenerateValidation(this ModelStateDictionary dictionary)
        {
            List<string> output = new List<string>();

            foreach (var dictionaryValue in dictionary.Values)
            {
                foreach (var error in dictionaryValue.Errors)
                {
                    output.Add(error.ErrorMessage);
                }
            }

            return output;
        }
    }
}
