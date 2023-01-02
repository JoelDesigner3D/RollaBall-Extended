using System.Collections;
using System.Collections.Generic;

using UnityEngine;
//using UnityEngine.Debug;

public class Bumper : MonoBehaviour
{
   // [SerializeField] float bounceAmount = 300f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision detected !");
        }
    }
}
