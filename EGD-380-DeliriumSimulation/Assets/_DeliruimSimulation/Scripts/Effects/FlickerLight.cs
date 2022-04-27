using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light _Light;

    public float MinTime;
    public float MaxTime;
    public float Timer;

    

    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }

    // Update is called once per frame
    void Update()
    {
        FlickeringLight();
    }

    void FlickeringLight()
    {
        if (Timer > 0)
            Timer -= Time.deltaTime;

        if(Timer<=0)
        {
            _Light.enabled = !_Light.enabled;
            Timer = Random.Range(MinTime, MaxTime);
            

        }

    }


}
