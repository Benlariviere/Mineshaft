using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class essaiVolume : MonoBehaviour
{
    private Volume monVolume;
    public GameObject target;
    public Slider maGlissiere;

    void Start()
    {

        monVolume = target.GetComponent<Volume>();
       
    }

    private void Update()
    {
        if (monVolume.profile.TryGet<Bloom>(out var bloom))
        {
            bloom.intensity.overrideState = true;
            bloom.intensity.value = maGlissiere.value;
        }
    }


}
