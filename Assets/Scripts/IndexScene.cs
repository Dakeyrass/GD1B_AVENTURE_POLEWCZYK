using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IndexScene : MonoBehaviour
{
    public int scene_index;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            SceneManager.LoadSceneAsync(scene_index);
            if(scene_index == 2){
                Destroy(other.gameObject);
            }
            
        }
    }
}
