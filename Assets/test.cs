using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5]; //変数arrayの宣言＆arrayという名の5要素配列を定義
        array[0] = 64; // 5要素それぞれ定義
        array[1] = 38;
        array[2] = 65;
        array[3] = 75;
        array[4] = 87;


        for (int x = 0; x <= 4; x++)
        {
            Debug.Log (array[x]);
        }

        for (int x = 4; x >= 0; x--)
        {
            Debug.Log(array[x]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
