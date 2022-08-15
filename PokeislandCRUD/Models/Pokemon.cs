
namespace PokeislandCRUD.Models;

public class Pokemon {
    public int id { get; set; }
    public int userId { get; set; }
    public string? name { get; set; }
    public int experience { get; set; }
    public int neededExperience { get; set; }
    public string? firstMove { get; set; }
    public string? secondMove { get; set; }
    public string? thirdMove { get; set; }
    public string? fourthMove { get; set; }
    public int hp { get; set; }
    public int atk { get; set; }
    public int spDef { get; set; }
    public int spAtk { get; set; }
    public int spd { get; set; }
    public int current_level { get; set; }
    public int def { get; set; }
}