using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; 　　//魔力

    //魔法攻撃をするMagic関数
    public void Magic()
    {
        //mpが5以上の場合
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        //そうでない場合
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();


        //魔法使用の関数を10回呼び出す
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
        lastboss.Magic();
    }

    //Update is called once per frame
    void Update()
    {

    }
}