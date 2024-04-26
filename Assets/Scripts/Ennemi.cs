using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public float vie;
    public GameObject cible, itemAdrop;
    public float range;
    public float speed;
    private float distance;
    private Rigidbody2D rgbd;

    private Animator playerAnimator;
    public GameObject playerObject;
    private Attaque player;

    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        playerAnimator = playerObject.GetComponent <Animator>();
        player = FindObjectOfType<Attaque>();
        cible = GameObject.FindWithTag("Player");
        //je viens chercher le script Attaque afin d'avoir acces a hasWeapon (sinon le joueur pouvait attaquer mm sans l'arme).
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
        if (other.CompareTag("atk") && player.hasWeapon)
        {
            vie = vie -1;
            playerAnimator.SetTrigger("attack");
                if (vie <= 0)
                {
                    Instantiate(itemAdrop,transform.position,Quaternion.identity);
                    gameObject.SetActive(false);
                }
        }
    }
}