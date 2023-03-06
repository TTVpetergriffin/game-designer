using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Wallrunning : MonoBehaviour
{
    public bool wallrunwork;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        wallrunwork = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            other.gameObject.transform.SetParent(player);
        }
    }
}
