namespace dungEcommerce.API.dungEcommerce.Builder
{
    public static class dungEcommerceBuilder
    {
        public static void useDungEcommerceBuilder(this IApplicationBuilder builder, bool isDevelopment)
        {
            // Configure the HTTP request pipeline.
            if (isDevelopment)
            {
                builder.UseSwagger();
                builder.UseSwaggerUI();
            }

            builder.UseHttpsRedirection();

            builder.UseAuthorization();

            builder.UseCors("cors_policy");
        }
    }
}