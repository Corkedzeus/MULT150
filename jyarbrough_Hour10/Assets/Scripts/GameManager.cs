using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float elapsedTime = 0;
    private bool isRunning = false;
    public GoalScript blue, green, orange, red;
    private bool isGameOver = true;



    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        isRunning = true;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
        // Add time to the clock if the game is running
        if (isRunning)
        {
            elapsedTime = elapsedTime + Time.deltaTime;
        }
        if (isGameOver && isRunning)
        {
            isRunning = false;
        }
    }
   
        void OnGUI()
        {
            if (isGameOver)
            {
                Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 75);
                GUI.Box(rect, "Game Over!");
                Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 75, 60, 50);
                GUI.Box(rect2, "Bravo!");
                //Start over
                Rect rect3 = new Rect(Screen.width / 2 - 65, Screen.height / 2 - 50, 130, 40);
                GUI.Box(rect3, "Your Time Was");
                Rect rect4 = new Rect(Screen.width / 2 - 10, Screen.height / 2 - 35, 20, 30);
                GUI.Box(rect4, ((int)elapsedTime).ToString());
            }
        }
}
