using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fonte : MonoBehaviour
{
    private int index_scene;
    public float fonte_speed;
    public float fonte_time;

    private Animator anim;

    

    public RectTransform fonte_barre;
    public LayerMask safe_zone;

    void Start()
    {
        index_scene = SceneManager.GetActiveScene().buildIndex;
        anim = GetComponent<Animator>();
        
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
        //position, diametre, layermask
        return Physics2D.OverlapCircle(transform.position, 0.5f, safe_zone);
        //overlap permet de d�tecter certains �l�ments dans une zone donn�e.
        //Ici on return � chaque fois pour savoir si oui ou non le jour est dans la safe zone.
    }

    void Melt()
    {
        fonte_barre.localScale = new Vector2(fonte_time / 100f, 1f); 
        //localscale permet de modifier le scale, ici le scale x vu qu'on veut que la barre diminue. 
        fonte_time -= fonte_speed;
        if( fonte_time <= 0)
        {
            fonte_time = 0;
            anim.Play("fonte");
            ResetFonte();
        }
    }

    public void ResetFonte()
    {
        fonte_time = 100f;
        fonte_speed = 0;    
        anim.StopPlayback();

    }

    public void DestroyPlayer()
    {
        SceneManager.LoadSceneAsync(4);
    }
}