using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject Dust;
    

    //To check collision , in unity we have 2 functions 1)OnCollisionEnter2D  2)OnTriggerEnter2D;


    //EXPLANATION
    //If we have two objects with colliders and one object falls on second object then OnCollisionEnter2D is called.

    //We have IsTrigger option in CircleCollider panel and if we check in that option that means if one object with
    //falls on the second object, it will go through the that object with collider properties. It will not stop by anyother collider.
    //And if we have IsTrigger check then we need to call OnTriggerEn ter2D
 


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotationSpeed);
        // we are rotatiing around the z-axis with speed ie RotationSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            //Destroy(Player); we cant write this cz here I dont have access of object player
            //so we have written the same thing but in different way as shown below:
            Destroy(collision.gameObject);
            GameManager.instance.GameOver();


        }
        else if (collision.gameObject.tag == "Ground")
        {
            GameManager.instance.Score();
            gameObject.SetActive(false);
            GameObject DustParticle=Instantiate(Dust, transform.position, Quaternion.identity);
            Destroy(DustParticle,2f);
            Destroy(gameObject,3f);
        }
    }

}
