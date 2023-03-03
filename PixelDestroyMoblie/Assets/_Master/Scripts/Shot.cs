using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;


public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;


    [SerializeField] private float bullets = 3;
    public TextMeshProUGUI text;
    private bool TienesBalas = true;



    [SerializeField] private GameObject menuEmptyBullets;


    private void Update()
    {
        text.text = "Balas " + bullets.ToString();
    }

    public void Fire()
    {
        if (TienesBalas == true)
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                shotRateTime = Time.time + shotRate;
                Destroy(newBullet, 2);
                bullets--;
            }
        }
        if (bullets <= 0)
        {
            TienesBalas = false;
        }
        if (TienesBalas == false)
        {
            EmptyBullets();
        }
    }
    public void EmptyBullets()
    {
        Time.timeScale = 0f;
        menuEmptyBullets.SetActive(true);

    }
}
