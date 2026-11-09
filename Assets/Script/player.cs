using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Player : MonoBehaviour
{

    public NavMeshAgent nav;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //nav.SetDestination(targrt);
        if(Input .GetMouseButtonDown(0))
        {
            Debug.Log("鼠标左键点击");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out RaycastHit hit))
            {
                if(hit.collider.CompareTag("Plane"))
                {
                    nav.SetDestination(hit.point);

                }

            }

        }

        if(nav.velocity.magnitude>0.1f)
        {
            anim.SetBool("isRun", true);
        }
        else
        {
            anim.SetBool("isRun", false);
        }

    }
}
