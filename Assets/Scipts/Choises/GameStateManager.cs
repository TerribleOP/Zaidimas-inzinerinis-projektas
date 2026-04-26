using System.Collections;
using TMPro;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public EventDetailsUI[] allEventDetailsUI;
    public TextMeshProUGUI endInfoText;
    public TextMeshProUGUI stateInfoText;
    public GameObject endScreen;
    public void CheckForEndState()
    {
        /*foreach (var item in allEventDetailsUI)
        {
            if (item.totalState >= 6)
            {
                endScreen.SetActive(true);
                stateInfoText.text = "You win";
                switch(item.titleText.ToString())
                {
                    case "Military":
                        endInfoText.text =
                            "Your military became the best in the world, no other country could compare...";
                        break;
                    case "Diplomatic state":
                        endInfoText.text =
                            "Diplomatic state is the best(Placeholder)";
                        break;
                    case "Politics":
                        endInfoText.text =
                            "Politics are the best(Placeholder)";
                        break;
                    case "Economy":
                        endInfoText.text =
                            "Economy is the best(Placeholder)";
                        break;
                    default:
                        break;
                }
            }
            if (item.totalState <= 0)
            {
                endScreen.SetActive(true);
                stateInfoText.text = "You lose";
                switch (item.titleText.ToString())
                {
                    case "Military":
                        endInfoText.text =
                            "Military state is the worst(Placeholder)";
                        break;
                    case "Diplomatic state":
                        endInfoText.text =
                            "Diplomatic state is the worst(Placeholder)";
                        break;
                    case "Politics":
                        endInfoText.text =
                            "Politics are the worst(Placeholder)";
                        break;
                    case "Economy":
                        endInfoText.text =
                            "Economy is the worst(Placeholder)";
                        break;
                    default:
                        break;
                }
            }
        }*/
    }
}
