
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace eCommerce.Infrastructure.DbContext;

public class DapperDbContext
{

    private readonly IConfiguration? _configuration;
    private readonly IDbConnection? _connection;

    public DapperDbContext(IConfiguration? configuration)
    {
        _configuration = configuration;
      //  _connection = connection;

        string ? connectionstring = _configuration.GetConnectionString("PostgresConnection");
        //Create a new SqlConnection  with the retrived connectionstring
        _connection = new NpgsqlConnection(connectionstring);

    }

    public IDbConnection DbConnection => _connection;


}

