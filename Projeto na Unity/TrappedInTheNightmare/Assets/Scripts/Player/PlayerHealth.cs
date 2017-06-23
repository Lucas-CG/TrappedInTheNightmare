using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public float heartbeatPeriod = 2f;
    public GameObject backgroundMusic;
    public GameObject heartbeatSource;

    //Animator anim;
    //PlayerShooting playerShooting;
    UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsController;
    bool isDead;
    bool damaged;
    float heartbeatTimer;
    AudioSource backgroundAudio;
    AudioSource heartbeatAudio;


    void Awake ()
    {
        //anim = GetComponent <Animator> ();
        
        backgroundAudio = backgroundMusic.GetComponent<AudioSource>();
        heartbeatAudio = heartbeatSource.GetComponent<AudioSource>();

        //playerShooting = GetComponentInChildren <PlayerShooting> ();
        fpsController = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        currentHealth = startingHealth;
    }


    void Update ()
    {
        if(damaged)
        {
            damageImage.color = flashColour;

            heartbeatAudio.Play();
        }
        else
        {
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

            if (heartbeatTimer < heartbeatPeriod)
            {
                heartbeatTimer += Time.deltaTime;
            }

            else
            {
                heartbeatAudio.Stop();
                heartbeatTimer = 0f;
            }
        }
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && !isDead)
        {
            Death ();
        }

    }


    void Death ()
    {
        isDead = true;

        //playerShooting.DisableEffects ();
        
        backgroundAudio.clip = deathClip;
        backgroundAudio.Play ();

        //playerShooting.enabled = false;
        fpsController.enabled = false;
    }


    public void RestartLevel ()
    {
        SceneManager.LoadScene (0);
    }
}
