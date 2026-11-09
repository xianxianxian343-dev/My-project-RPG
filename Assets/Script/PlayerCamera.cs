using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;//玩家位置
    public Vector3 offset;//玩家和摄像机的偏移量

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if(player != null)
        {
            transform.position = player.position + offset;//相机位置等于玩家位置加上偏移量


        }
    }



}
