using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour 
{

	private void Awake() 
	{
		
	}
	
	private void Update () 
	{
        if (Input .GetKeyDown (KeyCode .L))
        {
            StartCoroutine(LoadNewGame());
        }
	}

    private IEnumerator LoadNewGame()
    {
        print("LoadNewGame");

        AsyncOperation ao = SceneManager.LoadSceneAsync(1,LoadSceneMode.Single);
        ao.allowSceneActivation = false;

        while (ao .progress <0.9f)
        {
            yield return null;
        }
        //此处有黑屏过渡
        ao.allowSceneActivation = true;
        print("222");

    }
}
