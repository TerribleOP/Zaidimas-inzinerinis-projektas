public class City
{
    public string id;
    public string name;
    public string currentEventId;

    public City(string id, string name, string startEventId)
    {
        this.id = id;
        this.name = name;
        this.currentEventId = startEventId;
    }
}