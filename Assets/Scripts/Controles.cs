using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //DEPLACEMENTS
        Vector2 deplacements = new Vector2(horizontal, vertical);
        //On applique la vélocité au rgdbd et on la multiplie par la vitesse souhaitée
        body.velocity = deplacements * speed;

        //flip horizontal
        //NE PAS OUBLIER DE MODIFIER VALEURS QUAND TU L'AGGRANDIRAS: 1f => xf
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1f, 1f);
        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1f, 1f);
        }
        
    }
}
