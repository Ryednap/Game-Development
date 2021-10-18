using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int currentScore;
    public static int highScore;

    public static int currentLevel  = 0;
    public static bool unlockedLevel;
    // Start is called before the first frame update
    public static void CompleteLevel()
    {
        if (currentLevel < 2) { 
            currentLevel += 1;
            Application.LoadLevel(currentLevel);
        } else {
            print ("You Win");
        }
    }
}
