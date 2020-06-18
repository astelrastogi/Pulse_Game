using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;
    public GameManager gameManager;
    void Start()
    {
        button=GetComponent<Button>();
        button.onClick.AddListener(Startgame);
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Startgame(){
        gameManager.StartGame();
    }
}
