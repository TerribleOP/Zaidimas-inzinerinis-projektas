using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Dictionary<string, Event> events = new Dictionary<string, Event>();
    public Dictionary<string, City> cities = new Dictionary<string, City>();

    void Start()
    {
        InitializeEvents();
        InitializeCities();
    }

    void InitializeEvents()
    {
        Event event1 = new Event
        {
            id = "event_1",
            title = "Gaisras mieste",
            description = "Mieste kilo didelis gaisras. Kà daryti?",
            choices = new List<Choice>
            {
                new Choice { text = "Siøsti ugniagesius", nextEventId = "event_2", nextCityId = "city_2" },
                new Choice { text = "Ignoruoti", nextEventId = "event_3", nextCityId = "city_1" }
            }
        };

        Event event2 = new Event
        {
            id = "event_2",
            title = "Iðgelbëta!",
            description = "Ugniagesiai uþgesino gaisrà.",
            choices = new List<Choice>()
        };

        Event event3 = new Event
        {
            id = "event_3",
            title = "Katastrofa",
            description = "Gaisras iðplito...",
            choices = new List<Choice>()
        };

        events.Add(event1.id, event1);
        events.Add(event2.id, event2);
        events.Add(event3.id, event3);
    }

    void InitializeCities()
    {
        cities.Add("city_1", new City("city_1", "Vilnius", "event_1"));
        cities.Add("city_2", new City("city_2", "Kaunas", "event_2"));
    }

    public Event GetEvent(string eventId)
    {
        return events.ContainsKey(eventId) ? events[eventId] : null;
    }

    public void ChooseChoice(Choice choice)
    {
        if (cities.ContainsKey(choice.nextCityId))
        {
            cities[choice.nextCityId].currentEventId = choice.nextEventId;
        }
    }
}