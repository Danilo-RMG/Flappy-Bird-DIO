using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float Cooldown = 0;
    void Start()
    {
    }

    void Update()
    {      
     var Manager = GameManager.Instance;
      if(Manager.IsGameOver())
       {
        return;
       }
     Cooldown -= Time.deltaTime;
      if (Cooldown <= 0f)
       {
        Cooldown = GameManager.Instance.PipeInterval;
         int PrefabsIndex = Random.Range(0, Manager.Prefabs.Count);
          GameObject prefabs = Manager.Prefabs[PrefabsIndex];

           float x = Manager.pipeX;
           float z = 0f;
           float y = Random.Range(Manager.PipeY.x, Manager.PipeY.y);
            Vector3 position = new Vector3(x,y,z);
             Quaternion rotation = prefabs.transform.rotation;
              Instantiate(prefabs, position, rotation);
       }
    }
}
