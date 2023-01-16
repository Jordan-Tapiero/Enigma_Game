using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyProgress : MonoBehaviour
{
    // private int Score;
    // public Text ScoreText;
    private int maximum = 1;
    private int current = 0;
    public Image mask;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
        if(enemy.active){
            current = 0;
        }
        else{
            current = 1;
            // addScore();
        }
    }
    // void addScore(){
    //     Score = Score + 1000;
    //     ScoreText.text = Score.ToString();
    // }
    void GetCurrentFill(){
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
    }
}
