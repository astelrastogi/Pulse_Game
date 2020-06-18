using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;    
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int coins;
    public Text coinText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI youWinText;
    public bool isGameActive;
    public Button restartButton;
    public bool var;
    //public CarController carController;
    public GameObject titleScreen;
    void Start()
    {
     //isGameActive=true;
        var=true;
    }
    public void StartGame(){
        isGameActive=true;
        coinText.text="SCORE: 0";
        titleScreen.gameObject.SetActive(false);
    }
    void Update()
    {
   
    } 
    public void AddCoins(int numberOfCoins)
    {
        coins+=numberOfCoins;
        coinText.text="SCORE: "+coins;
    
    }  
    public void GameOver(){
        if(var==true)
        {
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            isGameActive=false;
        }
        
        
    }
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void YouWon(){
        youWinText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        isGameActive=false;
        var=false;
       //carController.gameObject.SetActive(false);

    }
   
}
