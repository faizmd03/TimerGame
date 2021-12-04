using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TimerGame.Game.view
{
    public class CharacterMovement : MonoBehaviour
    {
        public Rigidbody player;
        public float speed;
        public float rotateSpeed;
        public float axisSpeed;

        Vector3 y;
        Vector3 pos;
        public Collider enemy;
        public Collision enemy1;
        int i = 0, count;
        // Start is called before the first frame update
        void Start()
        {
            pos = this.gameObject.transform.position;

        }
        public void moveForword()
        {
            player.velocity = transform.forward * speed;
        }
        public void moveBackword()
        {
            player.velocity = -transform.forward * speed;
        }
        public void right()
        {
            player.transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, -1, 0), Space.World);
            transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, -1, 0), Space.World);
        }
        public void left()
        {
            player.transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, 1, 0), Space.World);
            transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, 1, 0), Space.World);

        }
        public void sleep()
        {
            player.Sleep();

        }
        

        // Update is called once per frame
        void Update()
        {
            // transform.Rotate((Input.GetAxis("Mouse Y") * axisSpeed * Time.deltaTime), (Input.GetAxis("Mouse X") * axisSpeed * Time.deltaTime), 0, (float)Space.World);


            // transform.Rotate(( Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime) ,0, (float)Space.World);
           // if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
           // {
           //     player.velocity = transform.forward * speed;

           // }
          //  if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
          //  {
          //      player.velocity = -transform.forward * speed;

          //  }
           // if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
          //  {
                // transform.Rotate(2*rotateSpeed * Time.deltaTime * new Vector3(0, -1, 0), Space.World);
            //    player.transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, -1, 0), Space.World);
            //    transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, -1, 0), Space.World);
                // player.position = pos2.transform.position + new Vector3(1.0f, 0.0f, 0.0f) * rotateSpeed * Time.deltaTime;
                //  transform.position = transform.position + new Vector3(1.0f, 0.0f,0.0f)*rotateSpeed * Time.deltaTime;
          //  }
         //  if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
          //  {
          //      player.transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, 1, 0), Space.World);
          //      transform.Rotate(2 * rotateSpeed * Time.deltaTime * new Vector3(0, 1, 0), Space.World);
                //  player.position = pos1.transform.position  + new Vector3(-1.0f, 0.0f, 0.0f) * rotateSpeed * Time.deltaTime;
                //transform.position = transform.position + new Vector3(-1.0f, 0.0f, 0.0f) * rotateSpeed * Time.deltaTime;
         //   }
            
        }

    }
}

