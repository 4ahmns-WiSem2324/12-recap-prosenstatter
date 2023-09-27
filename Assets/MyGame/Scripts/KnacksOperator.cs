using UnityEngine;
using UnityEngine.UI;

public class KnacksOperator : MonoBehaviour
{
    public float timeLimit = 3.1f; 
    public Text targetNumberText; 
    private float countdownTimer; 
    public int targetNumber; 
    public bool gameStarted = false;

    public bool keypad1 = false;
    public bool keypad2 = false;
    public bool keypad3 = false;
    public bool keypad4 = false;
    public bool keypad5 = false;
    public bool keypad6 = false;
    public int spaceInt = 0;

    public int highScore = 0;


    private void Start()
    {
        
        countdownTimer = timeLimit;
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            keypad1 = true;
        }
        else
        {
            keypad1 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            keypad2 = true;
        }
        else
        {
            keypad2 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            keypad3 = true;
        }
        else
        {
            keypad3 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            keypad4 = true;
        }
        else
        {
            keypad4 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            keypad5 = true;
        }
        else
        {
            keypad5 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            keypad6 = true;
        }
        else
        {
            keypad6 = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceInt = 9;
        }
        else
        {
            spaceInt = 0;
        }



        if (gameStarted)
        {
            
            countdownTimer -= Time.deltaTime;

           


            if (keypad1 == true && targetNumber == 1 ||
                keypad2 == true && targetNumber == 2 ||
                keypad3 == true && targetNumber == 3 ||
                keypad4 == true && targetNumber == 4 ||
                keypad5 == true && targetNumber == 5 ||
                keypad6 == true && targetNumber == 6)
            {
                StartGame();
                Debug.Log("worked");
                highScore += 1;
            }
            else if (keypad1 == true && targetNumber != 1 ||
                    keypad2 == true && targetNumber != 2 ||
                    keypad3 == true && targetNumber != 3 ||
                    keypad4 == true && targetNumber != 4 ||
                    keypad5 == true && targetNumber != 5 ||
                    keypad6 == true && targetNumber != 6)
            {
                targetNumberText.text = "You Lose, Press Space to restart" +
                "Score: " + highScore.ToString();
                Debug.Log("wrong emote");
                targetNumber = 9;
                
            }



            


            if (countdownTimer <= 0 )
            {
                Debug.Log("Time's up! You lose.");
                targetNumberText.text = "You Lose, Press Space to restart " +
                "Score: " + highScore.ToString(); 
                targetNumber = 9;

            }
            if (spaceInt == targetNumber)
            {
                StartGame();
                Debug.Log("Restart");
                timeLimit = 3.1f;
                countdownTimer = 3;
            }
        }
    }

    private void StartGame()
    {
        
        targetNumber = Random.Range(1, 7);


        targetNumberText.text = "Target: " + targetNumber;


        if (timeLimit >= 0.8f)
        {
            timeLimit -= 0.05f;
        }

        countdownTimer = timeLimit;

        gameStarted = true;
    }
}


