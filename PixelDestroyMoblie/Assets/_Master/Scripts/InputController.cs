using UnityEngine;


public class InputController : MonoBehaviour
{
    
    public float velocidadGiro = 0.2f;
    public VirtualJoystick joystickGiro;
    
    public Transform player;

    private void Start()
    {
        
    }
    /*
    void Rotate()
    {
        float rotateV;
        float rotateH;
        rotateH = joystickGiro.Horizontal * velocidadGiro;
        rotateV = joystickGiro.Vertical * velocidadGiro;
        player.Rotate(0, rotateH, 0);
    }
    */
}
