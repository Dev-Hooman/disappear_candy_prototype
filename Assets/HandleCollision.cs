using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Candy1" || collision.gameObject.name == "Candy2" || collision.gameObject.name == "Candy3" || collision.gameObject.name == "Candy4")
        {
            Debug.Log("Collision Detected :)");

            SoundManager.playDisappearSound();
            Destroy(collision.gameObject);

        }
    }
}
