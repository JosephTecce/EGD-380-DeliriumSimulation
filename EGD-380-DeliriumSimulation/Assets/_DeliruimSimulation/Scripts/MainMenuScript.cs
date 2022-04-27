using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public string firstLevel;
    public string refraint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);

    }

    public void StartModelView() 
    {
        SceneManager.LoadScene(refraint);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }


}
