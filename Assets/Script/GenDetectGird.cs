using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenDetectGird : MonoBehaviour
{
    [Header("從哪個開始POS生成")]
    public GameObject GenPos;
    public GameObject GenContainer;
    bool IsDestroy = false;


    void Start()
    {

        //MakeGridDetectSystem();
    }



    /// <summary>
    /// 
    /// </summary>
    void MakeGridDetectSystem()
    {
        var space = 2f;
        for(int i = 0; i < 9; i++)
        {
          for(int j = 0; j < 9; j++)
            {

                Vector3 pos = new Vector3(GenContainer.gameObject.GetComponent<Transform>().position.x, 0, 0);
                Debug.DrawLine(pos, pos);
                Instantiate(GenPos, pos, GenContainer.transform.rotation);
            }
 
        }             
    }


    void Update()
    {
        
    }
}
