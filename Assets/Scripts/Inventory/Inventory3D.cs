using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory3D : MonoBehaviour
{
    public GameObject spinner;
    public GameObject slotObj;

    [Range(1.0f, 30.0f)]
    public float turnSpeed = 3.0f;

    [Range(0.0f, 360.0f)]
    public float angle = 0.0f;

    private bool turning = false;
    private Vector3 dir = -Vector3.up;
    private float currentAngle = 0.0f;

    private void Start()
    {
        CreateCircle();
    }

    void CreateCircle()
    {
        for(int i = 0; i < 12; i++)
        {
            float angle = i * Mathf.PI * 2 / 12;
            float deltaX = Mathf.Cos(angle) * 2 + 1.5f;
            float deltaZ = Mathf.Sin(angle) * 2 + -1.5f;

            Vector3 pos = new Vector3(deltaX, transform.position.y, deltaZ);
            GameObject go = Instantiate(slotObj, spinner.transform.position, Quaternion.identity);
            go.transform.parent = spinner.transform;
            go.transform.position = pos;
        }
    }

    public void TurnLeft()
    {
        turning = true;
        currentAngle -= angle;
        if (currentAngle <= -360.0f)
            currentAngle = 360.0f;
    }

    public void TurnRight()
    {
        turning = true;
        currentAngle += angle;
        if (currentAngle >= 360.0f)
            currentAngle = -360.0f;
    }

    void Turn()
    {
        Quaternion targetAngle = Quaternion.AngleAxis(currentAngle, dir);

        if(Quaternion.Angle(spinner.transform.rotation, targetAngle) > 0.0f)
            spinner.transform.rotation = Quaternion.Lerp(spinner.transform.rotation, targetAngle, turnSpeed * Time.deltaTime);
        else
            turning = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            if (!turning)
                TurnLeft();

        if (Input.GetKeyDown(KeyCode.RightArrow))
            if (!turning)
                TurnRight();
        if (turning)
            Turn();
    }
}
