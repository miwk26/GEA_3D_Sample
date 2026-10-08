using UnityEngine;
using UnityEngine.InputSystem;

public class ShotGun : MonoBehaviour
{
    [Header("기본 공격 설정")]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireCooldown = 0.2f; // 일반 공격 간격

    [Header("샷건 공격 설정")]
    public float shotgunCooldown = 0.6f; // 샷건 쿨타임
    public int shotgunPelletCount = 5;  // 발사할 총알 수
    public float shotgunSpreadAngle = 30f; // 부채꼴 퍼짐 각도(도)

    private float lastFireTime = -999f;
    private float lastShotgunTime = -999f;

    // 좌클릭 기본 공격
    public void OnAttack(InputValue value)
    {
        if (Time.timeScale == 0f) return; // 게임 오버면 무시
        if (Time.time < lastFireTime + fireCooldown) return;
        lastFireTime = Time.time;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }
    }

    // 마우스 우클릭 샷건 공격
    public void OnShotgun(InputValue value)
    {
        if (Time.timeScale == 0f) return;
        if (Time.time < lastShotgunTime + shotgunCooldown) return;
        lastShotgunTime = Time.time;

        // 지정된 개수만큼 부채꼴 각도로 나누어 발사
        for (int i = 0; i < shotgunPelletCount; i++)
        {
            // 각 총알의 Y축 회전 각도 계산 (-각도/2 ~ +각도/2)
            float angleOffset = Mathf.Lerp(-shotgunSpreadAngle / 2f, shotgunSpreadAngle / 2f, (float)i / (shotgunPelletCount - 1));
            Quaternion pelletRotation = firePoint.rotation * Quaternion.Euler(0f, angleOffset, 0f);

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, pelletRotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = pelletRotation * Vector3.forward * bulletSpeed;
            }
        }
    }
}