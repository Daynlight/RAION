# RAION
## About
Platform for operation orientation in cloud. 


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
- **compute** computation server

- **nextjs** (frontend)

- **keycloak** (user JWT Tokens)
- **control database (redis)** (Log/Control Database)
- **resource database (redis)** (Storage Database)



## Api end-points



## Architecture
1. All outside request goes to **gateway**.
2. Main point of **control** is assigning tasks to compute servers.
3. Authentication is provided via dynamic tokens.
4. Each user is registered to **keycloak**.
5. Visual interface is provided by **nextjs**.
6. Each operation, data and register have [**id**, **creation time**].
7. Each **compute** server have **resource database** to lower data transfer.
8. In **control** we store last versions of resources.



## Prerequisites and Technologies
- **docker**
- **.NET**
- **redis**
- **keycloak**
- **cloudflare**



## Todo:

<details open>
<summary>🌟 Iteration 1. 🌟</summary>


</details>