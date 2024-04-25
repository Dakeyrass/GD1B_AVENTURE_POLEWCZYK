using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dia_Trigger : MonoBehaviour
{
    public Dialogue dialogue;

    public bool isInRange;
    //indique si le joueur est dans la zone du pnj 
    private Text interacUI;



    // Update is called once per frame
    void Update()
    {
        Debug.Log(interacUI);
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInRange = true;
            interacUI.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
            interacUI.enabled = false;
            Dia_Manager.instance.EndDialogue();
            //si on part, le dialogue se casse aussi 
        }
    }

    private void Awake()//awake c'est quand ça passe d'actif à inactif. 
    {
        interacUI = GameObject.FindGameObjectWithTag("InteracUI").GetComponent<Text>();
    }

    void TriggerDialogue()
    {
        Dia_Manager.instance.StartDialogue(dialogue);
    }
}