using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool paused;
    void Start()
    {
        paused=false;
    }
    void Update()
    {
        
        
    }
    public void Pause(){
           
                paused=!paused;
            
            if(paused)
            {
                Time.timeScale=0;
            }
            else if(!paused)
            {
                Time.timeScale=1;
            }
        }

    // Update is called once per frame
    
}
