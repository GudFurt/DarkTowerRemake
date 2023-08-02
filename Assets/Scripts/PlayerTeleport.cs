using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;
    public Transform WorldCamera;
    public GameObject movementScript;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            if(currentTeleporter.GetComponent<Teleporter>().GetDestination().position.y > currentTeleporter.transform.position.y && this.GetComponent<PlayerControler>().isMoving == false){
                this.GetComponent<PlayerControler>().enabled = false;
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                WorldCamera.transform.position = new Vector3(0, WorldCamera.transform.position.y + 10, -10f);
                this.GetComponent<PlayerControler>().enabled = true;
            }
            else if(currentTeleporter.GetComponent<Teleporter>().GetDestination().position.y < currentTeleporter.transform.position.y && this.GetComponent<PlayerControler>().isMoving == false){
                this.GetComponent<PlayerControler>().enabled = false;
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                WorldCamera.transform.position = new Vector3(0, WorldCamera.transform.position.y + (-10), -10f);
                this.GetComponent<PlayerControler>().enabled = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Teleporter")){
            currentTeleporter = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Teleporter")){
            if(other.gameObject == currentTeleporter){
                currentTeleporter = null;
            }
        }
    }
}
