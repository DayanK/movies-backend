using System;
using Microsoft.EntityFrameworkCore;

namespace Movie.Api.Data;

public static class DataExtensions
{
    public static async void MigrationDatabaseAsync(this WebApplication app){
        using var scope = app.Services.CreateScope();

        var dbcontext = scope.ServiceProvider.GetRequiredService<MovieStoreContext>();

        await dbcontext.Database.MigrateAsync();
    }

}
