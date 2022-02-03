using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// 垂直輸入量
    /// </summary>
    [SerializeField]
    [Header("垂直輸入量")]
    private float input_V;

    /// <summary>
    /// 水平輸入量
    /// </summary>
    [SerializeField]
    [Header("水平輸入量")]
    private float input_H;
    [SerializeField]
    [Header("結果角度")]
    private float angle_Sum;

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }


    //void FixedUpdate()//固定頻率重複執行
    //{
    //    //接Input.GetAxis("Vertical")及("Horizontal")的回傳值
    //    input_V = Input.GetAxis("Vertical");
    //    input_H = Input.GetAxis("Horizontal");

    //    //用GetAxisRaw判斷是否按到移動鍵，是的話執行以下程式，放開可以保留角度狀態，也能避免NaN的狀況
    //    if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
    //    {
    //        //三角函數計算
    //        angle_Sum = Mathf.Atan2(input_H, input_V) / (Mathf.PI / 180);

    //        //角色轉向
    //        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle_Sum, transform.eulerAngles.z);
    //    }
    //}


}
