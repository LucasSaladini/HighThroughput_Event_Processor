# Feature 01: Event Ingestion Contract & API

## 🎯 Objective

Stablish the data contract for telemetry events and the high performance entry endpoint that will act as the entry gateway for the system.

## 🏗️ Event Schema (JSON)

The event must represent a sensor reading or a system action. C# primitive types are used to ensure a fast serialization process.

|Field| Type| Description   | Example   |
|---|---|---|---|
| Id  | Guid | Unique identifier for the event | "00000000-0000-0000-0000-000000000000" |
| SchemaVersion  | string | Version of the contract to suport evolution | "v1" |
| Timestamp  | DateTime | Date/time UTC when the event occurred | "2026-03-14T10:10:58.000Z" |
| Source  | string | Event origin (e.g. sensor ID) | "IoT-Gateway-A1" |
| EventType  | string | Event category for routing | "TemperatureRead" |
| Payload | object | Variable event data (Dynamic JSON) | { "Temperature": 25.5 } |

## 🛣️ Endpoint Definition

To maximize the throughput, **Minimal APIs** from .NET 10 will be used with a strategy of **Accepted (202 accepted)**.
- **Method**: POST
- **Route**: `/api/v1/events`
- **Response**: `202 Accepted` (Indicates that the event was received and queued for processing, but not necessarily processed yet)

## ✅ Acceptance Criteria (Definition of Done)

1. **Schema Validation**: The endpoint must return `400 Bad Request` if the `Id` or the `Timestamp` are missing or invalid.
2. **Performance**: The response time of the endpoint must not exceed 50ms (excluding network latency).
3. **Initial Idempotency**: The API must accept the payload and validate the GUID format.
4. **TDD**: All unit validation tests of the contract must pass.
5. **Documentation**: The main README must contain the link for this document. 