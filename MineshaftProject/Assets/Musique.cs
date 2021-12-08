using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musique : MonoBehaviour
{

    //AudioClip musique;

    AudioSource AudioSourceMusique;

    // Start is called before the first frame update
    void Start()
    {
        AudioSourceMusique = GetComponent<AudioSource>();
        AudioSourceMusique.Play(0);
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
