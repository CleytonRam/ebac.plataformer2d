using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour {
    public ProjectileBase prefabProjectile;

    public Transform positionToshoot;
    public float timeBetweenShoot = .3f;
    public Transform playerSideReference;

    private Coroutine _currentCourotine;

    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            _currentCourotine = StartCoroutine(StartShoot());
        }
        else if (Input.GetKeyUp(KeyCode.S)) {
            if (_currentCourotine != null) { 
                StopCoroutine(_currentCourotine); }
        }
    }

    IEnumerator StartShoot() {
        while (true) {
            Shoot();
            yield return new WaitForSeconds(timeBetweenShoot);
        }
    }


    public void Shoot() {
        var projectile = Instantiate(prefabProjectile);
        projectile.transform.position = positionToshoot.position;
        projectile.side = playerSideReference.transform.localScale.x;
    }
}
