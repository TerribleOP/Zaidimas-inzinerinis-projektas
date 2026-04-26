using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Money : MonoBehaviour
{
    public TMP_Text moneyText;
    public MoneyInt money;
    public GameStateManager gameStateManager;
    void Start()
    {
        money = new MoneyInt(1000);
        moneyText.text = money.getMoney().ToString();
    }

    public void UpdateMoney(int value)
    {
        money.Add(value); 
        UpdateUI();
        gameStateManager.CheckForEndStateMoney();
    }

    void UpdateUI()
    {
        moneyText.text = money.getMoney().ToString();
    }
}
