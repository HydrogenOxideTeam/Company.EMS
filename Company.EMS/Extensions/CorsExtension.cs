namespace Company.EMS.Extensions;

/// <summary>
/// 
/// </summary>
public static class CorsExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="policyName"></param>
    /// <returns></returns>
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