using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator2 : MonoBehaviour
{
    //gatePrefabを入れる
    public GameObject gatePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;

    void Start()
    {
        //一定の距離ごとにゲートを生成
        for (int i = startPos; i < goalPos; i += 15)
        {
            GameObject gate = Instantiate(gatePrefab) as GameObject;
            gate.transform.position = new Vector3(0, gate.transform.position.y, i - 50);
        }
    }

    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {

    }
}