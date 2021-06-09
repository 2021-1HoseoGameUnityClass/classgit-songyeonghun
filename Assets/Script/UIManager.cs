using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance = null;

    [SerializeField]
    private GameObject[] playerHP;
    public static UIManager instance { get { return _instance; } }
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerHP()
    {
        int minusHP = 3 - DataManager.instance.playerHP;
        for(int i = 0; i < minusHP; i++)
        {
            playerHP[i].SetActive(false);
        }
    }
}
