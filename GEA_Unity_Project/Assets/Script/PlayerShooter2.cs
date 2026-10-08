using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter2 : MonoBehaviour
{
    [Header("기본 공격 설정")]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireCooldown = 0.2f;

    [Header("샷건 공격 설정")]
    public float shotgunCooldown = 0.6f;
    public int shotgunPelletCount = 5;      // 5발 발사
    public float shotgunSpreadAngle = 30f;  // 퍼지는 각도

    private float lastFireTime = -999f;
    private float lastShotgunTime = -999f;

    // 마우스 좌클릭 (기본 공격)
    public void OnAttack(InputValue value)
    {
        if (!value.isPressed) return;
        if (Time.timeScale == 0f) return;
        if (Time.time < lastFireTime + fireCooldown) return;

        if (!CheckReferences()) return;

        lastFireTime = Time.time;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }
    }

    // 마우스 우클릭 (샷건 공격 - 5발)
    public void OnShotgun(InputValue value)
    {
        if (!value.isPressed) return;
        if (Time.timeScale == 0f) return;
        if (Time.time < lastShotgunTime + shotgunCooldown) return;

        if (!CheckReferences()) return;

        lastShotgunTime = Time.time;

        for (int i = 0; i < shotgunPelletCount; i++)
        {
            // 각 총알을 부채꼴 모양(-15도 ~ +15도)으로 분산 계산
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

    private bool CheckReferences()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogError("PlayerShooter: Bullet Prefab 또는 Fire Point가 Inspector에 연결되지 않았습니다!");
            return false;
        }
        return true;
    }
}