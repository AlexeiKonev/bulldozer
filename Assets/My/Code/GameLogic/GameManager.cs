using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    private UIManager _uiManager;
    [SerializeField] private PlayerController _playerController;

    void Start() {
        if (instance == null) {

            instance = this;

        }
        _uiManager = gameObject.GetComponent<UIManager>();

    }

    // Update is called once per frame
    void Update() {
        bool b = Input.GetKeyDown(KeyCode.Escape);

        if (b) 
        _uiManager.ShowPause(b);
    }
}
