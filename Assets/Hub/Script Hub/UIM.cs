
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIM : MonoBehaviour
{
    

    
    public void Retour(int SceneIndex)
    {
        SceneManager.LoadScene(1);




    }

    public void ChangeScene(int SceneIndex)
    {
        SceneManager.LoadScene(2);
    }


}
