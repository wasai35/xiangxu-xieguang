using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("** Remove1 : Start() ..");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("** Udaate 帧更新..时间差 = " + Time.deltaTime);
        //
        float speed = 3;
        float distance = speed * Time.deltaTime;
        Vector3 pos = this.transform.localPosition;
        pos.x += 0.02f;
        this.transform.localPosition = pos;
    }
}
