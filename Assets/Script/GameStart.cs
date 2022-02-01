using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pnl_menu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.touchCount == 1)
        //{
        //    Debug.Log("Start Enter S1");
        //    SceneManager.LoadScene("SampleScene");
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Start Enter S1");
        //    SceneManager.LoadScene("SampleScene");
        //}
    }
    public void GoToTestScene()
    {
        SceneManager.LoadScene("test");
    }

    public void GoToSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ClosePnl()
    {
        pnl_menu.SetActive(false);
    }

    public void OpenPnl()
    {
        pnl_menu.SetActive(true);
    }
}
