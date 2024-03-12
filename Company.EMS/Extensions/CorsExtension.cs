namespace Company.EMS.Extensions;

public static class CorsExtension
{
    public static IServiceCollection AddCustomCorsPolicy(this IServiceCollection services, string policyName = "DefaultCorsPolicy")
    {
        services.AddCors(options =>
        {
            options.AddPolicy(policyName, builder =>
            {
                builder.WithOrigins("http://example.com", "http://www.anotherdomain.com") 
                    .AllowAnyMethod() 
                    .AllowAnyHeader() 
                    .AllowCredentials(); 
            });
        });

        return services;
    }
}