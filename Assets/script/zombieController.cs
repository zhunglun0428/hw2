using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class zombieController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Target;
    public GameObject Total;
    public GameObject Kill;
    public float speed=1.0f;
    public bool move = true;
    private Animator animator;
    public TMP_Text totalKill;
    public TMP_Text kill;
    float time = 0.5f;
    int totalKill_;
    int kill_;
    int count=0;
    void Start()
    {
        animator = this.GetComponent<Animator>();
        Target = GameObject.FindWithTag("Player");
        Total = GameObject.FindWithTag("totalkill");
        Kill = GameObject.FindWithTag("kill");
        totalKill = Total.GetComponent<TMP_Text>();
        kill = Kill.GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if(move){
            var direction = Target.GetComponent<Transform>().position - transform.position;//目标方向
            transform.Translate(direction.normalized * Time.deltaTime * speed, Space.World);//向目标方向移动，normalized归一实现匀速移动

            //angle 0-90度正向，90-180度北向
            var angle = Vector3.Angle(transform.forward, direction);//获取夹角
            //或者可以通过点乘获取夹角
            //var deg = Mathf.Rad2Deg * Mathf.Acos(Vector3.Dot(transform.forward.normalized, direction.normalized));
            //由于y轴是朝上的，根据叉乘的y值判断目标在左方还是右方，小于0左方，大于0右方
            var cross = Vector3.Cross(transform.forward, direction);

            var turn = cross.y >= 0 ? 1f : -1f;
            transform.Rotate(transform.up, angle * Time.deltaTime * 5f* turn, Space.World);
        }else{
            Destroy(this.gameObject, 1.0f);
            

        }
        
    }
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "bullet") {
            move = false;
            animator.SetInteger("state",1);
            string str = kill.text;
            bool success = int.TryParse(str, out kill_);
            //kill_ = Convert.ToInt32(kill.text);
            if(count==0){
                kill_++;
                kill.text=kill_+"";
                str=totalKill.text;
                success = int.TryParse(str, out totalKill_);
                //totalKill_ = Convert.ToInt32(totalKill.text);
                totalKill_++;
                totalKill.text=totalKill_+"";
                count++;
            }
            
            //collision.gameObjec   
        }
        //Destroy(this.gameObject);
    }
    
    
    
}
