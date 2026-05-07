using System.Collections;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public EventDetailsUI[] allEventDetailsUI;
    public TextMeshProUGUI endInfoText;
    public TextMeshProUGUI stateInfoText;
    public Money moneyStat;
    public GameObject endScreen;
    void Start()
    {
        foreach (var item in allEventDetailsUI)
        {
            item.UpdateTotalStates();
        }
    }

    public void CheckForEndState()
    {
        int militaryBadState = 0;
        int economyBadState = 0;
        int empireState = 0;
        int relationsState = 0;
        int industryState = 0;
        int laborState = 0;
        int socialState = 0;
        int governanceState = 0;
        int treasuryState = 0;
        int allianceState = 0;
        string panelName;
        int badState = 0;
        foreach(var item in allEventDetailsUI)
        {
            foreach(GameManager panel in item.allGameManagersOfPanel)
            {
                switch (panelName = panel.panel.name)
                {
                    case "The Empire":
                        empireState = panel.state;
                        break;
                    case "American Relations":
                        relationsState = panel.state;
                        break;
                    case "Industry":
                        industryState = panel.state;
                        break;
                    case "Labor":
                        laborState = panel.state;
                        break;
                    case "SocialOrder":
                        socialState = panel.state;
                        break;
                    case "Governance":
                        governanceState = panel.state;
                        break;
                    case "Treasury":
                        treasuryState = panel.state;
                        break;
                    case "Alliances":
                        allianceState = panel.state;
                        break;
                    default:
                        break;
                }
                if(panel.state == 0)
                {
                    badState++;
                }
            }
        }
        endScreen.SetActive(true);
        if (badState < 2)
        {
            stateInfoText.text = "Pax Britannica";
            endInfoText.text = "Britain remains the world's absolute hegemon. Peace is enforced by the Treasury and the Fleet.";
            return;
        }
        else if(badState >= 6)
        {
            stateInfoText.text = "The Darkest Hour";
            endInfoText.text = "Total collapse. The fleet is sunk, the economy is gone, and the United Kingdom is no more.";
            return;
        }
        foreach (var item in allEventDetailsUI)
        {
            foreach (GameManager panel in item.allGameManagersOfPanel)
            {
                if (panel.state == 0)
                {
                    badState++;
                }
            }
        }
        foreach(GameManager panel in allEventDetailsUI[3].allGameManagersOfPanel)
        {
            if (panel.state == 0) militaryBadState++;
        }
        foreach (GameManager panel in allEventDetailsUI[2].allGameManagersOfPanel)
        {
            if (panel.state == 0) economyBadState++;
        }

        if(militaryBadState == 0 && economyBadState >= 3)
        {
            stateInfoText.text = "The Fortress State";
            endInfoText.text = "Britain wins the war abroad but becomes a militarized police state to handle domestic collapse.";
            return;
        }
        if(militaryBadState >= 3 && economyBadState == 0)
        {
            stateInfoText.text = "The Neutral Republic";
            endInfoText.text = "Britain abandons the Entente. It is wealthy and peaceful, but Germany dominates the Continent.";
            return;
        }
        if(relationsState == 2 && empireState == 0)
        {
            stateInfoText.text = "The Atlantic Bridge";
            endInfoText.text = "The Empire dissolves, but Britain finds a new future as America's closest democratic ally.";
            return;
        }
        if(industryState == 2 && laborState == 0)
        {
            stateInfoText.text = "The Gilded Factory";
            endInfoText.text = "Wealth flows in, but the streets are in constant revolt. A nation divided by class.";
            return;
        }
        if((laborState == 2 || socialState == 2) && (governanceState == 0 || treasuryState == 0))
        {
            stateInfoText.text = "The Socialist Commonwealth";
            endInfoText.text = "A radical revolution overthrows the old order. Britain exits the war to build a worker's state.";
            return;
        }
        if(empireState == 2 && allianceState == 0)
        {
            stateInfoText.text = "The Global Federation";
            endInfoText.text = "Britain turns away from Europe to form a massive, unified Imperial state with the Dominions.";
            return;
        }
        stateInfoText.text = "Unforeseen ending";
        endInfoText.text = "You managed to find the secret ending. Congrats.";
    }
}
