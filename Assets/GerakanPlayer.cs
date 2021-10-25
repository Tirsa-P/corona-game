using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerakanPlayer : MonoBehaviour
{
    public float kecepatan;
    public int score;
    public Text scoreUI;
    public GameObject panel;
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    Rigidbody rb;
    Animator anim;

    public Transform playerPutaran;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
        Darah();
    }
        
    

    
    private void Darah()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i< hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
            hearts[i].sprite = emptyHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }else
            {
                hearts[i].enabled = false;
            }

        }
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
        anim.SetFloat("Kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3(0, gerak * 90, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        panel.gameObject.SetActive(false);
        if (collision.collider.CompareTag("virus"))
        {
            health -= 1;
            Destroy(collision.collider.gameObject);
        }
        else if (collision.collider.CompareTag("capsule"))
        {
            score += 10;
            scoreUI.text = "Score : " + score.ToString();
            Destroy(collision.collider.gameObject);
            for(int i = 0; i <= score; i += 100)
            {
                if (score == i)
                {
                    health += 1;
                }
            }

            
        }
             
        if (health == 0)
        {
            Time.timeScale = 0;
            panel.gameObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
   
}

