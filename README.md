This project demonstrates the Strangler Fig Pattern using Facade Design Pattern in C#. It simulates a phased migration from an old legacy order management system to a new one.

Key Features:
Implements a Facade class to seamlessly switch between the legacy and new order systems.
Determines the appropriate system based on configurable conditions.
Designed to support gradual migration, ensuring minimal disruption to the existing functionality.
How It Works:
LegacyOrderService: Represents the old system for handling orders.
NewOrderService: Represents the new, improved system for handling orders.
OrderServiceFacade: Acts as an intermediary, directing orders to the appropriate system based on defined rules.
This approach allows for a smooth, incremental transition to the new system without affecting current operations.

Getting Started:
Clone the repository and run the project as a console application. Modify the conditions in the OrderServiceFacade to experiment with different migration scenarios.
