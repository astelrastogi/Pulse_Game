using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int score;
    public int coinValue;
   
    public GameManager gameManager;
    public AudioSource collectCoin;
    // Start is called before the first frame update
    void Start()
    {
        gameManager=FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Player"){
            gameManager.AddCoins(coinValue);
            Destroy(gameObject);
            collectCoin.Play();
            
        }
      
    
    }
}
