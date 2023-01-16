using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondProgress : MonoBehaviour
{
    private int maximum = 2;
    private int current = 0;
    public Image mask;
    public GameObject diamond1;
    public GameObject diamond2;
    public int Score;
    public Text ScoreText;
    

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        GetCurrentFill();
        // if(diamond1.active && diamond2.active && diamond3.active){
        //     current = 0;
        // }
        // if(!diamond1.active && diamond2.active && diamond3.active){
        //     current = 1;
        // }
        // if(diamond1.active && !diamond2.active && diamond3.active){
        //     current = 1;
        // }
        // if(diamond1.active && diamond2.active && !diamond3.active){
        //     current = 1;
        // }
        // if(!diamond1.active && !diamond2.active){
        //     current = 2;
        // }
        // if(!diamond2.active && !diamond3.active){
        //     current = 2;
        // }
        // if(!diamond1.active && !diamond2.active && !diamond3.active)
        //     current = 3;
        // }
       if(diamond1.active && diamond2.active){
           current = 0;
       }
       if(!diamond1.active || !diamond2.active){
           current = 1;
           addScore();

       }
       if(!diamond1.active && !diamond2.active){
           current = 2;
           addScore();
       }


    }
    void addScore(){
        Score = Score + 200;
        ScoreText.text = Score.ToString();
    }
    void GetCurrentFill(){
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
    }


}

