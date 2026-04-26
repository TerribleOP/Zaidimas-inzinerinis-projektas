using UnityEngine;
using UnityEngine.Rendering;

public class MoneyInt
{
    private int money;

    public MoneyInt()
    {
        MoneyInt money = new MoneyInt(1000);
    }
    public MoneyInt(int money)
    {
        this.money = money;
    }

    public int getMoney() { return this.money; }
    public void Add(int money) { this.money += money; }
}
