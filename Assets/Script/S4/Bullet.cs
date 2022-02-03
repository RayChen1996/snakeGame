using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float move_speed = 150F;
    bool isRendering ;
    float curtTime = 0F;
    float lastTime = 0F;
    public int StayRoadCell = 0;//�n���d�b����������m
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnWillRenderObject()
    {
        curtTime = Time.time;
    }
    public bool IsInView(Vector3 worldPos)
    {
        Transform camTransform = Camera.main.transform;
        Vector2 viewPos = Camera.main.WorldToViewportPoint(worldPos);
        Vector3 dir = (worldPos - camTransform.position).normalized;
        float dot = Vector3.Dot(camTransform.forward, dir);  //�P�_����O�_�b��v���e��

        if(dot > 0 && viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >=0 && viewPos.y <= 1)
            return true;
        else
            return false;
    }
    // Update is called once per frame
    void Update()
    {
       

       
        transform.Translate(Vector3.left * move_speed * Time.deltaTime, Space.World);

        Vector2 vec2 = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        if (IsInView(transform.position))
        {
            Debug.Log("�ثe����b��v���d��");
        }
        else
        {
            Debug.Log("�ثe���餣�b��v���d��");
            Destroy(this.gameObject);
        }
    }
}
