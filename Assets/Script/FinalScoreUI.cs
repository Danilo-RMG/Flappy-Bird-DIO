using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class FinalScoreUI : MonoBehaviour
{
  public Text finalScoreText;

   void Update()
    {
     EndGameScore();    
    }
   void EndGameScore()
    {     
     var Manager = GameManager.Instance;
      var FinalScore = GameManager.Instance.Score;
       if(Manager.IsGameOver())
        {  
         finalScoreText.text = "Game Over! Your Score Was " + FinalScore;
          Destroy(this);
        }
    }
}
