using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    [SerializeField] private int playerPoints;

    [SerializeField] private bool TowerOneUnlocked;
    [SerializeField] private bool TowerTwoUnlocked;
    [SerializeField] private bool TowerThreeUnlocked;
    [SerializeField] private bool TowerFourUnlocked;

    private void Awake()
    {
        playerPoints = 0;
        Debug.Log(playerPoints);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ReturnPlayerPoints()
    {
        return playerPoints;
    }

    public bool ReturnFirstTowerUnlocked()
    {
        return TowerOneUnlocked; 
    }
}
