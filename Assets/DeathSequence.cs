using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathSequence : MonoBehaviour
{
    ParticleSystem _ps;
    [SerializeField]
    float _deathWaitTime = 1f;

    private void OnEnable()
    {
        _ps = GetComponent<ParticleSystem>();
        Health.playerDied += OnDeath;

    }

    private void OnDisable()
    {
        Health.playerDied -= OnDeath;
    }

    public void OnDeath()
    {
        _ps.Play();
        StartCoroutine(DeathTime());
    }

    IEnumerator DeathTime()
    {
        
        yield return new WaitForSeconds(_deathWaitTime);
        SceneManager.LoadScene(0);
    }
}
