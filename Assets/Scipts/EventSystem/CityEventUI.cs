using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CityEventUI : MonoBehaviour
{
    public GameObject panel;
    public Text titleText;
    public Text descriptionText;

    public Transform choicesContainer;
    public GameObject choiceButtonPrefab;

    private Manager manager;

    void Start()
    {
        manager = FindObjectOfType<Manager>();
        panel.SetActive(false);
    }

    public void ShowEvent(Event gameEvent)
    {
        panel.SetActive(true);

        titleText.text = gameEvent.title;
        descriptionText.text = gameEvent.description;

        ClearChoices();

        foreach (var choice in gameEvent.choices)
        {
            GameObject btn = Instantiate(choiceButtonPrefab, choicesContainer);

            Text btnText = btn.GetComponentInChildren<Text>();
            btnText.text = choice.text;

            Button button = btn.GetComponent<Button>();
            button.onClick.AddListener(() => OnChoiceClicked(choice));
        }
    }

    void ClearChoices()
    {
        foreach (Transform child in choicesContainer)
        {
            Destroy(child.gameObject);
        }
    }

    void OnChoiceClicked(Choice choice)
    {
        manager.ChooseChoice(choice);
        panel.SetActive(false);
    }
}