using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string tagFilter;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) // 1
    {
        Debug.Log(other.tag);
        if (other.CompareTag(tagFilter)) // 2
        {
            Destroy(gameObject); // 3
        }
    }
}
