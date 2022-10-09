namespace SegurosABC.WebApi
{
	public static class WebApplicationHelper
	{
		public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
		{
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddSegurosABCDependencies(builder.Configuration, "SegurosABC");

			return builder.Build();
		}

		public static WebApplication ConfigureWebApplication(this WebApplication app)
		{
			app.RunMigrations();

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
