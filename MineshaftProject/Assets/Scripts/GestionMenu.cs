using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jouer() // Efface toutes les donn�es du jeu et cr�e une nouvelle partie
    {
       
        SceneManager.LoadScene(1);

    }
    public void QuitterJeu() // Permet de quitter le jeu
    {
        Application.Quit();
        
        
        
    }
}
