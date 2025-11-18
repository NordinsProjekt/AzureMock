# Azure Portal Mock - Training Environment

## Overview
This is a mock Azure Portal specifically designed for teaching SQL Server and Database creation in Azure **without incurring any actual costs**. It simulates the Azure Portal experience, allowing students to practice creating and managing Azure SQL resources in a safe, cost-free environment.

## Features

### ? Fully Simulated Azure Portal
- Authentic Azure Portal look and feel
- Azure-style navigation and interface
- **Beautiful SVG icon system** with 25+ icons
- Animated icons and hover effects
- No connection to real Azure services
- **Zero cost** - everything is simulated

### ?? Amazing SvgIcon Component
- **25+ professionally designed icons** including:
  - SQL Server, SQL Database
  - App Service, Virtual Machines, Functions, Containers
  - Storage, Key Vault, Network
  - Cost Management, Monitor, Dashboard
  - And many more!
- **Multiple sizes** - 24px, 32px, 48px, 64px, 96px
- **Animations** - Optional pulse animation
- **Hover effects** - Icons lift and brighten on hover
- **Fully customizable** - Add CSS classes and inline styles
- **Type-safe** - Uses enum for icon selection

### ??? SQL Server Management
- Create SQL Servers with realistic configuration options
- Configure server settings (name, location, admin credentials)
- Multi-step wizard interface matching real Azure
- View all SQL Servers
- Delete SQL Servers

### ?? Database Management
- Create databases on SQL Servers
- Configure pricing tiers (Basic, Standard, Premium)
- Set compute tiers (Provisioned, Serverless)
- Configure database size and collation
- View connection strings
- Delete databases

### ?? Resource Management
- Resource Groups organization
- View all resources across the portal
- Track resource creation dates and status

## Getting Started

### Prerequisites
- .NET 9 SDK
- Visual Studio 2022 or VS Code

### Running the Application

1. **Clone or open the project**
   ```bash
   cd AzureMock
   ```

2. **Run the application**
   ```bash
   dotnet run
   ```

3. **Open your browser**
   - Navigate to `https://localhost:5001` or `http://localhost:5000`
   - You'll see the Azure Portal home page

## Student Exercises

### Exercise 1: Create Your First SQL Server
1. From the home page, click on **SQL Server** card or navigate to **SQL Servers** in the left menu
2. Click **+ Create SQL Server**
3. Follow the wizard:
   - **Basics**: Configure server name, location, and admin credentials
   - **Networking**: Review networking settings (all simulated)
   - **Security**: Review security options (all simulated)
   - **Review + Create**: Review and create the server
4. Notice the deployment simulation (2-second delay)

### Exercise 2: Create a Database
1. Navigate to your SQL Server
2. Click **+ Create Database**
3. Configure the database:
   - **Basics**: Set database name and collation
   - **Compute + Storage**: Choose pricing tier and size
   - **Review + Create**: Create the database
4. View the connection string for your database

### Exercise 3: Resource Organization
1. Create multiple SQL Servers in different resource groups
2. Navigate to **All Resources** to see everything
3. Navigate to **Resource Groups** to see organization
4. Practice deleting resources

## Teaching Points

### Azure Concepts Covered
- **Resource Groups**: Logical containers for organizing resources
- **Regions/Locations**: Geographic distribution of resources
- **SQL Server vs Database**: Understanding the hierarchy
- **Pricing Tiers**: Different service levels and their purposes
- **Connection Strings**: How applications connect to databases
- **Authentication**: SQL authentication with username/password
- **Collation**: Database sorting and comparison rules

### Key Learning Outcomes
? Students understand the Azure Portal navigation  
? Students can create and configure SQL Servers  
? Students understand resource hierarchy (Resource Group ? Server ? Database)  
? Students can configure database pricing tiers  
? Students understand connection strings  
? Students practice without fear of costs  

## Architecture

