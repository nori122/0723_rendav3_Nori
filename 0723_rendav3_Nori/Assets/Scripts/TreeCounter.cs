using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TreeCounter : MonoBehaviour
{
    // カウント用変数
    public int treeCnt;
    // 結果表示用変数
    public int result;
    // タイマー用変数
    //public int timer;

    // フレーム毎に呼ばれる関数
    void Update()
    {
        // マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            // カウントを減らす
            treeCnt--;
        }

        //カウントをTextコンポーネントへ 
        this.GetComponent<Text>().text = "残り" + treeCnt + "本";

        // もしtimerが500以上になったら
        if (treeCnt == 0)
        {
            // カウントを0に戻す
            //カウントをTextコンポーネントへ
            // this.GetComponent<Text>().text = "結果は" + result + "秒でした";
            SceneManager.LoadScene("ResultScene");
        }
        //else
        //{
        //    result = timer;
        //}
        ////タイマーを増やす
        //timer++;
    }
}