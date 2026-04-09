# e-Shift Household Goods Shifting System

## 🚚 Project Overview
e-Shift is a centralized desktop application developed to modernize and automate the operations of a household goods shifting company. The system replaces manual processes with a digital solution for managing the full lifecycle of logistics, from customer inquiries to job completion and fleet tracking.



## 🛠 Tech Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET
* **Design:** Figma (UI/UX Design & Prototyping)

## ✨ Key Features
* **Three-Tier Architecture:** Implemented a modular design consisting of the **Presentation Layer** (UI), **Business Logic Layer** (Validation & Rules), and **Data Access Layer** (Database interaction) for maximum maintainability.
* **Automated Job Management:** Streamlined workflow for creating, assigning, and tracking moving jobs.
* **Administrative Dashboard:** A centralized command center for fleet coordination, allowing admins to manage drivers, vehicles, and customer data.
* **Role-Based Access Control (RBAC):** Secure login and access management ensuring that sensitive logistical data is only accessible to authorized personnel.
* **Data-Driven Reporting:** Generates comprehensive delivery performance reports and operational summaries to assist in business decision-making.
* **Load Tracking:** Digital logging of cargo details to ensure accuracy during the shifting process.

## ⚙️ Technical Highlights
* **System Design:** Structured using Object-Oriented Programming (OOP) principles in C# to ensure code reusability.
* **Database Management:** Utilized ADO.NET for efficient communication between the application and SQL Server, handling complex queries for job allocation.
* **UI/UX:** Designed high-fidelity wireframes in Figma before implementation to ensure a user-friendly experience for non-technical staff.

---

## 🚀 Getting Started

### Prerequisites
* Windows OS
* Visual Studio (2019 or later recommended)
* .NET Framework 4.7.2 or higher
* SQL Server LocalDB or Express

### Installation
1. **Clone the repository.**
2. **Database Setup:**
      Open the SQL scripts provided in the /Database folder.
      Execute them in your SQL Server Management Studio (SSMS) to create the required tables and relationships.

4. **Configuration:**
      Open the solution (.sln) in Visual Studio.
      Update the connection string in the App.config file to match your local SQL Server instance.

5. **Build & Run:**
    Press F5 or click Start in Visual Studio to launch the desktop application.
