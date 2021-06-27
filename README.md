# This is a User management API

This is a simple API that implements CRUD operations on a User entity.

You can add a user and the following fields: Id, first name, last name, email and password.

`GET` api/Users <br>
You can get a list of all the users in JSON format.
```
    {
        "Id": 1,
        "FirstName": "Margareta",
        "LastName": "Diacenco",
        "Email": "margaretadiacenco@gmail.com",
        "Password": "DoNotTellAnyone"
    },
    {
        "Id": 2,
        "FirstName": "Vladimir",
        "LastName": "Adajuc",
        "Email": "adajucvlad@gmail.com",
        "Password": "TellEveryone"
    }
```
`GET` api/Users/{id} <br>
You can get a list of all the users by id in JSON format, in this case, if id = 2.

`PUT` api/Users/{id} <br>
You can update a user by id by inserting the necessary update(s) in the body of the request, in JSON format.

`POST` api/Users <br>
You can add a new user or multiple users by inserting the necessary information in the body of the request.

`DELETE` api/Users/{id} <br>
You can delete a certain user by inserting the necessary id in the link.

*Note: all the fields are required.
