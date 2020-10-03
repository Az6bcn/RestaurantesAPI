using System.Collections.Generic;

namespace Restaurants.Commons.ApiResponse
{
    public class ApiResponse<T> where T : class
    {
        public ApiResponse()
        {
            Results = new List<T>();
            ErrorMessages = new List<string>();
        }

        private IEnumerable<T> Results { get; set; }
        private T Result { get; set; }
        private bool Success { get; set; }
        private string ErrorMessage { get; set; }
        private IEnumerable<string> ErrorMessages { get; set; }

        /// <summary>
        /// Returns a successful mapped result of type <see cref="IEnumerable{T}"></see>
        /// </summary>
        /// <param name="results"></param>
        /// <returns></returns>
        public static ApiResponse<T> Succeed(IEnumerable<T> results) => new ApiResponse<T> { Success = true, Results = results };


        /// <summary>
        /// Returns a successful mapped result of type <see cref="T"></see>
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static ApiResponse<T> Succeed(T result) => new ApiResponse<T> { Success = true, Result = result };


        /// <summary>
        /// Returns a failed mapped result, with a list of error messages: <see cref="string[]"></see>
        /// </summary>
        /// <param name="errorMessages"></param>
        /// <returns></returns>
        public static ApiResponse<T> Fail(params string[] errorMessages) => new ApiResponse<T> { Success = false, ErrorMessages = errorMessages };


        /// <summary>
        /// Returns a failed mapped result, with a list of error messages: <see cref="string"></see>
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static ApiResponse<T> Fail(string errorMessage) => new ApiResponse<T> { Success = false, ErrorMessage = errorMessage };

    }
}
