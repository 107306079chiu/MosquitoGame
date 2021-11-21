using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosquitoController : MonoBehaviour
{
    public float speed=30;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            animator.SetInteger("state", 1);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            animator.SetInteger("state", 1);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            animator.SetInteger("state", 1);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            animator.SetInteger("state", 1);
        }
        if (!Input.GetKey(KeyCode.W) & !Input.GetKey(KeyCode.S) & !Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D)){
            animator.SetInteger("state", 0);
        }

        if (dirx*transform.localScale.x < 0){
            this.transform.localScale = new Vector3(-1*this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        GameObject.Find("GameManager").GetComponent<GameManager>().dead();
        transform.position = new Vector3(-5f, 3.5f, 0f);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player"){
            GameObject.Find("GameManager").GetComponent<GameManager>().addScore(10);
        }        
    }


}
