using UnityEngine;

public class movimento : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    [SerializeField]private int speed;
    private 
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        
        rb.linearVelocity = new Vector2(vertical*speed, rb.linearVelocity.y);
        rb.linearVelocity = new Vector2(horizontal*speed, rb.linearVelocity.x);
        

    }
    private void FixedUpdate()
    {
        
    }

}
