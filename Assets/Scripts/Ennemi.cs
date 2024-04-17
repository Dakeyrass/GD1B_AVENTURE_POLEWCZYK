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
    private Rigidbody2D rgbd;
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, cible.transform.position);
        
        if (distance<range){
            //(Debut, cible, vitesse)
            transform.position = Vector2.MoveTowards(transform.position, cible.transform.position, speed*Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("atk"))
        {
            vie = vie -1;
                if (vie <= 0)
                {
                    Destroy(rgbd.gameObject);
                }
        }
    }
}
