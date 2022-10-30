using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Distance : MonoBehaviour
{
    //高さを定義
    private float resultPos = 0;
    //テキストを指定
    [SerializeField] private TextMeshProUGUI resultText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //高さをGameDirector.csから取得
        resultPos = GameDirector.GetResultPos();
        //表示するテキストを指定
        resultText.text = "Result : " + resultPos.ToString("f2");
    }
}
