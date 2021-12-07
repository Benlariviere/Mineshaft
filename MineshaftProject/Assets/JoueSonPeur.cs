using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueSonPeur : MonoBehaviour
{

    public GameObject Perso;
    public AudioSource audioSource;     // L'AudioSource GameObject 

    public AudioClip SonPeur;
    public AudioClip SonTorcheEteinte;
    public AudioClip SonBouleFeux;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if( Perso.GetComponent<GestionBarre>().FeuActuelle <= 0) {

            GetComponent<AudioSource>().PlayOneShot(SonTorcheEteinte);

            //GetComponent<AudioSource>().PlayOneShot(SonPeur, 1f);

        }


        //GetComponent<AudioSource>().PlayOneShot(footSteps);

    }
}
