Home Test Specification – C# Developer
Goal
Build a simple Web API that retrieves client records from a CSV file based on a given country code.
General Expectations
•	There is no time limit for this assignment. The candidate is encouraged to take as much time as needed to produce high-quality code.
•	The solution should reflect the candidate's best coding practices.
•	While the core functionality is simple, feel free to showcase your skills. 
Requirements
1. Functionality
•	Create a .NET Core Web API using the latest LTS version (e.g., .NET 8).
•	Implement a GET endpoint that:
o	Accepts a country_code parameter.
o	Reads data from a CSV file named clients.csv.
o	Returns all client records where the country_code in the CSV matches the input.
2. CSV Format
The clients.csv file should be placed in a directory accessible to the API (e.g., App_Data/ or Data/).
Expected CSV Columns (with header):
•	client_id (int)
•	name (string)
•	tax_id (string)
•	country_code (string)
