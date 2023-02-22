using UnityEngine;


public class InputController : MonoBehaviour
{
    public Joystick joystick;
    public Joystick joystickR;

    public int velocidad;
    public int velocidadR;

    public Rigidbody rb;
    public Rigidbody player;

    public bool ConFisicas;
    
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
      
      Rotate();
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        if(ConFisicas)
        {
            rb.AddForce(direction * velocidad * Time.fixedDeltaTime, ForceMode.Impulse);
        }
        else
        {
            gameObject.transform.Translate(direction * velocidad * Time.deltaTime);
        }
    }
    
    void Rotate()
    {
        Vector2 rotation = new Vector2(joystickR.Vertical * 50 * Time.deltaTime, joystickR.Horizontal * 50*Time.deltaTime);
        rotation.y= Mathf.Clamp(rotation.y,-45, 45);
        rotation.x = Mathf.Clamp(rotation.x, -45,45 );
        player.transform.Rotate(rotation);
       

    }

}
