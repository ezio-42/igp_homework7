using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller {
    [SerializeField] private BallView ballView;
    public override void InstallBindings() {
        Container.Bind<int>().FromInstance(10);
        Container.Bind<BallView>().FromInstance(ballView);
    }
}