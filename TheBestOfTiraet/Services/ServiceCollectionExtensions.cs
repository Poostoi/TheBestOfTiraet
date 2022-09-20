using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace TheBestOfTiraet.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationModule(this IServiceCollection service)
    {
        service.AddAuthentication("Bearer")
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // указывает, будет ли валидироваться издатель при валидации токена
                    ValidateIssuer = true,
                    // строка, представляющая издателя
                    ValidIssuer = "MyAuthServer",
                    // будет ли валидироваться потребитель токена
                    ValidateAudience = true,
                    // установка потребителя токена
                    ValidAudience = "MyAuthClient",
                    // будет ли валидироваться время существования
                    ValidateLifetime = true,
                    // установка ключа безопасности
                    IssuerSigningKey =  new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretkey!123")),
                    // валидация ключа безопасности
                    ValidateIssuerSigningKey = true,
                };
            });
        return service;
    }
}