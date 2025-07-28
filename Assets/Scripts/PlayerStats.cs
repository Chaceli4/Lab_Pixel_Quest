using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int coinCount = 0;
    public int playerLife = 0;
    public int playerMaxLife = 3;

    public string nextLevel = "Scene_2";
    // Start is called before the first frame update
    void Start()
    {
      
        playerLife = playerMaxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Hit");
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Heart":
                {
                    playerLife++;
                    Destroy(collision.gameObject);
                    break;
                }

        }

    }
}
