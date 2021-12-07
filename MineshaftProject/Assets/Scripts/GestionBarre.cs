using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class GestionBarre : MonoBehaviour
{
    // Start is called before the first frame update
    public float FeuMax;
    private float FeuActuelle;
    public Image BarreFeu;
    public GameObject Peur;
    public GameObject Torch;
    public GameObject Mort;
    public GameObject Perso;
    
    

    //public static bool gameOver;
    


    void Start()
    {
        FeuActuelle = FeuMax;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FeuActuelle -= 20f;
        BarreFeu.fillAmount = FeuActuelle / FeuMax;


        /*------------Gestion peur-------------*/

         
        /*------------augmente la peur-------------*/

        if (FeuActuelle <= 0)
        {
           Torch.SetActive(false);
            
            var volumePeur = Peur.GetComponent<Volume>();

            if (volumePeur.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.intensity.overrideState = true;
                vignette.intensity.value += 0.1f * Time.deltaTime;

                if (vignette.intensity.value >= 1f)
                {
                    //mort du personnage
                    

                    Mort.SetActive(true);

                    Perso.GetComponent<character_controller>().enabled = false;
                    Camera.main.gameObject.GetComponent<Vise>().enabled = false;

                    Invoke("MortPerso",3f);
                }
            }

            if (volumePeur.profile.TryGet<LensDistortion>(out var lensD))
            {
                lensD.intensity.overrideState = true;
                if (lensD.intensity.value <= 0.7f)

                {
                    lensD.intensity.value += 0.1f * Time.deltaTime;
                }
            }
        }

        /*------------reset la peur-------------*/

        if (FeuActuelle >= 0)
        {
            Torch.SetActive(true);
            var volumePeur = Peur.GetComponent<Volume>();

            if (volumePeur.profile.TryGet<Vignette>(out var vignette))
            {
                //vignette.intensity.overrideState = false;
                vignette.intensity.value = 0f;

                
            }

            if (volumePeur.profile.TryGet<LensDistortion>(out var lensD))
            {
                //lensD.intensity.overrideState = false;
                lensD.intensity.value = 0f;
            }
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


     void MortPerso()
    {

        //Time.timeScale = 0;

        SceneManager.LoadScene(0);
        
        
        
        
        
    }
}
