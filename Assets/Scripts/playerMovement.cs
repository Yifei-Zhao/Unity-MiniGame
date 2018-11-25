using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 10f;
    private bool isPinned = false;

	
	void Update () 
    {
        if(!isPinned){
            rb.MovePosition(rb.position + Vector3.forward * speed * Time.deltaTime);
        }
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag=="ball"){
            transform.SetParent(other.transform);
            isPinned = true;
            other.GetComponent<rollBall>().changeRotation();
            Score.pinCount++;
        }
        if (other.tag == "eye")
        {
            FindObjectOfType<GameManager>().EndGame();

        }
        if (other.tag == "mouth")
        {

            FindObjectOfType<GameManager>().EndGame();
        }
	}

  
}
