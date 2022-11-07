using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BulletPrefab;
    float time = 0f;
    public float destroyTime = 3f;
   // Use this for initialization
    void Start() {

    }

   // Update is called once per frame
    void Update() {
       time += Time.deltaTime;
       
        if (time > 5f) {
            Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
               time = 0;
        }

       
   }

}
