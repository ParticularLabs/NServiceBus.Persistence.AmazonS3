namespace NServiceBus.PersistenceTesting;

using System;
using System.Threading;
using System.Threading.Tasks;
using NServiceBus.Outbox;
using NServiceBus.Sagas;
using Persistence;

public partial class PersistenceTestsConfiguration
{
    public bool SupportsDtc => false;

    public bool SupportsOutbox => true;

    public bool SupportsFinders => false;

    public bool SupportsPessimisticConcurrency { get; private set; }

    public ISagaIdGenerator SagaIdGenerator { get; } //= new SagaIdGenerator();

    public ISagaPersister SagaStorage { get; private set; }

    public IOutboxStorage OutboxStorage { get; private set; }

    public Func<ICompletableSynchronizedStorageSession> CreateStorageSession { get; private set; }

    public Task Configure(CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }

    public Task Cleanup(CancellationToken cancellationToken = default) =>
        // Cleanup is done by the setup fixture
        Task.CompletedTask;
}