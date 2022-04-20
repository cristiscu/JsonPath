JSON Path for Snowflake
==============================
Small tool that generates and runs SQL queries on inline semi-structured JSON data in Snowflake from XPath-like search expressions. This is not a production-ready product! It is used just to explore how to create equivalent SQL queries in Snowflake with XPath-like expressions.

Example Usage
-------------

To connect at Snowflake, save a **SNOWFLAKE_CONNSTR** environment variable with the following format:

**<code>account=your-snowflake-account;user=your-username;password=your-password;</code>**  

Load the solution in Visual Studio (the free Community Edition), update the NuGet packages, compile and run.

![Screen](/images/JSON-Path-for-Snowflake.png)

* Switch between different built-in JSON Path expression from the top combo box. Create your own or customize any of them, then click Run.  
* Compare the result generated from [Json.NET](https://www.newtonsoft.com/json) internally, with the dynamic result or running the generated query in Snowflake.  
* Both Ourput Data and Query Result show one or more rows of returned data.  
