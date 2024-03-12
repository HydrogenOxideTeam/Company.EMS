using System.Reflection;
using System.Text;
using Company.EMS.CQS.Commands.CreateExample;
using Company.EMS.CQS.Queries.GetExample;
using Company.EMS.Data;
using Company.EMS.Extensions;
using Company.EMS.Repositories;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services;
using Company.EMS.Services.Abstractions;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Company.EMS",
        Description = "An ASP.NET Core Web API of HydrogenOxideTeam",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Olenka Panychok",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
    options.MapType<Guid>(() => new OpenApiSchema { Type = "string", Format = null });
    // options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    // {
    //     Name = "Authorization",
    //     Scheme = "Bearer",
    //     BearerFormat = "JWT",
    //     In = ParameterLocation.Header,
    //     Description = "JWT Authorization header using the Bearer scheme"
    // });
    // options.AddSecurityRequirement(new OpenApiSecurityRequirement {
    //     {
    //         new OpenApiSecurityScheme {
    //             Reference = new OpenApiReference {
    //                 Type = ReferenceType.SecurityScheme,
    //                 Id = "Bearer"
    //             }
    //         },
    //         new string[] {}
    //     }
    // });
    // var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    // options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();

builder.Services.AddValidatorsFromAssemblyContaining<CreateExampleCommandValidator>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddMediatR(cfg => cfg
    .RegisterServicesFromAssemblies(typeof(GetExampleQuery)
        .GetTypeInfo().Assembly));

builder.Services.AddCustomCorsPolicy(); 

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IExampleRepository, ExampleRepository>();
builder.Services.AddScoped<IExampleService, ExampleService>();

// builder.Services.AddAuthentication(options =>
//     {
//         options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//         options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//         options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//     })
//     .AddJwtBearer(options =>
//     {
//         options.SaveToken = true;
//         options.RequireHttpsMetadata = false;
//         options.TokenValidationParameters = new TokenValidationParameters()
//         {
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidAudience = builder.Configuration["JWT:ValidAudience"],
//             ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
//             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SigningKey"]))
//         };
//     });
//
// builder.Services.AddAuthorization();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}

//app.UseCors("DefaultCorsPolicy");
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();