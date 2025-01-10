using eCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.RepositoryContracts;

/// <summary>
/// Contact to implemnted by user repository  that contain data acess logic  Of UserData Store.
/// </summary>
    public interface IUsersRepository
    {
    /// <summary>
    /// Method to add  a user  to data store and return the add user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<ApplicationUser?>AddUser(ApplicationUser user);
    /// <summary>
    /// Method to add user  to data store and return the add user
    /// </summary>
    /// <param name="Emal"></param>
    /// <param name="Password"></param>
    /// <returns></returns>
        Task<ApplicationUser?> GetUserByEmailAndPassWord(string? Emal, string? Password);
    }
