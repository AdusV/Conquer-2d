using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Animator anim;
    bool dirToRight = true;
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float hDirection = Input.GetAxis("Horizontal");
        float vDirection = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hDirection, vDirection) * speed);
        anim.SetFloat("speed", Mathf.Abs(hDirection));
        anim.SetFloat("walk", Mathf.Abs(vDirection));
        



        if (hDirection < 0 && dirToRight) 
        {
            Flip();
        }
        if(hDirection>0 && !dirToRight)
        {
            Flip();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            anim.SetTrigger("attack");
        }
        
        
    }
    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }
}
