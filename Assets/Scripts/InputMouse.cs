using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    private float Move_H;
    private float Move_V;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput_Move();
        MouseInput_Scroll();
        MouseInput_Click();
    }

    void MouseInput_Move()
    {
        //Aqui podemos simular um mouse ou o movimento de um mouse para games Point Click
        Move_H = Input.GetAxis("Mouse X");
        Move_V = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3(Move_H, Move_V, 0));
    }

    void MouseInput_Scroll()
    {
        //Aqui podemos simular o movimento pelo scroll do mouse;
        Move_H = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(new Vector3(Move_H, 0, 0));
    }

    void MouseInput_Click()
    {
        //Aqui podemos simular movimento clicando com os botoes do mouse;
        Move_H = Input.GetAxis("Fire1");
        Move_V = Input.GetAxis("Fire2");
        transform.Translate(new Vector3(Move_H * Time.deltaTime, Move_V * Time.deltaTime, 0));
    }
}
