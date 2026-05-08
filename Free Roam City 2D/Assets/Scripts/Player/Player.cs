using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float steerSpeed = 1f;
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float slowSpeed = 10f;

    [Header("Inputs")]
    [SerializeField] private float steerAmount;
    [SerializeField] private float moveAmount;


    private void Update()
    {
        MoveCar();
    }

    void MoveCar()
    {
        steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}