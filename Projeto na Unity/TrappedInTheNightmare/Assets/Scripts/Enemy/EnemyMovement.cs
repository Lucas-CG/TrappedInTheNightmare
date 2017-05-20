using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    public float range = 10.0f;

    private Vector3 originPosition;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
        originPosition = transform.position;
    }


    void Update ()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0 && distance < range)
        {
            nav.SetDestination (player.position);
        }

        else if (enemyHealth.currentHealth > 0 && transform.position != originPosition)
        {
            nav.SetDestination(originPosition);
        }

        else
        {
            nav.enabled = false;
        }
    }
}
