using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class TimeCountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime = 60f;
    public float currentTime=0f ;
    public TMP_Text timeText;
    public TMP_Text gameOverText;
    public GameObject gameOver;
    //public GameObject player;
    public TMP_Text kill;
    void Start()
    {
        currentTime=startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1*Time.deltaTime;
        int c = (int)currentTime;
        timeText.text = c.ToString();
        if(currentTime<=0){
            c= 0;
            timeText.text = c.ToString();
            StartCoroutine("gameOver_");
            if(Input.GetKeyDown(KeyCode.Space)){
                gameOver.SetActive(false);
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public IEnumerator gameOver_(){
        gameOver.SetActive(true);
            //player.SetActive(false);
        gameOverText.text = "You Kill "+kill.text+" zombies\nPut space to restart";
        
       yield return null;
        
        //yield return null;
    }
    public void Click(){
        
    }
}
