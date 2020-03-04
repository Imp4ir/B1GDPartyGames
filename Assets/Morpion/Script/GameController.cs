using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int whoTurn;
    public int turnCount;
    public GameObject[] turnIcons;
    public Sprite[] playIcons;
    public Button[]tictactoeSpaces;

    private void Start()
    {
        GameSetup();
    }

    void GameSetup()
    {
        whoTurn = 0;
        turnCount = 0;
        turnIcons[0].SetActive(true);
        turnIcons[0].SetActive(false);
        for (int i = 0; i < tictactoeSpaces.Length; i++)
        {
            tictactoeSpaces[i].interactable = true;
            tictactoeSpaces[i].GetComponent<Image>().sprite = null;

        }    
    }
        
}        