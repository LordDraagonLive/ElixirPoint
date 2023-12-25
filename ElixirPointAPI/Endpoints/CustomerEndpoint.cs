using ElixirPointAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace ElixirPointAPI.Endpoints;

public class CustomerEndpoint : IEndpointDefinition
{
    //public static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    //{
    //    var group = routes.MapGroup("/api/Customer").WithTags(nameof(Customer));

    //    group.MapGet("/", () =>
    //    {
    //        return new[] { new Customer() };
    //    })
    //    .WithName("GetAllCustomers")
    //    .WithOpenApi();

    //    group.MapGet("/{id}", (int id) =>
    //    {
    //        //return new Customer { ID = id };
    //    })
    //    .WithName("GetCustomerById")
    //    .WithOpenApi();

    //    group.MapPut("/{id}", (int id, Customer input) =>
    //    {
    //        return TypedResults.NoContent();
    //    })
    //    .WithName("UpdateCustomer")
    //    .WithOpenApi();

    //    group.MapPost("/", (Customer model) =>
    //    {
    //        //return TypedResults.Created($"/api/Customers/{model.ID}", model);
    //    })
    //    .WithName("CreateCustomer")
    //    .WithOpenApi();

    //    group.MapDelete("/{id}", (int id) =>
    //    {
    //        //return TypedResults.Ok(new Customer { ID = id });
    //    })
    //    .WithName("DeleteCustomer")
    //    .WithOpenApi();
    //}
}
