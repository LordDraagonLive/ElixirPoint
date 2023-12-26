# ElixirPoint

## Plan & Requirements Gathering Report for Elixir Point

### Project Overview
- **Project Name**: Elixir Point
- **Project Goal**: Develop a POS and Retail Stock Management application for small businesses, scalable to multiple businesses.
- **Target Audience**: Small businesses.

### Technical Requirements
- **Technology Stack**: .NET Core 8 Web API for backend, TypeScript framework for frontend.
- **Hosting**: On-premises on a Linux server.
- **Hardware Integration**: Compatibility with small bill printers.
- **Database**: PostgreSQL, with daily backups using `pg_dump`.

### Features and Functionality
- **Sales Transactions**: 
  - Support sales, returns.
  - Enable editing of bills post-printing for adding or changing items.
- **Receipts**: Compact bilingual receipts (English and Sinhala), with a small header for company details.
- **Product Categorization**: Initial categorization by supplier, future categorization by types.
- **Inventory Management**: Manage stock during sales and restocking, handle supplier payments and track pending payments.
- **Reporting**: Reports on stock levels, profit and loss (daily/monthly/yearly), best and worst selling products.

### User Experience and Design
- **UI/UX Design**: Minimal and simple with a dark mode.
- **UI Language**: Exclusively English.

### Compliance and Data Security
- **Regulatory Compliance**: None specified.
- **Data Security**: Basic data security measures.

### Integration and Scalability
- **Third-Party Integrations**: None planned.
- **Scalability**: Designed for a single small business, scalable to multiple businesses within two years.

### Support and Maintenance
- **Support Requirements**: None specified.
- **Update and Maintenance Plan**: Monthly updates, maintenance on off days.
- **Data Backup and Recovery**: Daily database backups with `pg_dump`, stored on a separate disk in the same server.

### Project Timeline and Budget
- **Timeline**: 
  - Design and Planning: 1 week
  - Backend and API Development: 1 week
  - UI Design and Development: 2 weeks
- **Budget**: Not a constraint.

### Stakeholders
- **Internal**: Employers, Employees.
- **External**: Customers, Suppliers.

### Development Team
- A team is available for development.

---
