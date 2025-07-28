using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image Health;
    // Start is called before the first frame update
    void Start()
    {
        Health = GameObject.Find("playerLifeUI").GetComponent<Image>();
    }

    public void UpdateHealth(float health, float maxHealth)
    {
        Health.fillAmount = health/maxHealth;
    }
}
