using practicaX.Models;
namespace practicaX.Data
{
    public static class InfoData
    {
        public static List<Planet> Planets { get; } = [
            new (1, "Tatooine", "Arido", "Desierto"),
            new (2, "Alderaan", "Temperate", "Pradera"),
            new (3, "Hielo", "Helado", "Glaciares"),
            ];


        public static List<Character> Characters { get; } = [
            new (1, "Luke ", "Humano", 1),
            new (2, "Leis", "Humano", 2),
            new (3, "Han", "Humano", 3),
            new (4, "Chewbacca", "Wookiee", 3)
            ];


        public static List<StarShip> StarShips { get; } = [
            new (1, "X-Wuing", "T65", 1),
            new (2, "Falcon Milenario", "YT-1300", 3),
            new (3, "Falcon Milenario", "YT-1300", 4),
            ];

        public static int NexId<T>(IEnumerable<T> Items, Func<T, int> idSelector) => 
            Items.Select(idSelector).DefaultIfEmpty(0).Max() + 1; 


    }
}
