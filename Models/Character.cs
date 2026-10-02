namespace practicaX.Models
{
    public record Character(int Id, String Name, string Species, int PlanetId);
    public record CharacterInput(String Name, string Species, int PlanetId);
}
