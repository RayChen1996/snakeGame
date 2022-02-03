using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawer : MonoBehaviour
{
    bool isRendering;
    float curtTime = 0F;
    float lastTime = 0F;
    public GameObject Car;
    private float nextActionTime = 0.0f;
    public float period = 1f;
    bool IsDestroy = false;
    // Start is called before the first frame update
    void Start()
    {
        IsDestroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            Debug.Log("Generator Car ");
            SpawonCar();

        }


        Vector2 vec2 = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        if (IsInView(transform.position))
        {
            Debug.Log("目前物體在攝影機範圍內");
        }
        else
        {
            Debug.Log("目前物體不在攝影機範圍內");
            IsDestroy = true;
        }


        //if (IsDestroy)
        //{
        //    Destroy(this.gameObject);
        //}
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
        float dot = Vector3.Dot(camTransform.forward, dir);  //判斷物體是否在攝影機前面

        if (dot > 0 && viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1)
            return true;
        else
            return false;
    }
    void SpawonCar()
    {
        Debug.Log("Generator Car ");
        Instantiate(Car, this.transform.position, this.transform.rotation);
    }
}
