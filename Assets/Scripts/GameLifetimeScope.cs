using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        // Register CMSGameEventManager as a singleton
        builder.Register<CMSGameEventManager>(Lifetime.Singleton);
        builder.RegisterComponentInHierarchy<GameManager>();
        // Register other components or managers as needed
        builder.RegisterComponentInHierarchy<UIManager>();
        builder.RegisterComponentInHierarchy<DragDropUIManager>();
    }
}