// Some stupid rigidbody based movement by Dani

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float mouseSensitivity = 2f;
    private bool isGrounded;
    private float verticalRotation = 0f;
    private float horizontalRotation = 0f;
    public Vector3 cameraOffset = new Vector3(0, 1.6f, 0); // Vị trí camera so với player

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Khóa và ẩn con trỏ chuột
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Đặt vị trí camera ban đầu
        //playerCamera.position = transform.position + cameraOffset;
    }

    void LateUpdate()
    {
        // Cập nhật vị trí camera theo player
        //playerCamera.position = transform.position + cameraOffset;
    }

    void Update()
    {
        // Quay camera
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        
        // Quay camera lên/xuống
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Giới hạn góc quay
        
        // Quay camera trái/phải
        horizontalRotation += mouseX;
        
        
        // Quay player theo hướng nhìn camera
        transform.rotation = Quaternion.Euler(0f, horizontalRotation, 0f);

        // Di chuyển
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;
        rb.velocity = movement * moveSpeed;

        // Nhảy
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Thoát khỏi chế độ khóa chuột
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Kiểm tra va chạm với mặt đất
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Kiểm tra rời khỏi mặt đất
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}