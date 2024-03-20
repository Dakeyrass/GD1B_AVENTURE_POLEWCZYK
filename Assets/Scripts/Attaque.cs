using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaque : MonoBehaviour
{
    [SerializeField] private BoxCollider2D atk;
    // Start is called before the first frame update
    void Start()
    {
        atk.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
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
