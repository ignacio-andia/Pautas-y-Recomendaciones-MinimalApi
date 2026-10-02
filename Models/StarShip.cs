using System.Runtime.CompilerServices;

namespace practicaX.Models
{
    public record StarShip(int id, string name, string Model, int PilotoId);
    public record StarShipInput(string name, string Model, int PilotoId);
}
