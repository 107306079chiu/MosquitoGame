using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatterBlueController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0, speed * Time.fixedDeltaTime/40, 0);
        if (this.transform.position.y < -5){
            this.transform.position = new Vector3(this.transform.position.x, 5, this.transform.position.z);
        }
    }

}
