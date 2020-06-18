using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YouWon : MonoBehaviour
{
    public GameManager gameManager;
    
    void Start()
    {
        //gameManager=FindObjectOfType<GameManager>();
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other){

        if(other.tag=="Player"){
            gameManager.YouWon();
            other.gameObject.SetActive(false);
        }
    
    }
}
