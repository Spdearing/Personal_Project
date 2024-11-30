using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    [Header("Bools")]
    [SerializeField] private bool withinRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MoneyMachine")
        {
            Debug.Log("Can press E");
            withinRange = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MoneyMachine")
        {
            withinRange = false;
        }
    }

    public bool ReturnWithinRange()
    {
        return withinRange; 
    }
}
