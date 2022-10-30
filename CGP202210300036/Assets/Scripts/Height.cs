using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Height : MonoBehaviour
{
    //高さを定義
    private float height = 0;
    //テキストを指定
    [SerializeField] private TextMeshProUGUI heightText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //高さをGameDirector.csから取得
        height = GameDirector.GetHeight();
        //表示するテキストを指定
        heightText.text = "Height : " + height.ToString("f2");
    }
}
