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
        ShowPause();
    }
    private void ShowPause() {
        bool escapeButton = Input.GetKeyDown(KeyCode.Escape);

        if (escapeButton)
            _uiManager.ShowPause(escapeButton);
    }
}
