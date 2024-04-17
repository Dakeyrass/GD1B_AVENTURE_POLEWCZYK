using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    private bool hasKey;
    public Image UI_key;

    // Start is called before the first frame update
    void Start()
    {
        
        hasKey = false;
        //sert pour plus tard quand utilisation de la clé
        UI_key.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Objet"))
        {
            hasKey = true;
            other.gameObject.SetActive(false);
            UI_key.enabled = true; 
        }
    }

    void UsingKey()
    {

    }
}
