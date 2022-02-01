using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenGridBoard : MonoBehaviour
{
    public GameObject Board;
    public GameObject[] cell;
    Transform transform_cell;
    void Start()
    {
        transform_cell = GetComponent<Transform>();
        for (int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                cell[0].name =  i + "_" + j;
                Instantiate(cell[0].gameObject, new Vector3(i+i*1F, j+j*1F, 0), new Quaternion(0, 0, 0, 0)  );
            }
        }
    }

    void Update()
    {
        
    }
}
