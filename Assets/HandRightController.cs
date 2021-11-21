using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRightController : MonoBehaviour
{
    public float speed = 1;
    private Animator animator;
    private bool blood = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(-speed * Time.fixedDeltaTime/50, 0, 0);
        if (this.transform.position.x > 5.5){
            this.transform.position = new Vector3(-5.5f, this.transform.position.y, this.transform.position.z);
        }

        if (blood == true){
            animator.Play("Base Layer.blood_right", 0, 0.25f);
            blood = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        blood = true;
    }
}
