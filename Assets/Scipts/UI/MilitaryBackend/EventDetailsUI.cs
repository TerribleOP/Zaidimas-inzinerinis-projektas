using UnityEngine;
using TMPro;

public class EventDetailsUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;

    public Transform choicesContainer;
    public GameObject choicePrefab;

    public void Show(GameEvent e)
    {

        titleText.text = e.title;
        descriptionText.text = e.description;

        // iðvalom senus mygtukus
        foreach (Transform child in choicesContainer)
            Destroy(child.gameObject);

        // sukuriam naujus
        foreach (var choice in e.choices)
        {
            GameObject obj = Instantiate(choicePrefab, choicesContainer);
            obj.SetActive(true);
            obj.GetComponent<ChoiceUI>().Setup(choice);
        }
    }
}