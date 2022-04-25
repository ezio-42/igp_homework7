using UnityEngine;
using Zenject;

public class Game : MonoBehaviour {
    [Inject] private BallView _ballView;
    [Inject] private int _ballInitialHealth;
    private BallPresenter _ballPresenter;

    private void Start() {
        var ballModel = new BallModel(_ballInitialHealth);
        _ballPresenter = new BallPresenter(_ballView, ballModel);
    }

    private void OnDestroy() {
        _ballPresenter.Dispose();
    }
}