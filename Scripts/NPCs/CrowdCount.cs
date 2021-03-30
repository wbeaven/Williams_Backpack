using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrowdCount : MonoBehaviour
{
    private static CrowdCount _instance;

    public static CrowdCount Instance
    {
        get { return _instance; }
    }

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Object.Destroy(this);
    }

    public float people;
    public bool confrontBully = false;



//___________________________________________________________________
    public Slider slider;
    public Text displayText;
    public Animator loseAnim;
    public Animator winAnim;

    //public float bullyPower = 0;
    private float currentValue = 0;
    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            currentValue = value;
            slider.value = currentValue;
            displayText.text = slider.value.ToString();
        }
    }
    void Start()
    {
        CurrentValue = 500;
    }

    void Update()
    {
        if (confrontBully == true)
        {
            CurrentValue -= Time.deltaTime * 100;
            if (Input.GetKeyDown(KeyCode.Space))
                CurrentValue += 1 + people;
        }

        if (CurrentValue <= 0)
            GameOver();

        if (CurrentValue >= 1000)
            GameWin();

    }

    void GameOver()
    {
        //when the bully beats you show the lose screen and display a "try again" and "exit" buttons
        loseAnim.SetBool("Activate", true);
    }

    void GameWin()
    {
        //When you beat the bully show the win screen and have a "replay" and "exit" buttons
        winAnim.SetBool("Activate", true);
    }
}
