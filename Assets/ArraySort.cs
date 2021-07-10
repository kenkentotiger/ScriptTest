using System;
using UnityEngine;

public class ArraySort : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // array配列を宣言し、初期化する
        int[] array = { 10, 50, 30, 15, 100 };

        // for文を使い、配列を配列数だけ繰り返す。
        for (int i = 0; i < array.Length; i++)
        {
            //配列の各要素の値を少ない方から順番に並べる
            Array.Sort(array);

            //配列値を表示する
            Debug.Log(array[i]);
        }

        // for文を使い、配列を後ろから配列数だけ繰り返す。
        for (int i = 4; i >=0; i--)
        {
            //配列の各要素の値を多い方から順番に並べる
            Array.Sort(array);

            //配列値を表示する
            Debug.Log(array[i]);
        }
    }
}