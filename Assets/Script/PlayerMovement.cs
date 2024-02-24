using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public Rigidbody MyRigidibody;
   public float JumpPower = 10;
   public float JumpInterval = 0.5f;
   public float JumpCooldown = 0;
    void Start()
     {
      MyRigidibody = GetComponent<Rigidbody>();
     }
    void Update()
     {
      JumpCooldown -= Time.deltaTime;
       bool isGameActive = GameManager.Instance.IsGameActive();
        bool CanJump = JumpCooldown <= 0 && isGameActive;
         if (CanJump)
          {
           bool JumpInput = Input.GetKey(KeyCode.Space);
            if(JumpInput)
             {
              Jump();
             }
          }
           MyRigidibody.useGravity = isGameActive;
     }
    private void Jump()
     { 
      JumpCooldown = JumpInterval;
       MyRigidibody.velocity = Vector3.zero;
        MyRigidibody.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);
     }
    void OnCollisionEnter(Collision other)
     {
      OnCustomCollisionEnter(other.gameObject);
     }
      void OnTriggerEnter(Collider other)
       {
        OnCustomCollisionEnter(other.gameObject);
       }
       void OnCustomCollisionEnter(GameObject other)
        {
         bool isSensor = other.CompareTag("Sensor");
          if (isSensor)
           {
            GameManager.Instance.Score++;
             Debug.Log("Score:" + GameManager.Instance.Score);
           }
            else
             {
              GameManager.Instance.EndGame();
             }  
        }

}
