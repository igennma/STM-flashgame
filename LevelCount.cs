using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelCount : MonoBehaviour
{
       static int levelnumber=1;
    public TMP_Text leveltext;
    public void Start(){
        leveltext.text=levelnumber.ToString();
    }

    public void addcount(){
      levelnumber=levelnumber+1;
         
        // Debug.Log(levelnumber);
        

    }
      public void defeatlesscount(){
   
          levelnumber=1;
        leveltext.text=levelnumber.ToString();
     
        
    }
      public void victorylesscount(){

            // levelnumber=levelnumber-1;
        leveltext.text=levelnumber.ToString();
       
        
    }
    void Update()
    {
      if(levelnumber==11)
      {
          levelnumber=1;
      SceneManager.LoadScene(4);
     
 
            }
    }

   }
