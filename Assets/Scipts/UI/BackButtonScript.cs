using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    public GameObject[] panels;
    public void OnBackClicked()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }

}
