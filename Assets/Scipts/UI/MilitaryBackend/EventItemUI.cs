using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventItemUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    private GameEvent gameEvent;

    public void Setup(GameEvent e)
    {
        gameEvent = e;
        titleText.text = e.title;
    }

    public void OnClick()
    {
        EventManager.Instance.ShowEventDetails(gameEvent);
    }
}