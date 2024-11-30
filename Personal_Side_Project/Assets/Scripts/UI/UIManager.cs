using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TMP_Text playerPoints;

    [SerializeField] private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        playerPoints = GameObject.Find("PlayersPoints").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void UpdatePlayerPoints(int points)
    {
        points = player.ReturnPlayerPoints();

        playerPoints.text = "Score: " + points; 
    }
}
