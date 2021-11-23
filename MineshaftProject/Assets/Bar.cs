using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class Bar : MonoBehaviour
{

    public GameObject bar;
    public int time;
    public int vie;

    // Start is called before the first frame update
    void Start()
    {
        AnimBar();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimBar()
    {
        LeanTween.scaleX(bar, -1, time);

    }


}
