using ElixirPoint.API.Models;
using ElixirPoint.API.Services;

namespace ElixirPoint.API.Endpoints;
internal static class CustomerEndpoint
{
    internal static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Customer").WithTags(nameof(Customer));

        group.MapGet("/", (ICustomerService customerService) =>
        {
            return customerService.GetAll();
        })
        .WithName("GetAllCustomers")
        .WithOpenApi();

        group.MapGet("/{id}", (int id, ICustomerService customerService) =>
        {
            var customer = customerService.GetById(id);
            return customer != null ? Results.Ok(customer) : Results.NotFound();
        })
        .WithName("GetCustomerById")
        .WithOpenApi();

        group.MapPut("/{id}", async (int id, Customer input, ICustomerService customerService) =>
        {
            var existingCustomer = customerService.GetById(id);
            if (existingCustomer == null)
            {
                return Results.NotFound();
            }

            await customerService.Update(input);
            return Results.NoContent();
        })
        .WithName("UpdateCustomer")
        .WithOpenApi();

        group.MapPost("/", (Customer model, ICustomerService customerService) =>
        {
            customerService.Create(model);
            return Results.Created($"/api/Customer/{model.Id}", model);
        })
        .WithName("CreateCustomer")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id, ICustomerService customerService) =>
        {
            var existingCustomer = customerService.GetById(id);
            if (existingCustomer == null)
            {
                return Results.NotFound();
            }

            customerService.Delete(id);
            return Results.Ok();
        })
        .WithName("DeleteCustomer")
        .WithOpenApi();
    }
}

