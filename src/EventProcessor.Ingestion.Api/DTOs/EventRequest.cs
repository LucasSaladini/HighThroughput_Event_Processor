namespace EventProcessor.Ingestion.Api.DTOs;

public readonly record struct EventRequest(
    Guid Id,
    string SchemaVersion,
    DateTime Timestamp,
    string Source,
    string EventType,
    object Payload);