# Contact-Management
Evolent Project
REST API ContactManagement application
Used Repositorty Pattern , Dependency Injection (IOC) with Unity Container
Multi layerd architecture BussinessLayer, DataLayer, InterfaceLayer
Exception Handling in api
Added ReadMe folder having tested api  in postman
in Connection String need to change the "DataSource"
Also Attached the DBbackup file "ContactManagementdb.bak" where i have created a Contact Table having multiple recods in it 

API Example:

**Show Contact**
----
  Returns json data about a single user.

* **URL**

  /Contact/:id

* **Method:**

  `GET`
  
*  **URL Params**

   **Required:**
 
   `id=[integer]`

* **Data Params**

  None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ id : 2, name : "Kamlesh Singh" }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ error : "No Contact found with id=4" }`

* **Sample Call:**

  ```javascript
    $.ajax({
      url: "/Contact/4",
      dataType: "json",
      type : "GET",
      success : function(r) {
        console.log(r);
      }
    });
  ```
