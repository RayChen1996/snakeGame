using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;//要射出去的障礙物
    float move_speed = 35F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("Fire1"))
        {
            Debug.Log("噴出指但");
            Instantiate(bullet,this.transform.position,this.transform.rotation);



        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * move_speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * move_speed * Time.deltaTime, Space.World);
        }

    }
}
