using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    private UIManager _uiManager;
    [SerializeField] private PlayerController  _playerController;
     

    Kran kran;
    Escavator escavator;
    void Start() {
      _playerController=  GameObject.FindObjectOfType<PlayerController>();
        if (instance == null) {

            instance = this;

        }
        _uiManager = gameObject.GetComponent<UIManager>();
          kran =  new Kran();
          escavator =  new Escavator();
        _playerController.SetMech(new Dozer());
    }

    // Update is called once per frame
    void Update() {
      
        ShowPause();
        if (Input.GetKeyUp(KeyCode.W)&& _playerController.Mech!=escavator) {
            _playerController.SetMech(escavator);
            Debug.Log($"Set Mech {_playerController.Mech.Name}");
        }else if (Input.GetKeyUp(KeyCode.S) && _playerController.Mech != kran) {
            _playerController.SetMech(kran);
            Debug.Log($"Set Mech {_playerController.Mech.Name}");
        }
    }


    /// <summary>
    /// Method check Escape button, when pause showed ui button with false argument, will Hide pause panel
    /// </summary>
    private void ShowPause() {
        bool escapeButton = Input.GetKeyDown(KeyCode.Escape);

        if (escapeButton)
            _uiManager.ShowPause(escapeButton);
    }
}
