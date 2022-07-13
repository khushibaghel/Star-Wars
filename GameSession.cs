using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{

    [SerializeField] int score = 0;

    void Awake()
    {
        SingletonObject();
    }

   
    private void SingletonObject()
    {
        int numberSessions = FindObjectsOfType<GameSession>().Length;
        if (numberSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void addScore(int reward)
    {
        score += reward;
    }

    public void ResetSession()
    {
        Destroy(gameObject);
    }

    public int GetScore()
    {
        return score;
    }

}
