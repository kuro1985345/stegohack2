using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalChecker : MonoBehaviour
{

    public AudioSource gameBgm;
    public AudioSource goalBgm;

    public GameObject retryButton;

    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameBgm.Stop();
        goalBgm.Play();

        retryButton.SetActive(true);
    }

    public void RetryStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
