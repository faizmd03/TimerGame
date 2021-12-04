using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace TimerGame.Game.view
{
    public class UiView : MonoBehaviour
    {
        public Text score;
        public GameObject winPanel;
        // Start is called before the first frame update
        void Start()
        {
            score.text = "0";

        }
        public void setScore(int value)
        {
            if(value == 10)
            {
                winPanel.SetActive(true);
                Time.timeScale = 0;
            }
            score.text = value.ToString();
        }
        public void MenuStart()
        {
            SceneManager.LoadScene(0);

        }
        public void Exit()
        
        {
            Application.Quit();  
        }

        // Update is called once per frame
        void Update()
        {


        }
    }
}
