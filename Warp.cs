using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player; //playerが入る変数
    public GameObject WarpOut;//ワープ先が入る変数
    public bool cameraAnimation;//カメラを真偽判定
    public static bool isWarp = false;

    private Vector3 playerp;//プレイヤーのポジションを取得する変数

    void Start()
    {
        //プレイヤーを取得
        player = GameObject.FindGameObjectWithTag("player");
        WarpOut = GameObject.FindGameObjectWithTag("warp");
    }
    // Update is called once per frame
    void Update()
    { 
        playerp = player.transform.position;// Player_transformを取得
        
        if (playerp.x > transform.position.x && playerp.x < transform.position.x + 0.5f)//ワープを通過かつワープ内なら
        {
            if (cameraAnimation == true)//カメラが真（true）なら
            {
                isWarp = true;//カメラアニメーションスイッチをon
                player.gameObject.transform.position = this.transform.position;//アニメーション再生中プレイヤーを制御
            }
            else
            {
                player.gameObject.transform.position = WarpOut.transform.position;//ワープOutにプレイヤーに代入
            }                   
        }
    }
}
