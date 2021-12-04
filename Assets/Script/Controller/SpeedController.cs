using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TimerGame.Game.view;

namespace TimerGame.Game.Controller
{


    public class SpeedController : MonoBehaviour
    {
      
       public CharacterMovement characterMovement;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
               
                characterMovement.moveForword();

            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                characterMovement.moveBackword();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
            {
                characterMovement.right();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
            {
                characterMovement.left();
            }
                if ((Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.S)))
            {
                characterMovement.sleep();
            }
            if ((Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.D)))
            {
                characterMovement.sleep();
            }
        }
    }
}