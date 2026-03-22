using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.Audio;
public class PauseMenuScript : MonoBehaviour
{
    public GameObject Menu;
    public void OnEscape()
    {
        if (Menu.activeSelf==false)
        {
            Menu.SetActive(true);
        }
        else
        {
            Menu.SetActive(false);
        }
    }
    public void QuitToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
