using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementSceneFin : MonoBehaviour
{
    public string ProchainScene;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMenu",2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadMenu () {
        SceneManager.LoadScene("SceneJeuFinal1");
      }
      
}
   