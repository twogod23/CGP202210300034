using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //左右方向の移動
        float moveX = Input.GetAxis("Horizontal");
        //前後方向の移動
        float moveZ = Input.GetAxis("Vertical");
        //移動方向の計算
        movement.Set(moveX, 0, moveZ);
        //ノーマライズ
        movement.Normalize();
        //移動
        rb.velocity = movement * 10.0f;
    }
}

