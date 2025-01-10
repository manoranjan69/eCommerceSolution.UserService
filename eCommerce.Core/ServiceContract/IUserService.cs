

using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContract;
/// <summary>
/// Contact for users Service that contains  use cases for users
/// </summary>
    public interface IUserService
    {
   /// <summary>
   /// Method to handle user login use case
   /// and  returns an authenticationresponse object  that
   /// contains  status of login
   /// </summary>
   /// <param name="loginRequest"></param>
   /// <returns></returns>
       Task<AuthenticationResponse> Login(LoginRequest loginRequest);
    /// <summary>
    /// Methods to handle  user registration use case
    /// and returns  an object of AuthenticationResponse type that 
    /// represents  status of user registration
    /// </summary>
    /// <param name="registerrequest"></param>
    /// <returns></returns>
       Task<AuthenticationResponse?> Register(RegisterRequest registerrequest);
}
