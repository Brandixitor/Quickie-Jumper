using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casey : MonoBehaviour
{

    public float movementSpeend = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeend / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeend;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
    }
}
