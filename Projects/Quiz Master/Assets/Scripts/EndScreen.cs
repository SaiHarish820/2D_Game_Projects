using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;



    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        if(scoreKeeper.CalculateScore() >= 70){
        finalScoreText.text = "Congratulation, You Passed the Test!\n You got a Score of " + scoreKeeper.CalculateScore() + "%";
        }
        else{
            finalScoreText.text = "Sorry, You have not Passed the Test!\n You got a Score of " + scoreKeeper.CalculateScore() + "%";
        }
    }


}
