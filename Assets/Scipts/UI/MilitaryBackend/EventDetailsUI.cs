using UnityEngine;
using TMPro;

public class EventDetailsUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;

    public Transform choicesContainer;
    public GameObject choicePrefab;
    public int totalState;
    public GameManager[] allGameManagersOfPanel;

    private void Start()
    {
        UpdateTotalStates();
    }
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

    public void UpdateTotalStates()
    {
        totalState = 0;
        foreach(GameManager man in allGameManagersOfPanel)
        {
            totalState += man.state;
        }
    }
}