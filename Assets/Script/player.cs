using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Player : MonoBehaviour
{

    public NavMeshAgent nav;
    

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 120;
        
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
    }
}
