using UnityEngine;
using TMPro;

public class SituationManager : MonoBehaviour
{
    public GameObject panel; // tavo UI panelis

    private int state = 1; // pradþia - vidutinë

    public TMP_Text BadTitle;
    public TMP_Text BadDescription;
    public TMP_Text MediumTitle;
    public TMP_Text MediumDescription;
    public TMP_Text GoodTitle;
    public TMP_Text GoodDescription;
    public TMP_Text Title;
    public TMP_Text Description;
    public TMP_Text ButtonName;

    void Start()
    {
        switch (state)
        {
            case 0:
                Title.text = BadTitle.text;
                Description.text = BadDescription.text;
                ButtonName.text = BadTitle.text;
                ButtonName.color = Color.red;
                break;
            case 1:
                Title.text = MediumTitle.text;
                Description.text = MediumDescription.text;
                ButtonName.text = MediumTitle.text;
                ButtonName.color = Color.orange;
                break;
            case 2:
                Title.text = GoodTitle.text;
                Description.text = GoodDescription.text;
                ButtonName.text = GoodTitle.text;
                ButtonName.color = Color.green;
                break;
            default:
                break;
        }
    }

    public void ShowPanelWithText()
    {
        panel.SetActive(true);
        switch (state)
        {
            case 0:
                Title.text = BadTitle.text;
                Description.text = BadDescription.text;
                ButtonName.text = BadTitle.text;
                ButtonName.color = Color.red;
                break;
            case 1:
                Title.text = MediumTitle.text;
                Description.text = MediumDescription.text;
                ButtonName.text = MediumTitle.text;
                ButtonName.color = Color.orange;
                break;
            case 2:
                Title.text = GoodTitle.text;
                Description.text = GoodDescription.text;
                ButtonName.text = GoodTitle.text;
                ButtonName.color = Color.green;
                break;
            default:
                break;
        }
    }

    public void ImproveState()
    {
        if (state < 2)
        {
            state++;
            Debug.Log("Pagerinta: " + state);
            ShowPanelWithText();
        }
    }

    public void WorsenState()
    {
        if (state > 0)
        {
            state--;
            Debug.Log("Pabloginta: " + state);
            ShowPanelWithText();
        }
    }
}