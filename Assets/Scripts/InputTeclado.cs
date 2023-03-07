using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTeclado : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Key();
        //KeyUpSeta();
        //KeyDownSeta();
    }

    void Key()
    {
        // O getkey é usado quando queremos movimentar algo na cena, é chamado enquanto a tecla esta pressionada;
        if (Input.GetKey(KeyCode.A))
        {
            //aqui movimentamos o gameobject para esquerda
            print("Letra A pressionada");
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            //aqui movimentamos o gameobject para direita
            print("Letra D pressionada");
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            //aqui movimentamos o gameobject para cima
            print("Letra W pressionada");
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            //aqui movimentamos o gameobject para baixo
            print("Letra S pressionada");
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }

    void KeyUpSeta()
    {
        // Este metodo de input realiza a ação quando soltamos a tecla pressionada;
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            print("Voce clicou e soltou a seta direcional para direita");
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            print("Voce clicou e soltou a seta direcional para esquerda");
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            print("Voce clicou e soltou a seta direcional para cima");
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            print("Voce clicou e soltou a seta direcional para baixo");
        }
    }

    void KeyDownSeta()
    {
        // Este metodo de input realiza a ação quando pressionamos a tecla;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Voce clicou na seta direcional para direita");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Voce clicou na seta direcional para esquerda");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Voce clicou na seta direcional para cima");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Voce clicou na seta direcional para baixo");
        }
    }
}
