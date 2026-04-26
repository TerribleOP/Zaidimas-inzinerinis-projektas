using System.Collections.Generic;
using UnityEngine;

public class PanelSequenceManager : MonoBehaviour
{
    public List<GameObject> panels;

    private int currentIndex = 0;

    void Start()
    {
        ShowPanel(currentIndex);
    }

    public void ShowPanel(int index)
    {
        if (panels.Count == 0) return;

        // apsauga
        if (index < 0 || index >= panels.Count) return;

        // iðjungiam visus
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }

        // ájungiam vienà
        panels[index].SetActive(true);

        currentIndex = index;
    }

    public void NextPanel()
    {
        if (currentIndex + 1 >= panels.Count) return;

        currentIndex++;
        ShowPanel(currentIndex);
    }

    public void IncreaseIndex()
    {
        if (currentIndex + 1 < panels.Count)
        {
            currentIndex++;
        }
    }

    public int GetIndex()
    {
        return currentIndex;
    }
}