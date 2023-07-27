using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEntrance : MonoBehaviour
{

    public float coordX;
    public float coordY;
    public GameObject player;
    
    private void OnTriggerEnter2D(Collider2D other){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
        player.transform.position = new Vector2(coordX, coordY);
        
    }
}
