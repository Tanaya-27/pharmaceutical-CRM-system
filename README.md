# CRM system for a pharmaceutical company
My implementation of a Customer Relationship Managegement (CRM) system in C# using Visual Studio, based around a startup pharmaceutical company that centres around dermatology. The system involves CRM as well as graphical sales figures (graphs, top ten sellers/buyers) built from the client's input data.

## Background
This system is for a pharmaceutical company specialising in dermatology (mostly creams and ointments for eczema). The primary client is a healthcare development executive, who must conduct frequent meetings with, as well as send product samples to, pharmacists and GPs. Interactions with their consultants must be documented, along with any orders made. Sales data, put out on a monthly to daily basis, is also useful to HDEs while at work, to keep track of top purchasers, products etc. On their current system, however, graphical figures are held on a spreadsheet, separate to customer relationship data. The company requires a ‘CRM’ system: Customer Relationship Management.
<br><br>
The respective Entity-Relationship diagram is as follows:
<br><br>
![image](https://github.com/Tanaya-27/pharmaceutical-CRM-system/assets/75646651/5bf90e0b-0cba-49f7-91f4-b8fe80d86b4f)

## Features
- **User Authentication and Authorization:** Secure user registration and login functionality ensures that only authorized personnel can access and manipulate sensitive customer and business data.
- **Contact Management:** Efficiently manage contacts, including healthcare professionals, doctors, pharmacists, and medical institutions. Store and organize contact details, communication history, and relevant notes.
- **Product Catalog:** Maintain an up-to-date catalog of pharmaceutical products. Associate products with customers, track product preferences, and manage stock information.
- **Interaction Tracking:** Log and track interactions with customers, including meetings, calls, emails, and other forms of communication, and schedule alike interactions. This aids in maintaining a clear history of engagements and facilitating follow-ups.
- **Reports and Analytics:** Generate reports and gain insights into customer interactions, product preferences, and sales trends. Make informed decisions based on data-driven, visual analytics.
- **Task Management:** Assign tasks to team members by appointing clinical commissioning groups, and keep track of task statuses. Ensure efficient collaboration and timely follow-ups.

## Setup and Installation
1. Clone this repository to your local environment.
2. Set up the relational database (MS Access SQL Server recommended) and update the file on the bin/Debug path
4. Run the provided `.exe` file in bin/Debug, or alternatively build and run the project using Visual Studio or your preferred C# development environment.
5. Access the CRM system and complete authentication.

## User Acceptance Testing
Testing involves validating the system's functionality, usability, and overall performance from an end-user perspective, ensuring the system aligns with predisposed user requirements and specifications by mimicing an end user. A [full test](https://www.youtube.com/playlist?list=PLymLVDm7FWfjtw3ekLNX-tTZZl8pFxi6z) of the working system can be found via the YouTube link.
<br>

---
An example of the initial Dashboard page is as follows:
<br><br>
![image](https://github.com/Tanaya-27/pharmaceutical-CRM-system/assets/75646651/acd6e2f2-a494-4739-b355-1ea7ba167e47)


> Please note: The completed system has been implemented with faux sales data in the form of a MS Access database, to demonstrate the product's features. This application could be administered with different data, and indeed by a different pharmaceutical sales business.
