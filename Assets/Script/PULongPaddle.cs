using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongPaddle : MonoBehaviour
{
    public Collider2D ball; 
    public float magnitude; 
    public Collider2D PaddleKiri;
    public Collider2D PaddleKanan;
    public PowerUpManager manager;
    

    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        { 
            ball.GetComponent<BolaController>().ActivatePUSpeedUp(magnitude); 
            manager.RemovePowerUp(gameObject);
        }     
    } 
}
