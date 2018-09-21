using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Shoot", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Shoot() {
        Instantiate(bullet, new Vector3(1, 0, 0), Quaternion.identity);
    }
}
