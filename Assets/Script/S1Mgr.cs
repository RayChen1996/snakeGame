using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1Mgr : MonoBehaviour
{

    public GameObject GenPos;
    public GameObject GenContainer;

    public GameObject S1_background;
    Transform bg_pos;
    public float Max_height, Min_height;

    public bool drawLine;

    private float mapWidth;
    private float mapHeight;
    private float gridWidth;
    private float gridHeight;

    public const int yRow = 10;

    public const int xColumn = 12;

    public GameObject gridGo;


    float move_speed = .5F;
    // Start is called before the first frame update
    void Start()
    {
        Max_height = 4.5F;
        Min_height = -4.7F;
        //S1_background = GetComponent<GameObject>();
        //bg_pos = S1_background.GetComponent<Transform>();
        MakeGridDetectSystem();

    }
    void MakeGridDetectSystem()
    {
        Debug.Log("gen Grid ");
        var space = 2f;
        var tmpX = GenContainer.gameObject.GetComponent<Transform>().position.x;
        //for (int i = 0; i < 9; i++)
        //{
        //    for (int j = 0; j < 9; j++)
        //    {

        //        Vector3 pos = new Vector3( tmpX, 0, 0);

        //        Debug.Log("gen Grid    "  + tmpX + "   "  + j);
        //        Instantiate(GenPos, pos, GenContainer.transform.rotation);
        //        tmpX += j;
        //    }

        //}


        //for (int i = 0; i < 9; i++)
        //{
            
        //    for (int j = 0; j < 9; j++)
        //    {
        //        GameObject itemGo = Instantiate(gridGo, transform.position, transform.rotation);
        //        itemGo.transform.position = 


        //    }
        //    Debug.Log("\r\n");

        //}


    }



    void bg_Control_loop()
    {

        //S1_background.gameObject.transform.position = gameObject.transform.position;
        if(S1_background.transform.position.y  > Max_height)
        {
            S1_background.transform.position -= S1_background.transform.position + new Vector3(0, move_speed * Time.deltaTime, 0);
        }
        else
        {
            S1_background.transform.position = S1_background.transform.position + new Vector3(0, move_speed * Time.deltaTime, 0);
        }
        

    }

    // Update is called once per frame
    void Update()
    {

        bg_Control_loop();
        if (!Application.isPlaying)
        {

            return;
        }
    
    
    }

    void HandlePlayer()
    {


        if (Input.GetKey(KeyCode.W))
        {

            Debug.Log("");


        }


    }
}
