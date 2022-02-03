using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mgr : MonoBehaviour
{

    public GameObject BG;
    float move_speed = 15F;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //if(BG.transform.position.y >= -110  && BG.transform.position.y <= 112 )
        //{



            if (transform.position.y <= -349)
            {
            Debug.Log("change ");
                transform.position = new Vector3(transform.position.x,-30, transform.position.z);
            }
            else
            {

            }
            

            transform.Translate(Vector3.down * move_speed * Time.deltaTime, Space.World);

        //}
        

    }
}
