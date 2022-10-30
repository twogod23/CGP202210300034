using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //プレイヤーの指定
    [SerializeField] private GameObject player;
    //的の指定
    [SerializeField] private GameObject ground;
    //的までの高さを定義
    public static float height;
    //プレイヤーの中心からの距離を定義
    public static float resultPosP;
    //結果を表示するテキストを指定
    [SerializeField] private GameObject resultText;

    // Start is called before the first frame update
    void Start()
    {
        //結果を表示するテキストの有効化
        resultText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //高さを計測（プレイヤーのY座標 - 的のY座標 - プレイヤーの高さ）
        height = player.transform.position.y - ground.transform.position.y - 10.0f;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Plane"))
        {
            //プレイヤーの座標を取得
            Vector3 posP = player.transform.position;
            //中心からの距離を測定
            resultPosP = posP.magnitude;

            //PlayerMove.csを無効化
            player.GetComponent<CharacterMove>().enabled = false;
            
            //結果を表示するテキストの有効化
            resultText.SetActive(true);
        }
    }

    //高さを値を提供
    public static float GetHeight()
    {
        return height;
    }
    //中心からの位置を提供
    public static float GetResultPos()
    {
        return resultPosP;
    }
}
