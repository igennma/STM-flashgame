using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemy : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    private int x;

    [HideInInspector] public int min_x=0, max_x=11;

[SerializeField] Rigidbody2D rb;

    public bool Isturned= false;

    MainMenu mainmenu;

    PlayerDeath playerdeath;

    [SerializeField]
    GameObject ShowText;

     [HideInInspector] public float turnspeed=12;

void Start(){

x=Random.Range(min_x, max_x);

}
    // Update is called once per frame
    void Update()
    {
        if (x== 1)
        {
StartCoroutine(turn(2f));

    }
        else
        StartCoroutine(turn(turnspeed));
    }//update


    void OnTriggerEnter2D(Collider2D Hit)
    {   
        if(Isturned==true)
        return;

        else if (Hit.gameObject.CompareTag("Sky")){
             max_x-=1;
             turnspeed-=2;
                  Difficulty();
            mainmenu=GameObject.FindGameObjectWithTag("Sky").GetComponent<MainMenu>();
             mainmenu.VictoryScene();
             Difficulty();
            Destroy(gameObject);
               


            //LEVELPASS So load the Next LEVEL
           
    }
    }
      


    IEnumerator turn(float seconds)
    {

        yield return new WaitForSeconds(seconds);
       

        anim.Play("mafia");
         ShowText.SetActive(true);
         Isturned = true;



          playerdeath=GameObject.FindGameObjectWithTag("bomb").GetComponent<PlayerDeath>();
          playerdeath.KillPlayer();
               

         // Enemy Turned So call the defeat Scene
           mainmenu=GameObject.FindGameObjectWithTag("Sky").GetComponent<MainMenu>();
             mainmenu.DefeatScene();
    } //enemyturning


   public void MafiaDeath()
   {
       rb.gravityScale+=5;

   }//enemydeathfunction


   void Difficulty(){

     
    if(max_x==0){
    max_x=10;
   
}
   }

}//MainClass

