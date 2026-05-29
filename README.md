# RAION
## About
Platform for operation orientation in cloud. 


## TOC
- [About](#about)
- [TOC](#toc)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Services](#services)
- [Api end-points](#api-end-points)
- [Architecture](#architecture)
  - [Gateway](#gateway)
- [Prerequisites and Technologies](#prerequisites-and-technologies)
- [Todo:](#todo)



## Requirements

<details>

- Spread set of servers for computation. 
- Data synchronization between services.
- Analyze and File exchange.
- Report generation.
- Webhooks.
- Data processing from outer sources.

- Process id (hash).
- Process operation type.
- Creation data.
- State.
- Result.
- Computation time.
- Logs of errors and timeouts.

- synchronized response.
- asynchronous response.

- registration of new operation.
- Download information of state and operation history.
- Multithreading.
- Fallback scenarios of errors, timeouts and unsuccessful actions.
- Api layers separation and integration communications.
- Tests.
- E2E Tests.
- REST API.
- .NET 8+
- HTTP communication.
- Data consistency.
- Retry/Rollback.
- Operation Abort.
- docker-dev.
- docker-prod.
- Swagger/OpenAPI.
- Queue communication.
- Workers.
</details>



## Installation



## Usage



## Services
- **gateway** main entry
- **control** control server

- **nextjs** (frontend)

- **keycloak** (user/service JWT Tokens)
- **main database (redis)** (Log/Control Database)

- **compute** computation server
- **cache database (redis)** (Storage Database)



## Api end-points



## Architecture
1. All outside request goes to **gateway**.
2. Main point of **control** is assigning tasks to **compute** servers.
3. Authentication is provided via dynamic tokens.
4. Visual interface is provided by **nextjs**.
5. Each user is registered to **keycloak**.
6. Services are registered via **keycloak**.
7. Each **compute** server have **cache database** to lower data transfer.
8. We store data in **main database**.
9. We allows multiple instances of **compute server**.

### Gateway



## Prerequisites and Technologies
- **docker**: v29.5.0
- **.NET**: v9.0
- **redis**: v7
- **keycloak**
- **cloudflare**



## Todo:

<details open>
<summary>🌟 Iteration 1. 🌟</summary>


</details>