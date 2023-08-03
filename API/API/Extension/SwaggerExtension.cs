﻿using Microsoft.OpenApi.Models;

namespace API.Extension
{
    public static class SwaggerExtension
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Tracking.Api",
                    Version = "v1",
                    Description = "Tracking Web Api ",
                });
            });
        }
    }
}
