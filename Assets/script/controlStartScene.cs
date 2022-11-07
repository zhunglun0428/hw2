using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controlStartScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject s1;
    public GameObject s2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click1(){
        s1.SetActive(false);
        s2.SetActive(true);
    }
    public void click2(){
        SceneManager.LoadScene("SampleScene");
    }
}
