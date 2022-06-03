
using UnityEngine;

public class camerafollow : MonoBehaviour
{float rotationOnX;
float mouseSensitivity = 90f;
public Transform player;
    // Start is called before the first frame update

    // Update is called once per frame
    void start(){
       Cursor.visible = false;
       Cursor.lockState= CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSensitivity;
        float m_x=Input.GetAxis("Mouse X")*Time.deltaTime*mouseSensitivity;
        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX,-90f,90f);
        transform.localEulerAngles = new Vector3(rotationOnX,0f,0f);
        player.Rotate(Vector3.up*m_x);
    }
}
