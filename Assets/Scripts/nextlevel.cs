using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            if(GameObject.FindGameObjectsWithTag("Enemy").Length <= 0){
                 SceneManager.LoadScene(3);
            }
        }
    }
}
