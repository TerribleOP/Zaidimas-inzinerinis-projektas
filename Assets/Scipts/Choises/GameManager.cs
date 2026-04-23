using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject panel; // tavo UI panelis

    public int state = 1; // pradþia - vidutinë

    public TMP_Text panelDescriptionBad;
    public TMP_Text panelDescriptionMedium;
    public TMP_Text panelDescriptionGood;

    public TMP_Text description;

    public EventDetailsUI totalStateManager;
    public GameStateManager gameManager;

    void Start() {
        UpdateText();
    }


    public void ImproveState()
    {
        if (state < 2)
        {
            state++;
        }
        UpdateText();
    }

    public void WorsenState()
    {
        if (state > 0)
        {
            state--;
        }
        UpdateText();

    }

    void UpdateText()
    {
        // èia gali keisti tekstà pagal state
        if (state == 0)
        {
            description.text = panelDescriptionBad.text;
            description.color = Color.red;
        }
        else if (state == 1)
        {
            description.text = panelDescriptionMedium.text;
            description.color = Color.orange;
        }
        else if (state == 2)
        {
            description.text = panelDescriptionGood.text;
            description.color = Color.green;
        }
        totalStateManager.UpdateTotalStates();
        gameManager.CheckForEndState();
    }
}