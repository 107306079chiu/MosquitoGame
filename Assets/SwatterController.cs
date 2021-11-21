using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatterController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.fixedDeltaTime/50, 0, 0);
        if (this.transform.position.x < -5.5){
            this.transform.position = new Vector3(5.5f, this.transform.position.y, this.transform.position.z);
        }
    }

}
