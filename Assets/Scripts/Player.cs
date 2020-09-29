using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool isCanMove = false;
    public float speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCanMove == true){
            float h = Input.GetAxisRaw("Horizontal");
            //
            float v = Input.GetAxisRaw("Vertical");
            //
            Vector3 curPos = transform.position;
            Vector3 nextPos = new Vector3(h,v,0) * speed * Time.deltaTime;

            transform.position = curPos + nextPos;
        }
    }
    private void OnTriggerEnter(Collider other) {
        
    }
}
