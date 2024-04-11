using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory; 
    public GameObject itemButton; 

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Test1");
        if (other.CompareTag("Player")){
            Debug.Log("Test2");
            for (int i=0; i<inventory.slots.Length; i++)
            //length definit le nombre d'elements dans le tableau. ex: i<length
            //on a une variable entiere de depart egale a 0. En tres gros ici il parcourt le tableau autant de fois que le nombre de slots dans l'inventaire du joueur.
                if (inventory.isFull[i] == false){
                    //item peut etre ajoute
                    inventory.isFull[i]=true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Debug.Log("ONE MORE TIME"); 
                    //Pour que l'item button spawn au mm endroit que l'inventory slot ui. 
                    Destroy(gameObject);
                    break;
                }
        }
    }
}
