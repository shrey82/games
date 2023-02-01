using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slopeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerMovement playerMovement;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerMovement.speed = 1f;
        Debug.Log("on slope");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerMovement.speed = 10f;
    }
}
