using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventaire : MonoBehaviour
{
    private bool hasKey;
    public Image UI_key;
    public Image lettre;
    public Image UI_potion;
    public Image UI_carte;
     

    // Start is called before the first frame update
    void Start()
    {

        hasKey = false; 
        UI_key.enabled = false;
        lettre.enabled = false; 
        UI_potion.enabled = false; 
        UI_carte.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Affiche_lettre();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Objet"))
        {
            hasKey = true;
            other.gameObject.SetActive(false);
            UI_key.enabled = true;
        }
        if (other.CompareTag("Potion"))
        {
            other.gameObject.SetActive(false);
            UI_potion.enabled = true; 
        }
        if (other.CompareTag("Carte"))
        {
            UI_carte.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Carte"))
        {
            UI_carte.enabled = false; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Porte"  && hasKey)
            {
                Destroy(collision.gameObject);
                UI_key.enabled = false; 
            }
    }

    private void Affiche_lettre()
    {
        if (Input.GetKey(KeyCode.R))
        {
            lettre.enabled = true; 
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            lettre.enabled = false; 
        }

    }
}
