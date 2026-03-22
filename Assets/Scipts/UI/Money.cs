using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Money : MonoBehaviour
{
    public TMP_Text moneyText;
    public MoneyInt money;
    void Start()
    {
        money = new MoneyInt(10000);
        moneyText.text = money.getMoney().ToString();
    }

    void Update()
    {
    }
}
