using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaque : MonoBehaviour
{
    [SerializeField] private BoxCollider2D atk;
    private bool hasWeapon = false;
    // Start is called before the first frame update
    void Start()
    {
        atk.enabled = false;
        hasWeapon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hasWeapon);
        {
            Attack();
        }
    }

    //Si le joueur rencontre l'arme, il la récupère, elle disparait + il peut attaquer (waw)
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Arme"))
        {
            hasWeapon = true;
            //et pouf plus d'arme sur la map
            other.gameObject.SetActive(false);
        }
    }

    private void Attack()
    {
        atk.enabled = true;
    }
    public void AttackEnd()
    {
        atk.enabled = false;
    }
}
