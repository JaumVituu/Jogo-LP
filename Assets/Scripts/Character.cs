using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    bool isRightButtonDown;
    bool isLeftButtonDown;
    public int score;
    Vector3 m;
    Vector3 limiteMin;
    public Rigidbody jump;
    public float mass;
    private bool jmpPressed = false;
    public int pulando;
    public Vector3 posicao;
    public int tglLever;
    public int crystalIs;
    public int uWin;
    public bool particles;
    public Vector3 escala;
    Vector3 limiteMax;



    // Start is called before the first frame update
    void Start()
    {
        var limit = new Vector3(1, 1, 1);
        isLeftButtonDown = false;
        isRightButtonDown = false;
        m.x = 0.0f;
        m.y = 0.0f;
        m.z = 0.0f;
        jump = GetComponent<Rigidbody>();
        posicao.x = 0.0f;
        posicao.y = 0.0f;
        posicao.z = 0.0f;
        jump.velocity = posicao;
        pulando = 0;
        tglLever = 0;
        crystalIs = 0;
        uWin = 0;
        limiteMin.y = 0.5f;
        limiteMax.y = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        escala = transform.localScale;
        if (Input.GetKey(KeyCode.D))
        {
            m.z = 0.05f;
            Movimento(m);
            m.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            m.z = -0.05f;
            Movimento(m);
            m.z = 0.0f;
        }
        isLeftButtonDown = Input.GetMouseButtonDown(0);
        isRightButtonDown = Input.GetMouseButtonDown(1);
        if (transform.localScale.y >= limiteMax.y) { }
        else
        {
            if (isLeftButtonDown)
            {
                m.y = 0.5f;
                m.x = 0.5f;
                m.z = 0.5f;
                transform.localScale += m;
                isLeftButtonDown = false;
                m.y = 0f;
                m.x = 0f;
                m.z = 0f;
            }
        }
        if (transform.localScale.y <= limiteMin.y)
        {
        }
        else
        {
            if (isRightButtonDown)
            {
                m.y = -0.5f;
                m.x = -0.5f;
                m.z = -0.5f;
                transform.localScale += m;
                isRightButtonDown = false;
                m.y = 0f;
                m.x = 0f;
                m.z = 0f;
            }
        }
        jmpPressed = Input.GetKey(KeyCode.Space);
        

    }
    void Movimento(Vector3 m)
    {
        transform.Translate(m);

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Coin")
        {
            score += 1;
            Debug.Log("Pegou " + score + " moeda");

        }
        if (collider.tag == "Lever")
        {
            tglLever = 1;
        }
        if (collider.tag == "ToggleJump")
        {
            pulando = 1;
        }
        if (collider.tag == "WallHitbox")
        {
            crystalIs = 1;
        }
        if (collider.tag == "Crystal" || collider.tag == "Crystal2")
        {
            uWin += 1;
            Debug.Log("Parabéns, você venceu!");           
        }
        if (collider.tag == "ChadCoin")
        {
            score += 50;
            Debug.Log("Yes, im the chad coin");
            particles = true;

        }

        if (collider.tag == "Orange" || collider.tag == "Cyan")
        {
            score += 2;
            Debug.Log("Destruiu inimigo!");
        }
    }
       
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Lever")
        {
            tglLever = 0;
        }
        if (collider.tag == "ToggleJump")
        {
            pulando = 0;
        }
    }


    void FixedUpdate()
    {
        
        if (pulando == 1)
        {
       
            if (jmpPressed)
            {
                if (posicao.y == 0.0f)
                {
                    posicao.y = 10.0f;
                    jump.velocity = posicao;
                    Debug.Log("pulo");
                }
                if (posicao.y == 10.0f)
                {
                    posicao.y = 0.0f;
                }
            }
        }
    }
}




