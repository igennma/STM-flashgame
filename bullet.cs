using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{   
        [SerializeField]
    private float speed;
 [SerializeField] private float lifetime;   
    
  [SerializeField] private GameObject Blood;

    void Start(){ 
        
        Invoke("Destroybullet",lifetime);

    }//start

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);


    }//update

    void OnTriggerEnter2D(Collider2D hitinfo){
 
        enemy enemy=hitinfo.GetComponent<enemy>();

        if(enemy!=null && enemy.Isturned== false){
          FindObjectOfType<AudioManager>().Play("blood");
              enemy.MafiaDeath();
           Kill(); 
        }

    }//triggercollision



void Destroybullet(){
Destroy(gameObject);
}//bulllet destroy



void Kill()
{
    Instantiate(Blood , transform.position , Quaternion.identity);
   
    Destroybullet();
}

}//enemydestroyfunction
