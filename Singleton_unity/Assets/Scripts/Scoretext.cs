using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoretext   /*不能+MonoBehaviour*/
{
    public Text scoretext;
    public int Scoretextscores;
    private Button Add, Reduce;
    private Scoretext()
    {
    }
    private static Scoretext m_Scoretext;
    public static Scoretext GetScoretext  /*取GetScoretext*/
    {
        get
        {
            if(m_Scoretext == null)
            {
                m_Scoretext = new Scoretext();
            }
            return m_Scoretext;
        }
    }
    public void ScoreFucntion(int scores)
    {
        Scoretextscores = scores;
        scoretext.text = "score"+Scoretextscores.ToString();
    }

    public void Initial(Text _ScoreText, Button Adds , Button Reduces )
    {
        scoretext = _ScoreText;
        Add = Adds;
        Reduce = Reduces;
    }
}
