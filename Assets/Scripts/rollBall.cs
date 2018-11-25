using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollBall : MonoBehaviour {
    Vector3 m_Rotation;

	private void Start()
    {
        
        m_Rotation = new Vector3(Random.Range(-360f, 360f) * Time.deltaTime,
                         Random.Range(-360f, 360f) * Time.deltaTime,
                         Random.Range(-360f, 360f) * Time.deltaTime);
	}


    public void changeRotation(){
        
        Start();

    }

	
	void Update () {
        
        transform.Rotate(m_Rotation);

	}
}
