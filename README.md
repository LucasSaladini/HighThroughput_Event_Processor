# HighThroughput_Event_Processor

A distributed system designed for massive event ingestion and asynchronous processing using **.**NET 10** and **C# 14**.

## 🏗️ Architecture

- **API Ingestion**: High-performance Minimal API for receiving events.
- **Message Broker**: RabbitMQ for reliable asynchronous communication.
- **Worker Service**: Scalable processors with idempotency logic.
- **Storage**: PostgreSQL with optimized write-heavy schemas.
- **Cache**: Redis for message deduplication.

## 🛠️ Tech Stack
- .NET 10 (C# 14)
- Docker & Docker Compose
- RabbitMQ
- Redis
- PostgreSQL
- Serilog (Structured Logging)

## 🐳 How to Run
```
docker-compose up -d
```

