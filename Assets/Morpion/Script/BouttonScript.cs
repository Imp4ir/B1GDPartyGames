using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class ButtonScript : MonoBehaviour
{

    GameManager gmScript;

    private void Start()
    {
        gmScript = GameObject.Find("Canvas").GetComponent<GameManager>();
    }
    public void Select()
    {

        transform.Find("Text").GetComponent<Text>().text = "X";
        GetComponent<Button>().interactable = false;
        int index = int.Parse(gameObject.name);

        gmScript.matrix[index] = "X";

        if (gmScript.verification("X"))
        {
            gmScript.ShowPanel("X");
        }
        else
        {
            gmScript.ComputerPlay();
        }

       /* transform.Find("Text").GetComponent<Text>().text = "O";
        GetComponent<Button>().interactable = false;
        int index = int.Parse(gameObject.name);

        gmScript.matrix[index] = "O";

        if (gmScript.verification("O"))
        {
            gmScript.ShowPanel("O");
        }
        else
        {
            gmScript.ComputerPlay();
        }
    }
}*/