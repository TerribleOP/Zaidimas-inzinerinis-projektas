using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public GameObject detailsPanel;
    public EventDetailsUI detailsUI;

    public Transform upcomingEventsContainer;
    public GameObject eventButtonPrefab;

    private List<GameEvent> events = new List<GameEvent>();

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        CreateTestEvent();
    }
    void CreateTestEvent()
    {
        GameEvent testEvent = new GameEvent();

        testEvent.title = "Prieðas puola miestà";
        testEvent.description = "Reikia reaguoti!";

        testEvent.choices = new EventChoice[1];
        testEvent.choices[0] = new EventChoice()
        {
            choiceText = "Reaguoti",
            armySizeChange = -10,
            moraleChange = -10,
            logisticsChange = -12,
            experienceChange = -12
};

        AddEvent(testEvent);

        GameEvent testEvent1 = new GameEvent();

        testEvent1.title = "Prieðas puola miestà";
        testEvent1.description = "Reikia pasiduoti!";

        testEvent1.choices = new EventChoice[1];
        testEvent1.choices[0] = new EventChoice()
        {
            choiceText = "Pasiduoti",
            armySizeChange = -10,
            moraleChange = -10,
            logisticsChange = -12,
            experienceChange = -12
        };

        AddEvent(testEvent1);
        GameEvent testEvent2 = new GameEvent();

        testEvent2.title = "Prieðas bomborduoja miestà";
        testEvent2.description = "Reikia reaguoti!";

        testEvent2.choices = new EventChoice[1];
        testEvent2.choices[0] = new EventChoice()
        {
            choiceText = "Reaguoti",
            armySizeChange = -10,
            moraleChange = -10,
            logisticsChange = -12,
            experienceChange = -12
        };

        AddEvent(testEvent2);
    }

    public void AddEvent(GameEvent e)
    {
        events.Add(e);

        GameObject obj = Instantiate(eventButtonPrefab, upcomingEventsContainer);
        obj.SetActive(true);
        obj.GetComponent<EventButtonUI>().Setup(e);
    }

    public void ShowEventDetails(GameEvent e)
    {
        detailsPanel.SetActive(true);
        detailsUI.Show(e);
    }
}