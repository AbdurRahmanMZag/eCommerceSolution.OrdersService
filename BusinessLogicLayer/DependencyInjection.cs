using eCommerce.ordersMicroservice.BusinessLogicLayer.Mappers;
using eCommerce.ordersMicroservice.BusinessLogicLayer.Services;
using eCommerce.OrdersMicroservice.BusinessLogicLayer.ServiceContracts;
using eCommerce.OrdersMicroservice.BusinessLogicLayer.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.OrderMicroservice.BusinessLogicLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
    {
        //TO DO: Add business logic layer services into the IoC container

        services.AddValidatorsFromAssemblyContaining(typeof(OrderAddRequestValidator));

        services.AddFluentValidationAutoValidation();

        services.AddAutoMapper(typeof(OrderAddRequestToOrderMappingProfile).Assembly);

        services.AddScoped<IOrdersService, OrdersService>();

        return services;
    }
}