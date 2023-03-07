using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTeclado2 : MonoBehaviour
{
    [SerializeField] private float speed;
    private float Move_H;
    private float Move_V;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AxisInput();
    }

    void AxisInput()
    {
        //Uma forma mais aprimorada de criar um codigo para capturar os comandos do teclado
        Move_H = Input.GetAxis("Horizontal") * speed;
        Move_V = Input.GetAxis("Vertical") * speed;

        transform.Translate(new Vector3(Move_H * Time.deltaTime, Move_V * Time.deltaTime, 0));
    }
}
