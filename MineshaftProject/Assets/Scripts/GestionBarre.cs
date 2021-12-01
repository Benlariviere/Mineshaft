using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GestionBarre : MonoBehaviour
{
    // Start is called before the first frame update
    public float FeuMax;
    private float FeuActuelle;
    public Image BarreFeu;
    public GameObject Peur;
    public Volume MonVolume;
   // var volume = target.GetComponent<Volume>();
    void Start()
    {
        FeuActuelle = FeuMax;
        MonVolume = Peur.GetComponent<Volume>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FeuActuelle -= 1f;
        BarreFeu.fillAmount = FeuActuelle / FeuMax;
    }
    void GestionPeur()
    {
          if (FeuActuelle < 0)
          {
            ActivationPeur();
          }
        
        

    }
    private void OnTriggerEnter(Collider infosCollision)
    {
        if(infosCollision.gameObject.tag == "Feu")
        {
            FeuActuelle = FeuMax;
            infosCollision.gameObject.SetActive(false);
        }
    }
    void ActivationPeur()
    {
        if (MonVolume.profile.TryGet<Vignette>(out var vignette))
        {
           // vignette.SetActive(true);
            vignette.intensity.overrideState = true;
           // vignette.intensity.value = 2f;
        }
    }
}
