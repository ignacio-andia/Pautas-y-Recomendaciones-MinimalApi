namespace practicaX.Models
{
    public record Planet(int Id, string Name, String Climate, string Terrain); 
    public record PlanetInput(string Name, String Climate, string Terrain); 

}
