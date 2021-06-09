using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pad : MonoBehaviour
{
    [SerializeField]
    private string sceanName = "";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") == true)
        {
            DataManager.instance.currentScence = sceanName;
            DataManager.instance.Save();
            SceneManager.LoadScene(sceanName);
        }    
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
