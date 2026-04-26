
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject backButton;

    public void OpenPanel(GameObject panelToOpen)
    {
        if (panelToOpen.activeSelf)
        {
            panelToOpen.SetActive(false);
            backButton.SetActive(false);

        }
        else
        {
            // ájungia pasirinktà
            foreach (GameObject panel in panels)
            {
                panel.SetActive(false);
            }
            panelToOpen.SetActive(true);
            backButton.SetActive(true);
        }
        // iðjungia visus langus



    }
}
