using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsController;
    private PlayerHealth playerHealth;
    private LevelPass levelPass;
    public float restartDelay = 1f;
    Animator anim;
    float restartTimer;
    private TimerManager timerManager;


    void Awake()
    {
        anim = GetComponent<Animator>();
        playerHealth = fpsController.GetComponent<PlayerHealth>();
        levelPass = fpsController.GetComponent<LevelPass>();
        timerManager = GetComponentInChildren<TimerManager>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0 || TimerManager.timeIsUp)
        {
            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            fpsController.enabled = false;

            timerManager.enabled = false;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (levelPass.passed)
        {
            anim.SetTrigger("LevelPassed");

            restartTimer += Time.deltaTime;

            fpsController.enabled = false;

            timerManager.enabled = false;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }
    }
}
