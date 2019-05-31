using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCleaner : MonoBehaviour {

    private GameObject mainCamera;
    private float difference;

    // Use this for initialization
    void Start () {
        this.mainCamera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update () {

        this.transform.position = new Vector3(0, this.transform.position.y, this.mainCamera.transform.position.z);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag"||other.gameObject.tag =="CoinTag"||other.gameObject.tag=="TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}
