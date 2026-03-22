using UnityEngine;
using UnityEngine.Rendering;

public class MoneyInt
{
    private int money;

    public MoneyInt()
    {
        MoneyInt money = new MoneyInt(10000);
    }
    public MoneyInt(int money)
    {
        this.money = money;
    }

    public int getMoney() { return this.money; }
    public void setMoney(int money) { this.money = money; }
}
