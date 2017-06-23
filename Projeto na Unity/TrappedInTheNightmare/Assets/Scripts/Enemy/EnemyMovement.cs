using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    Animator anim;
    public float range = 10.0f;
    public float fieldOfViewRange; // in degrees (I use 68, this gives the enemy a vision of 136 degrees)
    public float minPlayerDetectDistance; // the distance the player can come behind the enemy without being deteacted
    public float rayRange; // distance the enemy can "see" in front of him
    public Vector3 p1;
    public Vector3 p2;

    private Vector3 originPosition;
    private bool chasing = false;
    Vector3 prevDestination = new Vector3();


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        originPosition = transform.position;
        anim = GetComponent<Animator>();

        nav.SetDestination(p2);
    }


    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0 && distance < range && (CanSeePlayer() || distance < minPlayerDetectDistance))
        {
            if (!chasing)
                prevDestination = nav.destination;
            nav.SetDestination(player.position);
            anim.SetTrigger("IsMoving");
            chasing = true;
        }

        else if (enemyHealth.currentHealth > 0)
        {
            if (chasing)
            {
                nav.SetDestination(prevDestination);
            }
            else if (Vector3.Distance(transform.position, nav.destination) <= 1)
            {
                if (Vector3.Distance(nav.destination, p1) <= 1)
                    nav.SetDestination(p2);
                else
                    nav.SetDestination(p1);
            }
            chasing = false;
            anim.SetTrigger("IsMoving");
        }

        //        else if (enemyHealth.currentHealth > 0)
        //        {
        //            anim.SetTrigger("StoppedMoving");
        //            transform.Rotate (Vector3.up * Time.deltaTime * 20, Space.World);
        //
        //        }
    }


    private Vector3 rayDirection = Vector3.zero;


    bool CanSeePlayer()
    {
        RaycastHit hit;
        rayDirection = player.transform.position - transform.position;
        var distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);


        if (Physics.Raycast(transform.position, rayDirection, out hit))
        { // If the player is very close behind the enemy and not in view the enemy will detect the player
            if ((hit.transform.tag == "Player") && (distanceToPlayer < minPlayerDetectDistance))
            {
                //Debug.Log("Caught player sneaking up behind!");
                return true;
            }
        }
        if ((Vector3.Angle(rayDirection, transform.forward)) < fieldOfViewRange)
        { // Detect if player is within the field of view
            if (Physics.Raycast(transform.position, rayDirection, out hit, rayRange))
            {
                if (hit.transform.tag == "Player")
                {
                    //Debug.Log("Can see player");
                    return true;
                }
                else
                {
                    //Debug.Log("Can not see player");
                    return false;
                }
            }
        }
        return false;
    }


}
