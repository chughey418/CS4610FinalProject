using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(MazeConstructor))]



public class GameController : MonoBehaviour
{
    // initialize variables
    [SerializeField] private FpsMovement player;
    [SerializeField] private Text timeLabel;

    private MazeConstructor generator;

    private DateTime startTime;
    private int timeLimit;
//    private int reduceLimitBy;

    private bool goalReached;



    // start a new game
    void Start() {
        generator = GetComponent<MazeConstructor>();
        StartNewGame();
    }

    private void StartNewGame()
    {
        timeLimit = 60;
        startTime = DateTime.Now;

        StartNewMaze();
    }



    // generate a new maze
    private void StartNewMaze()
    {
        generator.GenerateNewMaze(13, 15, OnStartTrigger, OnGoalTrigger);

        float x = generator.startCol * generator.hallWidth;
        float y = 1;
        float z = generator.startRow * generator.hallWidth;
        player.transform.position = new Vector3(x, y, z);

        goalReached = false;
        player.enabled = true;

        startTime = DateTime.Now;
    }



    // Update is called once per frame
    void Update()
    {
        if (!player.enabled)
        {
            return;
        }
    
        int timeUsed = (int)(DateTime.Now - startTime).TotalSeconds;
        int timeLeft = timeLimit - timeUsed;

        if (timeLeft > 0)
        {
            timeLabel.text = timeLeft.ToString();
        }
        // if you lose
        else
        {
            player.enabled = false;
            SceneManager.LoadScene(2);
        }
    }



    // if the user wins, load win menu
    private void OnGoalTrigger(GameObject trigger, GameObject other)
    {
        goalReached = true;
        Destroy(trigger);
        SceneManager.LoadScene(3);
    }



    private void OnStartTrigger(GameObject trigger, GameObject other)
    {
        if (goalReached)
        {
            player.enabled = false;
//            Invoke("StartNewMaze", 4);
        }
    }
}
