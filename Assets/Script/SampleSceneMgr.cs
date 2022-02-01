using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SampleSceneMgr : MonoBehaviour
{

    public Text timeStamp;
    public Text game_status_message;
    public GameObject pnl_game_status;
    DateTime TotalPlayTime ;
    private bool beingHandled = false;
    bool IsDie = false;
    double Sec = 60;
    private TimeSpan ts = TimeSpan.FromSeconds(60);
    // Start is called before the first frame update
    void Start()
    {


        // backslash is used to ":" colon formatting you will not see it in output
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( /*some case  */ !beingHandled && !IsDie)
        {
            StartCoroutine(HandleIt());
        }
        if (IsDie)
        {
            if(Input.touchCount == 1)
            {
                SceneManager.LoadScene("S2");
            }
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("resume menu");
                SceneManager.LoadScene("S2");
            }
        }
    }

    private IEnumerator HandleIt()
    {
        beingHandled = true;
        // process pre-yield


        if (ts.Seconds.Equals(10))
        {
            timeStamp.fontStyle = FontStyle.Bold;
            timeStamp.color = Color.red;
        }
        if (ts.Seconds.Equals(1))
        {
            IsDie = true;
            pnl_game_status.SetActive(true);
        }
        ts = ts.Subtract(TimeSpan.FromSeconds(1));
        timeStamp.text = ts.ToString(@"hh\:mm\:ss");
        yield return new WaitForSeconds(1.0f);
        // process post-yield
        beingHandled = false;
    }


}
