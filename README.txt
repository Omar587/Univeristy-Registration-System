The University database schema is laid out with a lot of foreign keys to model the relationships between entities and constrain system integrity. The schema is normalized and efficient.

Materialized views are used for viewing the prerequisites. While quite large, it speeds up the checking of perquisites immensely by avoiding simultaneous large joins which would cause latency with many network clients. It also allows for the economical creation of the last 5 years’ worth of active students. Even though the get_students stored procedure uses “distinct” with the query, we know this is just a list of unique index names which is already distinct and can be filtered for age.

Stored procedures are extensively used for all underlying application functions. There are no queries in the code, they are all compiled on the server to execute faster. Multiple parameters help them integrate into the code.

Transactions are implemented to provide concurrency and preserve ACID properties.

Biz:

The University system has maximum 100 students in a class.

You must satisfy the prerequisite, if one exists.

Current registrations list shows both in-progress and newly added classes if the Registration process is successful.


To run this program

run the create statements to create the sample data in the SAMPLE DATA folder.

run the create statements in schema folder for the stored procedures. 

then run the program in visual studios.



