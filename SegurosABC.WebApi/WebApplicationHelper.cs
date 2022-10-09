namespace SegurosABC.WebApi
{
	public static class WebApplicationHelper
	{
		private const string _MY_ALLOW_SPECIFI_CORIGINS = "myAllowSpecificOrigins";

		public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
		{
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddSegurosABCDependencies(builder.Configuration, "SegurosABC");

			builder.Services.AddCors();

			return builder.Build();
		}

		public static WebApplication ConfigureWebApplication(this WebApplication app)
		{
			app.RunMigrations();
			app.UseCors(x => x
			   .AllowAnyMethod()
			   .AllowAnyHeader()
			   .SetIsOriginAllowed(origin => true) // allow any origin
			   .AllowCredentials());

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseSegurosABCEndpoints();

			return app;
		}
	}
}
