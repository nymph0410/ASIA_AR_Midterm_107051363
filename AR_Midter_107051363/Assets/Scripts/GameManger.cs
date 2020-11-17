using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("人類")]
    public Transform Male;
    [Header("殭屍")]
    public Transform Zombie;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"),Range(0f,5f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0.1f, 20f)]
    public float size = 0.3f;
    [Header("人類動畫元件")]
    public Animator aniMale;
    [Header("殭屍動畫元件")]
    public Animator aniZombie;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        Zombie.Rotate(0, joystick.Horizontal*turn, 0);
        Male.Rotate(0, joystick.Horizontal*turn, 0);

        Zombie.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
    }

    public void Attack()
    {
        print("攻擊");
    }
}
