using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private Text collectible_counter;
    private int collectible = 0;
    private Rigidbody2D body;
    private BoxCollider2D col;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("");
        if (other.CompareTag("Collectible"))
        {
            collectible += 1;
            collectible_counter.text = "" + collectible;
            Destroy(other.gameObject);
        }
    }
}
