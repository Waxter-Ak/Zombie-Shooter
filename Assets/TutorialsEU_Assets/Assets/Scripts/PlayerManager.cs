using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{   
    public float health = 100f;
    public AudioSource source;
    [SerializeField] Transform respawnPoint;
    public GameObject gameOverMenu;
    public MouseLook script;


    public void Hit(float playerdamage)
    {   
        source.Play();
        health -= playerdamage;

         
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            transform.position = respawnPoint.transform.position;
            SceneManager.LoadScene("Level01 1");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
