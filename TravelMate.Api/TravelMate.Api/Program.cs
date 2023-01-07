using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using TravelMate.Api.Extentions;
using TravelMate.Api.Middlewares;
using TravelMate.Application.Settings.Authentications;
using TravelMate.Application.Settings.Informations;
using TravelMate.Application;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Infrastructure.Contracts;
using TravelMate.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.Configure<DomainInfo>(builder.Configuration.GetSection("DomainInfo"));
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JWT"));

var jwt = builder.Configuration.GetSection("JWT").Get<JwtSettings>();

builder.Services.AddIdentity<User, Role>(options =>
{
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.SignIn.RequireConfirmedEmail = true;
})
   .AddEntityFrameworkStores<ApplicationDbContext>()
   .AddDefaultTokenProviders();

builder.Services.ConfigureCors();


builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "My Delivery", Version = "v1" });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        //Description = "JWT containing userid claim",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
    });

    var security =
        new OpenApiSecurityRequirement
        {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Id = "Bearer",
                                    Type = ReferenceType.SecurityScheme
                                },
                                UnresolvedReference = true
                            },
                            new List<string>()
                        }
        };
    options.AddSecurityRequirement(security);
});


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddAuth(jwt);
builder.Services.AddHealthChecks()
    .AddNpgSql(builder.Configuration.GetConnectionString("DefaultConnection"));

builder.Services.AddControllers();


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{

    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<User>>();
    var roleManager = services.GetRequiredService<RoleManager<Role>>();
    var logger = services.GetService<ILogger<ApplicationDbContextSeed>>();
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate();
    ApplicationDbContextSeed
         .SeedAsync(db, logger, userManager, roleManager)
         .Wait();
}


app.UseCors(builder =>
builder.WithOrigins("http://localhost:3005", "https://www.qa.deliver.ist", "https://qa.deliver.ist", "https://www.deliver.ist", "https://deliver.ist", "http://localhost:3000", "https://feature-try-aws-amplify.dwhguvoxxmedk.amplifyapp.com").AllowAnyHeader().AllowAnyMethod());
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Delivery.Api v1"));
}
app.UseLanguageCode();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseMiddleware(typeof(ExceptionHandlingMiddleware));
app.UseHealthChecks("/health/c188117c-a083-4935-ab90-c3deb583cb35");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.Run();