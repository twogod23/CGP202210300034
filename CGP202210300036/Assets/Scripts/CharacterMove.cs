using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    //Rigidbodyを定義
    private Rigidbody rb;
    //移動方向を決定する座標を定義
    private Vector3 movement;
    //移動距離を決定する係数の指定
    [SerializeField] private float setForce;
    //重力係数の指定
    [SerializeField] private float setGravity;
    //下方向に加える力を決定する係数の指定
    [SerializeField] private float setUnderForce;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーをランダムに配置
        transform.position = new Vector3 (Random.Range(-20.0f, 20.0f), 300.0f, Random.Range(-20.0f, 20.0f));
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //矢印キーで前後左右に移動
        //左右方向の移動
        float moveX = Input.GetAxis("Horizontal");
        //前後方向の移動
        float moveZ = Input.GetAxis("Vertical");
        //移動方向の計算
        movement.Set(moveX, 0, moveZ);
        //ノーマライズ
        movement.Normalize();
        //移動
        rb.velocity = movement * setForce;

        if(Input.GetKey(KeyCode.Space))
        {
            //スペースキーを押した際追加で下方向に力を働かせる
            rb.AddForce(Vector3.down * setGravity * setUnderForce, ForceMode.Force);

            Debug.Log("space");
        }
        else
        {
            //任意の値の重力を設定
            rb.AddForce(Vector3.down * setGravity, ForceMode.Force);
        }
    }
}

