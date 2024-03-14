namespace NServiceBus;

using Persistence;

/// <summary>
/// Used to configure NServiceBus to use AmazonS3 persistence.
/// </summary>
public class AmazonS3Persistence : PersistenceDefinition
{
    internal AmazonS3Persistence()
    {
        Defaults(s =>
        {
            //s.SetDefault(new OutboxPersistenceConfiguration());
            //s.SetDefault(new SagaPersistenceConfiguration());
        });

        //Supports<StorageType.Sagas>(s => s.EnableFeatureByDefault<SagaStorage>());
        //Supports<StorageType.Outbox>(s => s.EnableFeatureByDefault<OutboxStorage>());
    }
}