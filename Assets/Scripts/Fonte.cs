using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fonte : MonoBehaviour
{
    private int index_scene;
    public float fonte_speed;
    public float fonte_time;

    public RectTransform fonte_barre;
    public LayerMask safe_zone;

    void Start()
    {
        index_scene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(index_scene == 3 && !isnt_melting())
        {
            Melt();
        }
    }

    private bool isnt_melting()
    {
        //postion, diametre, zone
        return Physics2D.OverlapCircle(transform.position, 0.5f, safe_zone);
    }

    void Melt()
    {
        fonte_barre.localScale = new Vector2(fonte_time / 100f, 1f); 
        fonte_time -= fonte_speed;
        if( fonte_time <= 0)
        {
            Destroy(gameObject);
        }
    }
}
