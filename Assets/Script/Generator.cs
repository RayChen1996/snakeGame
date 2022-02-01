using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject[] Cube;
    int backupCIdx = 0;
    int CI = 0;
    public GameObject GenPos1, GenPos2, GenPos3 ;
    private IEnumerator coroutine;

    private bool beingHandled = false;
    void Start()
    {
        //Cube = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //coroutine = WaitAndPrint(50f *Time.time);
        //StartCoroutine(coroutine);

        //Invoke("TestGenerator", 2  );
        if ( /*some case  */ !beingHandled)
        {
            StartCoroutine(HandleIt());
        }
    }

    private IEnumerator HandleIt()
    {
        beingHandled = true;
        Debug.Log("Wait ");
        
        do
        {
            CI = Random.Range(0, Cube.Length);
            if (CI != backupCIdx)
            {
                break;
            }
            
        } while (true );
        Debug.Log("CI " + CI   
            + "backupCIdx  " + backupCIdx);
        Instantiate(Cube[CI],GenPos1.transform.position,GenPos1.transform.rotation);
        
        backupCIdx = CI;
        // process pre-yield
        yield return new WaitForSeconds(5.0f);
        // process post-yield
        beingHandled = false;
    }

    void TestGenerator()
    {
        Debug.Log("Wait " );
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        
         yield return new WaitForSeconds(waitTime);
         
       
    }
}
