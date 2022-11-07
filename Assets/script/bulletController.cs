using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=0.1f;
    public zombieController _zombieController;
    void Start()
    {
        Destroy(this.gameObject, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0,0,speed));
    }
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Target") {
            Destroy(this.gameObject);
            //collision.gameObject

            
        }
        Destroy(this.gameObject);
    }

}
