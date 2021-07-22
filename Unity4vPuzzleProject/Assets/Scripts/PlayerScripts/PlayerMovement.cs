using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    Vector3 velocity;
    public float gravity = -9.81f;

    public float speed = 12;

    public Canvas crosshair;
    public Canvas puzzlemenu;
    public Canvas puzzle2;
    public Canvas puzzle3;

    public GameObject player;
    public GameObject table;
    public GameObject frame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(Vector3.Distance(table.transform.position, player.transform.position));
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(table.transform.position, player.transform.position) <= 14)
        {
            Cursor.lockState = CursorLockMode.None;
            Desktop();
        }else if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(frame.transform.position, player.transform.position) <= 14)
        {
            SceneManager.LoadScene("ClosingCutscene", LoadSceneMode.Single);
        }
    }

    public void Desktop()
    {
        puzzlemenu.gameObject.SetActive(true);
        crosshair.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
}
