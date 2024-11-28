using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text warningText;
    [SerializeField] TMP_Text promptText;

    // Start is called before the first frame update
    void Start()
    {
        SetUpInterface();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetUpInterface()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        warningText = GameObject.Find("WarningText").GetComponent<TMP_Text>();
        scoreText.text = "";
        warningText.text = "";
        promptText.text = "";
    }


    public void SetWarningText(string desiredText)
    {
        warningText.text = desiredText;
    }

    public void SetPrompt(string prompt)
    {
        promptText.text = prompt;
    }
}
