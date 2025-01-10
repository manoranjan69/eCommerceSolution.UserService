

using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContract;

namespace eCommerce.Core.Services;

internal class UserService : IUserService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;
    public UserService(IUsersRepository usersRepository ,IMapper mapper)
    {
            _usersRepository = usersRepository; 
           _mapper = mapper;
    }
    public async Task<AuthenticationResponse> Login(LoginRequest loginRequest)
    {
        ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassWord(loginRequest.Email, loginRequest.Password);
        if (user == null)
        {
            return null;
        }

        //return new AuthenticationResponse(user.UserId, user.Email, user.PersonName, user.Gender, "token", Success: true);

        return _mapper.Map<AuthenticationResponse>(user) with { Success = true ,Token="token"};

        
        
    }

    public async Task<AuthenticationResponse?> Register(RegisterRequest registerrequest)
    {
        ApplicationUser? user = new ApplicationUser()
        {
            PersonName = registerrequest.PersonName,
            Email = registerrequest.Email,
            Password = registerrequest.Password,
            Gender=registerrequest.Gender.ToString(),
        };
      ApplicationUser ?registeruser= await  _usersRepository.AddUser(user);
        if (registeruser == null) {

            return null;
        
        
        }

        //return new AuthenticationResponse
        //    (
        //     registeruser.UserId,
           
        //     registeruser.Email,
        //     registeruser.PersonName,
        //    registeruser.Gender,
        //    "token",
        //    Success: true);

        return _mapper.Map<AuthenticationResponse>(user) with { Success= true ,Token="token"};





    }
}

