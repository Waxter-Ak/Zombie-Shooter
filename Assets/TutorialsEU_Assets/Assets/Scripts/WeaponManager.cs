using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{   
    
    public GameObject playerCamera;
    public float range = 100f;
    public float enemydamage = 25f;
    [SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            source.Play();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(playerCamera.transform.position, transform.forward, out hit, range))
        {
            Debug.Log("Hit");
            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
            if (enemyManager != null)
            {
                enemyManager.EnemyDamage(enemydamage);
            }
        }
    }
}
