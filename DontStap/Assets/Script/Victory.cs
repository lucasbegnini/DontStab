using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Victory : MonoBehaviour {
    private bool _onvictory;
	
    [SerializeField]
    private GameObject victoryPanel;
    [SerializeField]
    private GameObject shaderPanel;
    [SerializeField]
    private string scene;
    [SerializeField]
    private string nextLevel;
    [SerializeField]
    private Button pauseButton;
    [SerializeField]
    private GameObject pyo;
    [SerializeField]
    private float pyoPosition;
	private Component script;

    [SerializeField]
    private GameObject _loading;
    // Use this for initialization
    void Start()
    {
        victoryPanel.SetActive(false);
        _onvictory = false;
        _loading.SetActive(false);
    }

    public void ResetGame()
    {
        _loading.SetActive(true);
        StartCoroutine(setPlay(Application.loadedLevelName));
    }

    public void GoToScene()
    {
        _loading.SetActive(true);
        StartCoroutine(setPlay(scene));
    }
    public void GoToNextScene()
    {
        _loading.SetActive(true);
        StartCoroutine(setPlay(nextLevel));
    }

    void Update()
    {
/*       if((pyo.transform.position.x > pyoPosition) && (!_onvictory))
        {
            GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>().Finish();
			gameObject.SendMessage("Points");
            victoryPanel.SetActive(true);
            pauseButton.gameObject.SetActive(false);
            Time.timeScale = 0.0f;
            _onvictory = true;
        } */
    }

    IEnumerator setPlay(string entrada)
    {
        AsyncOperation async = Application.LoadLevelAsync(entrada);
        yield return async;
    }
}

