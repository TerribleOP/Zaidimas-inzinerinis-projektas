using System.Collections.Generic;

[System.Serializable]
public class Event
{
    public string id;
    public string title;
    public string description;
    public List<Choice> choices;
}