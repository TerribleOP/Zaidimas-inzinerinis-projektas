using UnityEngine;
using TMPro;

public class ChoiceUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    private EventChoice choice;

    public void Setup(EventChoice c)
    {
        choice = c;
        text.text = c.choiceText;
    }

    public void OnClick()
    {
        if (choice == null)
        {
            Debug.LogError("Choice yra NULL!");
            return;
        }

        if (GameStats.Instance == null)
        {
            Debug.LogError("GameStats neegzistuoja!");
            return;
        }
        GameStats.Instance.army += choice.armySizeChange;
        GameStats.Instance.morale += choice.moraleChange;
        GameStats.Instance.supply += choice.logisticsChange;
        GameStats.Instance.training += choice.experienceChange;

        Debug.Log("Choice selected: " + choice.choiceText);
    }
}