using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOperator : MonoBehaviour
{

    [Header("UI")]
    public Text Score;
    int score = 0;

    [Header("")]
    public GameObject player;
    public float move_speed = 5f;
    private Vector2 position;
    private Vector2 target;
    void Start()
    {
        target = new Vector2(0.0f, 0.0f);
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 vector2 = Input.mousePosition;
            Debug.Log(vector2.x + "  " + vector2.y);
            float step = move_speed * Time.deltaTime;
            if(vector2.x < 1129 && vector2.x > 102)
            {
                if (vector2.x > 629)
                {               
                    player.transform.Translate(Vector3.right * move_speed * Time.deltaTime, Space.World);
                }
                else
                {               
                    player.transform.Translate(Vector3.left * move_speed * Time.deltaTime, Space.World);                  
                }
            }
           
        }
        if (Input.GetMouseButtonDown(0))
        {
         
            
        }



        if(Input.touchCount == 1)
        {
            if(Input.touches[0].phase == TouchPhase.Moved)
            {
                Debug.Log("¥¿¦b²¾°Ê");
                //player.transform.position = new Vector2(-2* move_speed*Time.deltaTime, 0);



            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("touch enemy2 !!!!");
            score += 1;
            Score.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("touch enemy !!!!");
            Destroy(collision.gameObject);
        }
    }
}
