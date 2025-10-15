using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playercontroler : MonoBehaviour
{
    public Animator playerAnimator;
    float inputx = 0;
    float inputy = 0;
    public float speed = 2.5f;
    bool isWalking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isWalking = true;
    }

    // Update is called once per frame
    void Update()
    {
         inputx = Input.GetAxis("Horizontal");
         inputy = Input.GetAxis("Vertical");
       Move(inputx, inputy);
    }
     void Move(float x,float y)
    {
        isWalking = (inputx != 0 || inputy != 0);

        if (isWalking)
        {
            var move = new Vector3(inputx, inputy, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("inputx", inputx);
            playerAnimator.SetFloat("inputy", inputy);

        }
        // playerAnimator.SetBool("isWalking", isWalking);

       
    }

    public void attack(Planta planta)
    {
        playerAnimator.SetTrigger("attack");
        planta.TakeDamage(1);
    }

}
