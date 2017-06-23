using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public float attackAnimationTime = 1f;
    public int attackDamage = 10;
    public float attackForce = 5f;

    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    Rigidbody playerRigidbody;
    EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;
    //
    float animationTimer;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent <PlayerHealth> ();
        playerRigidbody = player.GetComponent<Rigidbody>();
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent <Animator> ();
    }


    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }


    void OnTriggerExit (Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }


    void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            //Attack ();

            anim.SetTrigger("Attack");


            //
            animationTimer += Time.deltaTime;

            if (animationTimer >= attackAnimationTime)
            {
                Attack();
            }


        }

        if (timer >= timeBetweenAttacks && !playerInRange && enemyHealth.currentHealth > 0)
        {
            anim.SetTrigger("PostAttack");
        }

        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger ("PlayerDead");
        }
    }


    void Attack ()
    {
        timer = 0f;
        //
        animationTimer = 0f;

        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage (attackDamage);
            float distance = Vector3.Distance(transform.position, player.transform.position);
            Vector3 difference = transform.position - player.transform.position;
            playerRigidbody.AddForce(difference * attackForce);
        }
    }
}
