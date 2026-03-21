using UnityEngine;
using TMPro;

public class EventButtonUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    private GameEvent gameEvent;

    public void Setup(GameEvent e)
    {
        gameEvent = e;
        text.text = e.title;

    }

    public void OnClick()
    {
        EventManager.Instance.ShowEventDetails(gameEvent);
    }
}