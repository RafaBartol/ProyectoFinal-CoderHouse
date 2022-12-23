using UnityEngine;

public class FPSController : MonoBehaviour
{
    //Player Movement
    public float velocidadMovimiento = 3f;
   // public Rigidbody rb;


    //Player Look Rotation
    public float sensibilidadMouse = 100f;
    public Transform playerBody;
    public float xRotacion;
    public float yRotacion;
    

    
    void Start()
    {
       
    }

   
    void Update()
    {
      Move();  
      MouseLook();

    }


    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 inputPlayer = new Vector3(hor,0,ver);
        transform.Translate(new Vector3(hor,0,ver) * velocidadMovimiento * Time.deltaTime);
       // rb.AddForce(inputPlayer * velocidadMovimiento * Time.deltaTime);
    }

    void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") *sensibilidadMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") *sensibilidadMouse * Time.deltaTime;

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -70,70);

        yRotacion += mouseX;//esto es asi sino funciona al revez
        //yRotacion = Mathf.Clamp(yRotacion,-360,360);

        transform.localRotation= Quaternion.Euler(xRotacion,yRotacion,0);
    }

    
}
