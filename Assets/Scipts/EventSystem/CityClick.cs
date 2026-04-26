using UnityEngine;

public class CityClick : MonoBehaviour
{
    public string cityId;
    public Manager manager;

    public void OnCityClicked()
    {
        City city = manager.cities[cityId];
        Event gameEvent = manager.GetEvent(city.currentEventId);

        ShowEvent(gameEvent);
    }

    void ShowEvent(Event gameEvent)
    {
        Debug.Log(gameEvent.title);
        Debug.Log(gameEvent.description);

        foreach (var choice in gameEvent.choices)
        {
            Debug.Log("Choice: " + choice.text);
        }
    }
}