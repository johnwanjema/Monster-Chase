using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    private Rigidbody2D mybody;

    private SpriteRenderer sr;

    private Animator anim;

    private string WALK_ANIMATION = "walk";

    
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }
    
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0f,0f) * Time.deltaTime * moveForce;


        Debug.Log("Move x value is :" + movementX);
    }

    void AnimatePlayer()
    {
        anim.SetBool(WALK_ANIMATION,true);

        if (movementX >0){
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = false;
        }else if (movementX  < 0) {
            anim.SetBool(WALK_ANIMATION,true);
             sr.flipX = true;
        }else{
            anim.SetBool(WALK_ANIMATION,false);
        }

    }
}
