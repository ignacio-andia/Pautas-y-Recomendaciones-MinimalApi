using practicaX.Data;
using practicaX.Models;
using System.Runtime.CompilerServices;

namespace practicaX.Endpoints
{
    public static class PlanetEndpoints
    {
        public static void MapPLanetEndpoints(this RouteGroupBuilder api)
        {
            // Grupo: /api/planets
            var group = api.MapGroup("Planets").WithTags("Planets");

            group.MapGet("/", () => Results.Ok(InfoData.Planets))
                .WithName("Obteners Planetas")
                .WithSummary("lsita de todos los planetas");
        } 
    }
}
