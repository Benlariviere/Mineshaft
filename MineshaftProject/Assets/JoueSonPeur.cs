using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueSonPeur : MonoBehaviour
{

    public GameObject Perso;

    public AudioSource audioSourceTorche;     // L'AudioSource GameObject 
    public AudioSource audioSourcePeur;
    public AudioSource audioSourceFeux;

    public AudioClip SonPeur;
    public AudioClip SonTorcheEteinte;
    public AudioClip SonBouleFeux;

    //private int playHowManyTimes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((Perso.GetComponent<GestionBarre>().FeuActuelle == 0) && !audioSourceTorche.isPlaying) {

           

            GetComponent<AudioSource>().PlayOneShot(SonTorcheEteinte);

            //GetComponent<AudioSource>().enabled = false;

            Invoke("JouePeur", 1f);

        }

        if (Perso.GetComponent<GestionBarre>().FeuActuelle <= 0)
        {

            Invoke("JouePeur", 1f);

        }


        //GetComponent<AudioSource>().PlayOneShot(footSteps);

    }


    void JouePeur()
    {

        GetComponent<AudioSource>().PlayOneShot(SonPeur);
    }
}
