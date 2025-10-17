using SweDemoBackend.Application.UseCases;
using SweDemoBackend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// --- Services ---
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddScoped<LegoSetUseCase>();
builder.Services.AddControllers();

// Swagger/OpenAPI (kies één stijl; hier de "klassieke")
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS
const string FrontendCorsPolicy = "FrontendCorsPolicy";
var allowedOriginsEnv = Environment.GetEnvironmentVariable("ALLOWED_ORIGINS") ?? string.Empty;
var allowedOrigins = allowedOriginsEnv
    .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

// In dev: fallback naar Angular localhost-origins als env leeg is
if (builder.Environment.IsDevelopment() && allowedOrigins.Length == 0)
{
  allowedOrigins = new[] { "http://localhost:4200", "https://localhost:4200" };
}

builder.Services.AddCors(options =>
{
  options.AddPolicy(FrontendCorsPolicy, policy =>
  {
    if (allowedOrigins.Length > 0)
    {
      policy.WithOrigins(allowedOrigins)
            .AllowAnyHeader()
            .AllowAnyMethod()
            // Voeg dit toe als je cookies/Authorization header met credentials gebruikt:
            //.AllowCredentials()
            ;
    }
    else
    {
      // Als je per se zonder env-var wil draaien, kan je tijdelijk alles toelaten (DEV ONLY):
      policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    }
  });
});

// --- App pipeline ---
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS moet vóór Authorization en vóór MapControllers
app.UseCors(FrontendCorsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
