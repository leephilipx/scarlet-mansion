using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitRotate : MonoBehaviour
{
    public float RotationsPerMinute = 15.0f;
    public Vector3 target = new Vector3(-1.0f, 3.532974f, 1.0f);
    private Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        // Set rabbit to run at start
        m_animator = GetComponent<Animator>();
        m_animator.SetInteger("AnimIndex", 1); // 0 idle, 1 run, 2 dead
        m_animator.SetTrigger("Next");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target, Vector3.up, 6.0f * RotationsPerMinute * Time.deltaTime);
    }
}
