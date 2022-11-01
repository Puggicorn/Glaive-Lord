using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGlaive : MonoBehaviour
{
    //Components
    private DamageScript damageScript;
    private SpriteRenderer spriteRenderer;
    public CircleCollider2D circCollider;
    public Rigidbody2D rb;
    public DistanceJoint2D disJoint;
    public GameObject glaive;
    public Transform player;

    //Configurable
    [SerializeField] 
    float reconnectionDist = 2f;
    [SerializeField] 
    float returnForce = 150f;
    [SerializeField] 
    int bounceThreshold = 1;

    //Input Bools
    public bool inputFire = false;

    //Variables
    [HideInInspector]
    public float glaiveVelocity;
    [HideInInspector]
    public int bounceCount;
    
    Vector3 mousePos;
    

    private enum State 
    {
        Idle,
        Thrown,
        Recalled,
        Connected,
        Orbit,
    }

    private State state;

    void Start()
    {
        damageScript = GetComponent<DamageScript>();
        spriteRenderer = glaive.GetComponent<SpriteRenderer>();
        state = State.Connected;
    }

    Vector3 moveVector;
    public Vector3 aimVector;
    
    void FixedUpdate()
    {   
        //Converts Rigidbody velocity into a variable
        glaiveVelocity = Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y);

        //Debug.Log(glaiveVelocity);


        float dist = Vector2.Distance(glaive.transform.position, player.position);
        
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        //mousePos.z = 0;
//OWO
        switch(state)
        {

            case State.Idle:
                

            break;

            case State.Thrown:
                
                if(inputFire)
                {
                    StateRecalled();
                }
                
            break;

            case State.Recalled:

                //Adds forces to recall glaive && Reconnects when close
                moveVector = player.position - glaive.transform.position;
                moveVector = moveVector.normalized;
                rb.AddForce(moveVector * returnForce);

                if(bounceCount >= bounceThreshold)
                {
                    circCollider.enabled = false;
                }
                
                if((dist < reconnectionDist && inputFire))
                {
                    StateConnected();
                }

                if((dist < reconnectionDist / 2))
                {
                    StateOrbit();
                }

            break;

            case State.Connected:
                
                if(!inputFire)
                {
                    rb.velocity += rb.velocity * 0.5f;
                    StateThrown();
                }

            break;

            case State.Orbit:

                if(inputFire)
                {
                    StateConnected();
                }

            break;

        }

        //Glaive Damage and rotation
        glaiveVelocity = Mathf.Clamp(glaiveVelocity, 10, 10000);

        if(state == State.Idle) glaiveVelocity = 0;
        glaive.transform.Rotate(0f, 0f, glaiveVelocity / 2);

        damageScript.damage = Mathf.RoundToInt(glaiveVelocity / 10);
    }


    void StateIdle()
    {
        spriteRenderer.enabled = false;

        state = State.Idle;
    }

    void StateThrown()
    {
        circCollider.enabled = true;
        disJoint.enabled = false;
        rb.drag = 0.2f;
        spriteRenderer.enabled = true;

        state = State.Thrown;
    }

    void StateRecalled()
    {
        rb.drag = 3f;
        bounceCount = 0;

        state = State.Recalled;
    }

    void StateConnected()
    {
        circCollider.enabled = true;
        disJoint.enabled = true;
        rb.drag = 0.5f;

        state = State.Connected;
    }

    void StateOrbit()
    {
        circCollider.enabled = true;
        disJoint.enabled = true;
        rb.drag = 0.5f;

        state = State.Orbit;
    }


}
