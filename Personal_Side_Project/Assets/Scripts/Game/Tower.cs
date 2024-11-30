using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FirstTowerActivated(int points)
    {
        while(GameManager.Instance.ReturnFirstTowerUnlocked())
        {
            points = player.ReturnPlayerPoints();
            points += 10;
            yield return new WaitForSeconds(10.0f);
        }
        
    }
}
