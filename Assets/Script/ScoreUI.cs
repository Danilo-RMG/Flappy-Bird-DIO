using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
 public Text scoreText;
 void Update()
  {
   UpdateScore();
  }
   void UpdateScore()
    {
     var Manager = GameManager.Instance;
      int score = Manager.Score;
      scoreText.text = "" + score;
    }
}
 