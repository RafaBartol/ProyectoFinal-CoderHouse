using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Vida

    public int VidaJugador = 50;
    
    // Movimiento Player

    public int velocidadRotacion = 200;
    public int velocidadMovimiento = 5;
    private Animator anim;
    public float x, y;

    // Camara

    public float sensibilidadCamara;

    // Atacar

    public bool Attack;
    public bool conArma;
    public int dañoPlayer = 5;
    public GameObject [] enemigos;
    
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

    public void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Enemy")
        {
            col.transform.gameObject.GetComponent<Skeletons>().vidaEnemigo -= dañoPlayer;
        }
    }
}