### Project Structure
```
AzureMock/
??? Models/
?   ??? SqlServer.cs          # SQL Server model
?   ??? SqlDatabase.cs        # Database model
?   ??? ResourceGroup.cs      # Resource Group model
??? Services/
?   ??? AzureResourceService.cs  # In-memory resource management
??? Components/
?   ??? Layout/
?   ?   ??? AzurePortalLayout.razor  # Main portal layout
?   ??? Pages/
?       ??? PortalHome.razor         # Home page
?       ??? CreateSqlServer.razor    # Server creation wizard
?       ??? SqlServers.razor         # Server list
?       ??? SqlServerDetail.razor    # Server details
?       ??? CreateDatabase.razor     # Database creation wizard
?       ??? ResourceGroups.razor     # Resource groups list
?       ??? AllResources.razor       # All resources view
??? wwwroot/
    ??? azure-portal.css      # Azure-style CSS
```

### Technologies Used
- **Blazor Server** (.NET 9) - Interactive UI framework
- **In-Memory Storage** - No database required
- **Singleton Service** - Shared state across sessions

## Customization

### Adding New Resource Types
To add more Azure resource types (e.g., Storage Accounts, VMs):
1. Create a new model in `Models/`
2. Add service methods in `AzureResourceService.cs`
3. Create pages in `Components/Pages/`
4. Add navigation links in `AzurePortalLayout.razor`

### Modifying Available Options
- **Locations**: Edit `GetLocations()` in `AzureResourceService.cs`
- **Pricing Tiers**: Edit the dropdown options in `CreateDatabase.razor`
- **Default Values**: Modify model constructors

### Styling
All Azure-style CSS is in `wwwroot/azure-portal.css`. Modify CSS variables at the top to change the color scheme:
```css
:root {
    --azure-blue: #0078d4;
    --azure-dark-blue: #106ebe;
    --azure-light-blue: #50e6ff;
    /* ... more variables ... */
}
```

## Important Notes

### ?? This is a Training Tool
- **No real Azure connection**: Nothing connects to actual Azure
- **No costs incurred**: Everything is simulated
- **No authentication**: No real Azure credentials needed
- **In-memory only**: Data is lost when the app restarts
- **Single instance**: All users share the same data (singleton service)

### For Production Use
If you want to make this persist data or support multiple users:
1. Replace `AzureResourceService` singleton with a scoped service
2. Add a database (SQL Server, SQLite, etc.)
3. Implement proper authentication
4. Add data persistence in the service layer

## Troubleshooting

### Port Already in Use
If you get a port conflict, edit `Properties/launchSettings.json` to change the port numbers.

### Data Not Persisting
This is expected - the app uses in-memory storage. Restart the app to reset all data.

### Styling Issues
Make sure `azure-portal.css` is properly referenced in `App.razor`.

## Credits

Built with:
- ASP.NET Core Blazor
- .NET 9
- Inspired by the real Microsoft Azure Portal

## Using the SvgIcon Component

The `SvgIcon` component provides beautiful, reusable Azure-style icons throughout the application.

### Basic Usage
```razor
<SvgIcon Icon="IconType.SqlServer" Size="48" />
```

### With Animation
```razor
<SvgIcon Icon="IconType.Monitor" Size="64" Animated="true" />
```

### Custom Styling
```razor
<SvgIcon Icon="IconType.Network" Size="32" CssClass="my-custom-class" Style="margin: 10px;" />
```

### Available Icons
Visit `/icon-showcase` in the app to see all available icons with live examples!

Available icon types include:
- **Core Services**: CreateResource, SqlServer, SqlDatabase, ApplicationInsights, Subscriptions, AppService, CostManagement, Credits, Network, AzureOpenAI, EntraId
- **Resource Management**: ResourceGroups, AllResources, Dashboard, Monitor
- **Security & Storage**: Security, Storage, KeyVault
- **Compute**: VirtualMachine, Functions, Container
- **DevOps**: DevOps
- **UI Elements**: Notification, Empty

### Component Properties
| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `Icon` | IconType | CreateResource | The icon to display |
| `Size` | string | "48" | Size in pixels (width and height) |
| `Animated` | bool | false | Enable pulse animation |
| `CssClass` | string | "" | Additional CSS classes |
| `Style` | string | "" | Inline CSS styles |

---

**Perfect for**: 
- Database Administration courses
- Cloud Computing classes  
- Azure certification training
- Self-paced learning

**No Azure subscription required!** ??
