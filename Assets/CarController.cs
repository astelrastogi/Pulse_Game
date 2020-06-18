using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    bool move = false;
    bool isGrounded =false;
    public float speed =30f;
    public float rotationSpeed=7f;
    public Rigidbody2D rb;
    public GameManager gameManager;
    
    
    void Start(){
        Vector3 pos=transform.position;
    }
    
    private void Update()
    {
        
            if(Input.GetButtonDown("Fire1"))
            {
                move = true;
            }
            if(Input.GetButtonUp("Fire1"))
            {
                move= false;
            }
        
        
            
        
        if(transform.position.y<-10f){
            gameManager.GameOver();
            
        }
    }
    private void FixedUpdate()
    {
        if(gameManager.isGameActive){
            if (move == true)
            {
                if(isGrounded){
                    rb.AddForce(transform.right*speed*Time.fixedDeltaTime*100f,ForceMode2D.Force);
                }
                else{
                    rb.AddTorque(rotationSpeed *rotationSpeed * Time.fixedDeltaTime * 100f,ForceMode2D.Force);
                }
            }
        }
        
    }
    private void OnCollisionEnter2D()
    {
        isGrounded=true;
    }
    private void OnCollisionExit2D()
    {
        isGrounded=false;
    }
    

}
