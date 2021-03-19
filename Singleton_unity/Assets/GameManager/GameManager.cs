using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text scoretext;
    private Scoretext _scoretext = Scoretext.GetScoretext;/*調用Scoretext之變數*/

    [SerializeField]
    private int score;

    public Button Add, Reduce;
    /*------------------------*/
    public Text moneytext;
	private static Moneytext _moneytext = new Moneytext();/*可以使用Money*/

    [SerializeField]
    private int money;
    /*------------------------*/
    void Awake()
    {
        _scoretext.Initial(scoretext, Add, Reduce);
        _scoretext.ScoreFucntion(score);
       /*-----------------------------------------*/
        _moneytext.Initial(moneytext);
        _moneytext.MoneyFucntion(money);

    }
    public void AddScore()
    {
         score++;
        _scoretext.ScoreFucntion(score);
    }
    public void ReduceScore()
    {
         score--;
        _scoretext.ScoreFucntion(score);
    }
}
