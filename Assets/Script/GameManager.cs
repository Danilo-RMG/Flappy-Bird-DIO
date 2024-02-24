using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager Instance {get; private set;}
  public List<GameObject> Prefabs;
  public float PipeInterval = 1;
  public float PipeSpeed = 10;
  public float pipeX = 10;
  public Vector2 PipeY = new Vector2(0, 0);
  public float skySpeed = 0;

  [HideInInspector]
  public int Score;
  
  [HideInInspector]
  private bool isGameOver = false;    
   void Awake()
     {
      if(Instance != null && Instance != this)
       {
        Destroy(this);
       }
         else
          {
            Instance = this;
          }
       }

  public bool IsGameActive()
   {
    return !isGameOver;
   }
   public bool IsGameOver()
    {
     return isGameOver;
    }
   public void EndGame()
    {
     isGameOver = true;
      StartCoroutine(ReloadScene(2));
    }
   private IEnumerator ReloadScene(float delay)
    {
     yield return new WaitForSeconds(delay);
      string sceneName = SceneManager.GetActiveScene().name;
       SceneManager.LoadScene(sceneName);
    }
}


