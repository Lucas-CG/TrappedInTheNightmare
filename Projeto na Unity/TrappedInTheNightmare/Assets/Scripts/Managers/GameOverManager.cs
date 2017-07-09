using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsController;
    public GameObject backgroundMusic;
    public AudioClip timeIsUpClip;
    private PlayerHealth playerHealth;
    private LevelPass levelPass;
    public float restartDelay = 1f;
    Animator anim;
    float restartTimer;
    private TimerManager timerManager;
    AudioSource backgroundAudio;


    void Awake()
    {
        anim = GetComponent<Animator>();
        playerHealth = fpsController.GetComponent<PlayerHealth>();
        levelPass = fpsController.GetComponent<LevelPass>();
        timerManager = GetComponentInChildren<TimerManager>();
        backgroundAudio = backgroundMusic.GetComponent<AudioSource>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0 || TimerManager.timeIsUp)
        {
            if (TimerManager.timeIsUp)
            {
                backgroundAudio.clip = timeIsUpClip;
                backgroundAudio.Play();
            }

            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            fpsController.enabled = false;

            timerManager.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;

            Cursor.visible = true;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(0);
            }
        }

        if (levelPass.passed)
        {
            anim.SetTrigger("LevelPassed");

            restartTimer += Time.deltaTime;

            fpsController.enabled = false;

            timerManager.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;

            Cursor.visible = true;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(2);
            }

        }
    }
}
