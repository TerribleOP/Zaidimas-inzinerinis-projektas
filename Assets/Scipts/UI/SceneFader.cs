using System.Collections;
using System.Collections.Generic;
using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneFader : MonoBehaviour
{
    public string SceneName;
    public Image image;
    public float duration;
    public void Start()
    {
        StartCoroutine(FadeOut());
    }
    public void FadeAndLoad(string SceneName, float duration)
    {
        StartCoroutine(Fader(SceneName, duration));
    }
    IEnumerator Fader(string sceneName, float duration)
    {
        float t = 0;
        Color c = image.color;
        while(t<duration)
        {
            t += Time.deltaTime;
            c.a = t / duration;
            image.color = c;
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }

    IEnumerator FadeOut()
    {
        float t = 0;
        Color c = image.color;
        while (t < 1)
        {
            t += Time.deltaTime;
            c.a = 1f - (t / 1f);
            image.color = c;
            yield return null;
        }
    }


}
