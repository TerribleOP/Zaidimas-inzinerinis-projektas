using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static GameStats Instance;

    public int army = 100;
    public int morale = 100;
    public int supply = 100;
    public int training = 100;

    void Awake()
    {
        Instance = this;
    }
}