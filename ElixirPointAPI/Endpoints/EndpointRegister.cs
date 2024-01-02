namespace ElixirPoint.API.Endpoints;

internal static class EndpointRegister
{
    internal static void MapAllEndpoints(this WebApplication app)
    {
        // Split the endpoints by feature rather than the model or service class
        app.MapCustomerEndpoints();
        //app.MapReportingEndpoints();
        //app.MapSaleEndpoints();
        //app.MapSupplierEndpoints();


    }
}
