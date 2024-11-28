using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] int numberOfIterations = 0;
    [SerializeField] float randomNumber;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddNumbers(int a, int b)
    {
        int newNumber;

        newNumber = a + b;

        Debug.Log(newNumber);
    }

    public void MultiplyNumbers(int a, int b)
    {
        int newNumber;

        newNumber = a * b;

        Debug.Log(newNumber);


    }

    public void GetCentripetalAcceleration(float v, float r)
    {
        float centripetalAcceleration;

        centripetalAcceleration = v * v / r;

        Debug.Log(centripetalAcceleration);
    }

    public IEnumerator PrintNewNumber()
    {
        while(numberOfIterations <= 10)
        {
            float newNumber = Random.Range(0, 963418.0f);
            {
                yield return new WaitForSeconds(2.0f);
                numberOfIterations += 1;
                Debug.Log(newNumber);
            }
        }
    }
}

