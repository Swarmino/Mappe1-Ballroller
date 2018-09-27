using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HazardIdentifier : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
