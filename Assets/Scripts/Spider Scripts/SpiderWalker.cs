using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalker : MonoBehaviour
{
    [SerializeField]
    private Transform startPos, endPos;

    private bool collision;

    public float speed = 1f;

    private Rigidbody2D myBody;
    public AudioSource audioSource;
    public AudioClip AudioDeath;
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ChangeDirection()
    {
        collision = Physics2D.Linecast(startPos.position, endPos.position, 1 << LayerMask.NameToLayer("Ground"));
        Debug.DrawLine(startPos.position, endPos.position, Color.green);
        if (!collision)
        {
            Vector3 temp = transform.localScale;
            if(temp.x ==1f)
            {
                temp.x =-1f;
            }
            else
            {
                temp.x =1f;
            }
            transform.localScale = temp;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        ChangeDirection();
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();
            audioSource.PlayOneShot(AudioDeath);
            Destroy(target.gameObject);
        }
    }

    void Move()
    {
        myBody.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }
}
