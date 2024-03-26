using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public float vie;
    public GameObject cible;
    public float range;
    public float speed;
    private float distance; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, cible.transform.position);
        
        if (distance<range){
            //Debut, cible, vitesse
            transform.position = Vector2.MoveTowards(transform.position, cible.transform.position, speed*Time.deltaTime);
        }
    }
}
