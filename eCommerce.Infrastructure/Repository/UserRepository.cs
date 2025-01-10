
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.Entities;
using eCommerce.Core.DTO;
using eCommerce.Infrastructure.DbContext;
using Dapper;


namespace eCommerce.Infrastructure.Repository;
internal class UserRepository : IUsersRepository
{

    private readonly DapperDbContext _dbContext;
    public UserRepository(DapperDbContext dbContext )
    {
        _dbContext = dbContext;
    }
    public async Task<ApplicationUser?> AddUser(ApplicationUser user)
    {
        //Generate a new Unique user Id for  the User

        user.UserId = Guid.NewGuid();
        //Sql Query to insert  user data  into "User " Table.

        string query = "INSERT INTO public.\"Users\"(\"UserID\",\"Email\",\"PersonName\", \"Gender\",\"Password\")VALUES(@UserID,@Email,@PersonName,@Gender,@Password)";
        int rowCountAffected = await _dbContext.DbConnection.ExecuteAsync(query, user);
        if (rowCountAffected > 0)
        {
            return user;
        }
        else { return null; }
           
    }

    public async Task<ApplicationUser?> GetUserByEmailAndPassWord(string? email, string ? password)
    {
        //Sql Query to select User by Email and  Password
        string query = "SELECT * FROM public.\"Users\" WHERE \"Email\"=@Email AND \"Password\"=@Password";
        var parameters = new { Email = email, Password = password };

        ApplicationUser? user = await _dbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, parameters);

        return user;

        //return new ApplicationUser()
        //{
        //    UserId = Guid.NewGuid(),
        //    Email = email,
        //    Password = password,
        //    PersonName = "Person Name",
        //    Gender = GenderOptions.Male.ToString()

        //};





    }
}

