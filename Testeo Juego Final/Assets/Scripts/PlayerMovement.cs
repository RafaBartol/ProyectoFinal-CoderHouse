using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movimiento Player

    public float velocidadRotacion = 200.0f;
    public float velocidadMovimiento = 5.0f;
    private Animator anim;
    public float x, y;

    // Camara

    public float sensibilidadCamara;

    // Atacar

    public bool Attack;
    public bool conArma;
    
    void Start()
    {
        anim = GetComponent<Animator>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate() 
    {
        if (!Attack)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        float rotationY = Input.GetAxis("Mouse X");
        
        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * sensibilidadCamara, 0));

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (Input.GetMouseButtonDown(0) && !Attack)
        {
            if (conArma)
            {
                anim.SetTrigger("SwordAttack");
                Attack = true;
            }
        }
    }

    public void StopAttack()
    {
        Attack = false;
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("arma"))
        {
            Debug.Log("Has sufrido daño");
        }
    }
}
