# HighThroughput_Event_Processor 🚀

A distributed system designed for massive event ingestion and asynchronous processing using **.NET 10** and **C# 14**.

## 🏗️ Architecture

- **API Ingestion**: High-performance Minimal API for receiving events.
- **Message Broker**: RabbitMQ for reliable asynchronous communication.
- **Worker Service**: Scalable processors with idempotency logic.
- **Storage**: PostgreSQL with optimized write-heavy schemas (EF Core).
- **Cache**: Redis for message deduplication and idempotency.

## 🛠️ Tech Stack
- .NET 10 (C# 14)
- Docker & Docker Compose
- RabbitMQ
- Redis
- PostgreSQL
- Serilog (Structured Logging)
- xUnit, Moq & FluentAssertions (TDD)

## 📂 Project Documentation
Follow the technical details of each functionality:
- [01 - Event Ingestion Contract](./docs/01-event-ingestion-contract.md)

## 🚀 Roadmap & Features
- [ ] **Feature 01**: Event Ingestion Contract (Starting)
- [ ] **Feature 02**: RabbitMQ Integration (Outbox Pattern)
- [ ] **Feature 03**: Worker Service & Asynchronous Processing
- [ ] **Feature 04**: Persistência com EF Core & Idempotência (Redis)
- [ ] **Feature 05**: Observabilidade e Health Checks

## 🐳 How to Run
```bash
docker-compose up -d
```