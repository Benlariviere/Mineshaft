using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_controller : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHauteur = 100f;


    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public AudioSource audioSource;     // L'AudioSource du personnage

    public AudioClip footSteps;

    


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);   

        if(isGrounded && velocity.y < 0)  //verifie si le player est au sol
        {
            velocity.y = -2f;

        }

        if (isGrounded && !audioSource.isPlaying && controller.velocity.magnitude > 0)  //condition pour jouer le son de marche
        {
        audioSource.volume = Random.Range(0.01f, 0.05f);
        audioSource.pitch = Random.Range(0.7f, 1f);
        GetComponent<AudioSource>().PlayOneShot(footSteps);
        }
           


        float x = Input.GetAxis("Horizontal");   //d�tecte les imput et apllique la valeur aux axes
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHauteur * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }


                    /* Active la fin */

       private void OnTriggerEnter(Collider infosCollision)
    {
        if(infosCollision.gameObject.tag == "Fin")
        {
            SceneManager.LoadScene("SceneVictoire");
        }

    }
}
