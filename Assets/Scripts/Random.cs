

using UnityEngine;

public class Random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("wasai");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale  = transform.localScale  + new Vector3(0, 0, 0.02f);
        //transform.Translate(0, 0, 0.02f);
        //transform.Rotate(0, 0, 0.5f);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D ))
        {
            transform.Translate(0, 0, 0.1f);
        }






    }
}
