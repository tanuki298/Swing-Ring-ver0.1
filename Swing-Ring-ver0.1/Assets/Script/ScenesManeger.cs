using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManeger : MonoBehaviour
{
    private string Scene_Name;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        Scene_Name = SceneManager.GetActiveScene().name;
        //Debug.Log(Scene_Name);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Title");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("MusicSelect");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Gamemain");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Result");
        }
        //別のシーンを上に重ねることができる。これでポーズなどが実装できる
        if (Input.GetKeyDown(KeyCode.O))
        {
            Application.LoadLevelAdditive("Option");
        }
    }
}
