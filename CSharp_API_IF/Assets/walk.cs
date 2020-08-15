using UnityEngine;

public class walk : MonoBehaviour
{
    public Animator ani;

    /// <summary>
    /// 走路
    /// </summary>
    private void Move()
    {
        bool w = Input.GetKey(KeyCode.W);

        ani.SetBool("走路開關", w);
    }

    private void Update()
    {
        Move();
    }
}
