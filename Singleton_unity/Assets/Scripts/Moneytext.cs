using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Moneytext   /*不能+MonoBehaviour*/
{
    public Text moneytext;
    public int moneytextmoney;
    public void MoneyFucntion(int moneys)
    {
        moneytextmoney = moneys;
        moneytext.text = "money" + moneytextmoney.ToString();
    }
    public void Initial(Text _MoneyText )
    {
        moneytext = _MoneyText;
    }

}
