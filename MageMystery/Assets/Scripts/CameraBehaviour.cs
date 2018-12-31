using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject targetObject;
    private float targetAngle = 0;
    const float rotationSpeed = 5f;




    void Update()
    {

        /*RaycastHit hit;
        Ray cameraRay = new Ray(transform.position, Vector3.forward);
            if(Physics.Raycast(cameraRay, out hit))
            {
                if(hit.collider.tag == "Wall")
                {
                Walls[].AddComponent;
                }
            }*/


        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(1))
        {
            targetAngle -= 90.0f;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            targetAngle += 90.0f;
        }

        if (targetAngle != 0)
        {
            Rotate();
        }



    }

    protected void Rotate()
    {


        if (targetAngle > 0)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, -rotationSpeed);
            targetAngle -= rotationSpeed;
        }
        else if (targetAngle < 0)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, rotationSpeed);
            targetAngle += rotationSpeed;
        }

    }
    /*    
        public Transform player;
        public bool LookAtPlayer = false;
        public bool RotateAroundPlayer = false;


        [Range(0.01f, 1.0f)]
        public float smoothSpeed = 0.5f;

        [Range(1.0f, 5.0f)]
        public float rotationSpeed;


        public Vector3 _cameraOffset;

        private void Start()
        {
            _cameraOffset = transform.position - player.position;
        }


        private void LateUpdate()
        {

            if(RotateAroundPlayer)
            {
                if (Input.GetKeyDown(KeyCode.C))
                { 
                    Quaternion camTurnAngle = Quaternion.AngleAxis((transform.rotation.x -90f), player.transform.up);
                    _cameraOffset = camTurnAngle * _cameraOffset;
                }

                if (Input.GetKeyDown(KeyCode.X))
                {
                    Quaternion camTurnAngle = Quaternion.AngleAxis((transform.rotation.x + 90f), player.transform.up);
                    _cameraOffset = camTurnAngle * _cameraOffset;
                }
            }

            Vector3 newPos = player.position + _cameraOffset;
            transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed);

            if (LookAtPlayer || RotateAroundPlayer)
            {
                transform.LookAt(player);
            }
        }

    */

}
