
namespace SafariParkApp;

public class SpottingList
{
    public bool Hyena { get; set; }
    public bool Lion { get; set; }
    public bool Buffalo { get; set; }
    public bool Gazelle { get; set; }
    public bool Baboon { get; set; }

    public SpottingList()
    {
        Hyena = false;
        Lion = false;
        Buffalo = false;
        Gazelle = false;
        Baboon = false;
    }
}
