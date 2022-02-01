using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour
{
    public GameObject player;
    float move_speed = 1F;
    bool IsDie = false;
    // Start is called before the first frame update




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -5.54F)
        {
            IsDie = true;
            //Instantiate(player);
            //Destroy(player.gameObject);
            
        }
        player.transform.position = player.transform.position - new Vector3(0, move_speed * Time.deltaTime, 0);
    }
}
