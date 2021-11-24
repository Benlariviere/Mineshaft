using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionBarre : MonoBehaviour
{
    // Start is called before the first frame update
    public float FeuMax;
    private float FeuActuelle;
    public Image BarreFeu;
    public GameObject Peur;
    void Start()
    {
        FeuActuelle = FeuMax;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FeuActuelle -= 1f;
        BarreFeu.fillAmount = FeuActuelle / FeuMax;
    }
    void GestionPeur()
    {
      /*  if (FeuActuelle < 0)
        {
           Volume GlobalPeur   = gameObject.GetComponent<volume>();
        }
      */
    }
    private void OnTriggerEnter(Collider infosCollision)
    {
        if(infosCollision.gameObject.tag == "Feu")
        {
            FeuActuelle = FeuMax;
            infosCollision.gameObject.SetActive(false);
        }
    }
}
