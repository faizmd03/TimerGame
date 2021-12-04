using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TimerGame.Game.view
{
    public class CollisionDetect : MonoBehaviour
    {
        int i, count;
         public UiView uiView;
        private void OnTriggerEnter(Collider enemy)
        {
            if (enemy.gameObject.tag == "Enemy")
            {
                Debug.Log("hit");
                Destroy(enemy.gameObject);
                i = i + 1;
                countpoints(i);
            }
        }
        void countpoints(int j)
        {
            count = count + 1;
            Debug.Log(count);
            uiView.setScore(count);

        }
    }
}