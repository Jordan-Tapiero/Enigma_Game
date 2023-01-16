using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingSwitch : MonoBehaviour
{
    public Light light;
    public float duration = 1.0f;

    Color color0 = new Color(1,0,0,1);
    Color color1 = Color.black;

    private bool boss = false;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {
        BossWeather();
    }

    private void OnTriggerEnter()
    {
        //light.color = (Color.white / 2.0f) * Time.deltaTime;
        boss = !boss;
    }

    private void BossWeather()
    {
        if(boss)
        {
            // set light color
            //float t = Mathf.PingPong(Time.time, duration) / duration;
            light.color = Color.Lerp(color0, color1, Mathf.PingPong(Time.time, 1));
        }
        else
        {
            light.color = Color.white;
        }
    }
}
