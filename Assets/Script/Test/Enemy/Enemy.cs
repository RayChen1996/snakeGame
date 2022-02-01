using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject[] Gen_pos;
    public bool beingHandled = false;
    int backupCIdx = 0;
    int CI = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            CI = Random.Range(0, enemy.Length);
            if (CI != backupCIdx)
            {
                break;
            }

        } while (true);
        Debug.Log("CI " + CI
            + "backupCIdx  " + backupCIdx);
        Instantiate(enemy[CI], Gen_pos[CI].transform.position, Gen_pos[CI].transform.rotation);

        backupCIdx = CI;
        // process pre-yield
        yield return new WaitForSeconds(5.0f);
        // process post-yield
        beingHandled = false;
    }


}
