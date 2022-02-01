using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Detect Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("touch");
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.tag == "Player")
        {
            Debug.Log("touch");
            //Destroy(collision.gameObject);
        }
    }
}
