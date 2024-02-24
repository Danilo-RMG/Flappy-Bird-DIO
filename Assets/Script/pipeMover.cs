using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     var Manager = GameManager.Instance;
      if(Manager.IsGameOver())
       {
        return;
       }
        float x = GameManager.Instance.PipeSpeed * Time.fixedDeltaTime;
         transform.position -= new Vector3(x, 0, 0);
          if(transform.position.x <= -GameManager.Instance.pipeX)
           {
            Destroy(gameObject);
           }
    }
}