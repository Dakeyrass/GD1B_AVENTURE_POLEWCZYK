using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaque : MonoBehaviour
{
    public BoxCollider2D atk;
    public bool hasWeapon = false;

    public Transform pivot_atk;
    public float offset;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        atk.enabled = false;
        anim = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //AIM
        Vector3 displacement = pivot_atk.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //permet de recup la position de la souris et de la convertir en unit (vu qu'elle est en pixel � l'origine)
        float angle = -Mathf.Atan2(displacement.x, displacement.y) * Mathf.Rad2Deg;
        pivot_atk.rotation = Quaternion.Euler(0, 0, angle + offset);

        if (Input.GetKeyDown(KeyCode.Mouse0) && hasWeapon);
        {
            Attack();
        }
    }

    //Si le joueur rencontre l'arme, il la r�cup�re, elle disparait + il peut attaquer 
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