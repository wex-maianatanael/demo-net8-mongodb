# demo-net8-mongodb-provider

### Overview

This repo shows how to use the EF Core MongoDB provider.

### How to run it

In order to run this demo locally, go trough the following steps:

1. Run the `docker-compose up -d` command to setup the mongodb environment (mongodb + mongodb-express);

2. Creates the DB called `my_sample_db` via mongodb express interface;

3. Creates a new document called `users` under this new db;

4. Run the Web API project and send a request to return a list of users from mongodb.

ℹ️ _Note that if we wanted to create both DB (`my_sample_db`) and document (`users`) automatically, we should use the methods `GetDatabase` and `GetCollection` when setting up the mongodb instance in the source code. So, when running the application, if the db and document weren't there, the they'd be created at runtime. That's why we need to create them manually._

### External Refs.

- [MongoDB EF Core Provider doc](https://www.mongodb.com/docs/entity-framework/current/)
- [MongoDB EF Core Provider GitHub repository](https://github.com/mongodb/mongo-efcore-provider)
- [MongoDB EF Core Provider API Reference](https://mongodb.github.io/mongo-efcore-provider/8.0.0/api/)
