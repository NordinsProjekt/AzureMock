# Azure Portal Mock - Educational Training Environment

<div align="center">

![Azure Training](https://img.shields.io/badge/Azure-Training%20Environment-0078D4?style=for-the-badge&logo=microsoft-azure&logoColor=white)
![Education](https://img.shields.io/badge/Purpose-Education-success?style=for-the-badge&logo=academia&logoColor=white)
![No Cost](https://img.shields.io/badge/Cost-FREE-brightgreen?style=for-the-badge)
![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

### ?? A Safe, Cost-Free Azure Learning Platform for Classroom Education

*Practice Azure SQL Server and Database management without spending a penny or risking production systems*

[Getting Started](#-getting-started-for-instructors) • [Student Guide](#-for-students) • [Features](#-what-students-will-learn) • [Exercises](#-classroom-exercises)

</div>

---

## ?? Educational Purpose

**This is NOT a production application.** This is a **fully simulated Azure Portal environment** specifically designed for:

- **College and University Courses**: Database Administration, Cloud Computing, DevOps
- **Technical Training Programs**: Azure certification prep, IT bootcamps
- **Self-Paced Learning**: Students learning Azure independently
- **Workshops and Seminars**: Hands-on Azure training sessions

### Why This Project Exists

Real Azure Portal training presents several challenges for education:
- ? **Cost barriers**: Students need credit cards or institutional accounts
- ? **Risk of charges**: Accidental misconfiguration can incur unexpected costs
- ? **Fear of mistakes**: Students hesitate to experiment
- ? **Resource limits**: Free tiers have restrictions
- ? **Cleanup complexity**: Forgetting to delete resources costs money

**Azure Mock solves all of these problems:**
- ? **Zero cost**: No Azure subscription needed
- ? **Zero risk**: Nothing connects to real Azure
- ? **Safe experimentation**: Students can try, fail, and retry
- ? **Unlimited resources**: Create as many servers as needed
- ? **Instant reset**: Restart the app to start fresh

---

## ?? What Students Will Learn

### Core Azure Concepts

#### 1. **Resource Management**
- Understanding **Resource Groups** as logical containers
- Organizing resources by project, environment, or department
- The hierarchy: Subscription ? Resource Group ? Resources
- Best practices for naming conventions

#### 2. **Azure SQL Server Architecture**
- Difference between **SQL Server** (logical container) and **SQL Database** (actual database)
- Server-level vs database-level configuration
- Connection strings and authentication
- High availability and disaster recovery concepts

#### 3. **Cloud Economics & Pricing**
- How Azure pricing tiers work (Basic, Standard, Premium)
- Understanding **DTUs** (Database Transaction Units)
- **Compute tiers**: Provisioned vs Serverless
- Storage costs and backup redundancy options
- Cost optimization strategies

#### 4. **Security & Compliance**
- **Network security**: Public endpoints, private endpoints, firewall rules
- **Data encryption**: TDE (Transparent Data Encryption)
- **Identity management**: SQL authentication vs Azure AD
- **Threat protection**: Microsoft Defender for SQL
- **Audit logging**: Tracking database access and changes

#### 5. **Performance & Scalability**
- Choosing appropriate pricing tiers for workload
- Understanding connection policies (Proxy vs Redirect)
- Backup storage redundancy (LRS, ZRS, GRS)
- Maintenance windows and update strategies

### Learning Methodology

This project uses **interactive tooltips** throughout the interface. Every configuration option includes:
- ?? **Clear explanation** of what the option does
- ?? **Cost information** (from free to enterprise pricing)
- ?? **When to use** this option
- ? **Performance implications**
- ?? **Security considerations**
- ? **Best practices**

Students learn by **doing** and **reading** simultaneously, reinforcing concepts through hands-on practice.

---

## ????? Getting Started for Instructors

### Prerequisites

**Software Requirements:**
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) (free)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) (both free)
- Any modern web browser

**System Requirements:**
- Windows, macOS, or Linux
- 4GB RAM minimum (8GB recommended)
- 500MB free disk space

### Installation & Setup

#### Option 1: Clone from GitHub
```bash
# Clone the repository
git clone https://github.com/NordinsProjekt/AzureMock.git

# Navigate to project directory
cd AzureMock/AzureMock

# Run the application
dotnet run
```

#### Option 2: Download ZIP
1. Download the ZIP file from the repository
2. Extract to a folder
3. Open terminal/command prompt in the `AzureMock/AzureMock` folder
4. Run `dotnet run`

#### Option 3: Open in Visual Studio
1. Open `AzureMock.sln` in Visual Studio 2022
2. Press **F5** or click **Run**

### First Launch

Once running, open your browser to:
- **HTTPS**: `https://localhost:5001`
- **HTTP**: `http://localhost:5000`

You'll see the Azure Portal home page. The application is ready for student use!

### Classroom Setup Recommendations

#### ??? **Lab Environment Setup**

**Option A: Each Student Runs Locally**
- Students install .NET 9 SDK on their computers
- Each student runs their own instance
- Data is isolated per student
- Best for: Computer labs, individual laptops

**Option B: Shared Server**
- Deploy to a shared server accessible by students
- All students share the same data (collaborative learning)
- Requires network setup
- Best for: Demonstrating group work, limited hardware

**Option C: Cloud-Hosted Demo**
- Deploy to Azure, AWS, or other hosting
- Access via web browser only
- No local installation needed
- Best for: Large classes, remote learning

#### ?? **Recommended Teaching Sequence**

**Week 1: Introduction to Azure**
- Demonstrate the Azure Portal Mock interface
- Explain resource groups and organization
- Have students create their first resource group

**Week 2: SQL Server Fundamentals**
- Create a SQL Server (step-by-step as a class)
- Discuss regions, authentication, and naming
- Review the multi-tab wizard interface

**Week 3: Database Creation**
- Create databases on existing servers
- Compare pricing tiers and their implications
- Introduce connection strings

**Week 4: Security & Best Practices**
- Review security options (TDE, Defender, firewalls)
- Discuss network connectivity options
- Analyze cost vs security trade-offs

**Week 5: Real-World Scenarios**
- Cost optimization exercises
- Security hardening scenarios
- Disaster recovery planning

---

## ????? For Students

### How to Use This Application

#### 1. **Navigate the Portal**
The left sidebar contains all major sections:
- **Home**: Overview of available services
- **Create a resource**: Start creating new resources
- **SQL Servers**: Manage SQL Server instances
- **Resource Groups**: Organize your resources
- **All Resources**: See everything you've created

#### 2. **Read the Tooltips**
Hover over any **?? icon** to learn:
- What the option does
- How much it costs in real Azure
- When you should use it
- Security and performance considerations

#### 3. **Experiment Freely**
- Try different pricing tiers
- Create multiple servers
- Delete and recreate resources
- Make mistakes and learn from them
- **No risk of charges!**

### Student Exercises

#### ?? **Exercise 1: Create Your First SQL Server**

**Objective**: Understand SQL Server creation and configuration

**Steps**:
1. Click **SQL Server** from the home page
2. Click **+ Create SQL Server**
3. Complete the wizard:
   - **Basics Tab**:
     - Name your server (must be globally unique)
     - Choose a region close to you
     - Create admin credentials
   - **Networking Tab**:
     - Review firewall options
     - Enable Azure services access
   - **Security Tab**:
     - Note the security features
     - Observe which are free vs paid
   - **Review + Create**:
     - Review your configuration
     - Click **Create**

**Learning Points**:
- Why server names must be globally unique
- How regions affect latency and pricing
- Authentication best practices
- Free vs paid security features

**Deliverable**: Screenshot of your created SQL Server details page

---

#### ?? **Exercise 2: Database Pricing Analysis**

**Objective**: Understand Azure database pricing tiers

**Steps**:
1. Navigate to your SQL Server
2. Click **+ Create Database**
3. On the **Basics** tab, hover over the **Pricing Tier** tooltip
4. Document each tier:
   - Basic: Cost, DTUs, storage, use cases
   - Standard S0/S1/S2: Compare features
   - Premium P1/P2: Enterprise scenarios
5. Choose **Standard S1** and complete creation

**Learning Points**:
- What are DTUs and why they matter
- How to choose appropriate tiers for workloads
- Cost vs performance trade-offs
- Serverless vs Provisioned compute

**Deliverable**: Comparison table of all pricing tiers with your recommendations

---

#### ?? **Exercise 3: Security Configuration**

**Objective**: Learn about database security layers

**Steps**:
1. Create a new SQL Server
2. Review each security tab carefully
3. Read tooltips for:
   - Microsoft Defender (~$15/month)
   - TDE (Transparent Data Encryption - free)
   - SQL Auditing
   - Network isolation options
4. Document security recommendations for:
   - A development environment
   - A production e-commerce site
   - A healthcare application (HIPAA)

**Learning Points**:
- Defense in depth strategy
- Free security features vs paid
- Compliance requirements
- Network security vs data security

**Deliverable**: Security recommendation document for three scenarios

---

#### ?? **Exercise 4: Cost Optimization Challenge**

**Objective**: Optimize Azure costs for different scenarios

**Scenario A: Startup on a Budget**
- Requirements: Small web app, 100 users, low budget
- Task: Choose cheapest viable configuration
- Target: Under $10/month

**Scenario B: Enterprise Production**
- Requirements: Critical app, 10,000 users, high availability
- Task: Choose optimal configuration balancing cost and reliability
- Target: Under $100/month

**Scenario C: Development/Test**
- Requirements: Only used during work hours (8am-6pm weekdays)
- Task: Maximize savings using Serverless compute
- Task: Calculate monthly savings

**Learning Points**:
- Right-sizing resources
- Serverless benefits for intermittent workloads
- Backup redundancy cost differences
- When to prioritize cost vs performance

**Deliverable**: Cost analysis spreadsheet with recommendations

---

#### ?? **Exercise 5: Resource Organization**

**Objective**: Master resource group organization

**Steps**:
1. Create 3 resource groups:
   - `rg-dev-northeurope`
   - `rg-test-northeurope`
   - `rg-prod-northeurope`
2. Create SQL Servers in each:
   - Development: Basic configuration
   - Test: Mid-tier configuration
   - Production: High-availability configuration
3. Create 2-3 databases in each server
4. Navigate to **All Resources** view
5. Filter by resource group

**Learning Points**:
- Naming conventions
- Environment separation
- Resource organization strategies
- Lifecycle management

**Deliverable**: Resource architecture diagram with naming strategy

---

## ?? Features Overview

### ? **Realistic Azure Interface**
- Authentic Azure Portal look and feel
- Multi-step wizard forms (just like real Azure)
- Breadcrumb navigation
- Card-based service catalog
- Professional styling and icons

### ?? **Visual Learning Tools**
- **25+ custom SVG icons** for Azure services
- Color-coded sections and status indicators
- Interactive hover effects
- Visual feedback for actions
- Progress indicators

### ?? **Resource Management**
- Create and manage SQL Servers
- Create and configure databases
- Organize with resource groups
- View all resources at a glance
- Delete resources (with confirmation)
- Track creation dates and status

### ?? **Educational Tooltips**
Over **55+ interactive tooltips** covering:
- Configuration options explained
- Real Azure pricing information
- Security best practices
- Performance considerations
- When to use each option
- Cost optimization tips

### ?? **Cost Transparency**
Realistic pricing information for:
- **Database tiers**: $5/month (Basic) to $930/month (Premium P2)
- **Security features**: Free (TDE) to $15/month (Defender)
- **Storage redundancy**: $0.05/GB (LRS) to $0.10/GB (GRS)
- **Network options**: Free (public) to $10/month (private endpoint)

### ?? **Security Education**
Learn about:
- Transparent Data Encryption (TDE)
- Microsoft Defender for SQL
- Firewall rules and IP whitelisting
- Private endpoints and VNet integration
- Azure AD authentication
- Managed identities
- SQL Auditing
- Database ledger

### ? **Performance Concepts**
Understand:
- DTUs (Database Transaction Units)
- Provisioned vs Serverless compute
- Connection policies (Proxy vs Redirect)
- Storage performance tiers
- Elastic pools for resource sharing

---

## ??? Technical Architecture

### Technology Stack

**Frontend**: Blazor Server (.NET 9)
- Interactive UI without JavaScript
- Real-time updates via SignalR
- Component-based architecture

**Backend**: ASP.NET Core (.NET 9)
- In-memory data storage (no database needed)
- Singleton service for state management
- MVC pattern for organization

**Styling**: Custom CSS
- Azure Portal color scheme
- Responsive design
- Modern UI components

### Project Structure

```
AzureMock/
??? Components/
?   ??? Layout/
?   ?   ??? AzurePortalLayout.razor    # Main portal layout
?   ?   ??? MainLayout.razor           # Base layout
?   ?   ??? NavMenu.razor              # Navigation sidebar
?   ??? Pages/
?   ?   ??? PortalHome.razor           # Home page
?   ?   ??? CreateSqlServer.razor      # SQL Server wizard
?   ?   ??? CreateDatabase.razor       # Database wizard
?   ?   ??? SqlServers.razor           # Server list
?   ?   ??? SqlServerDetail.razor      # Server details
?   ?   ??? ResourceGroups.razor       # Resource group list
?   ?   ??? CreateResourceGroup.razor  # RG creation
?   ?   ??? AllResources.razor         # All resources view
?   ?   ??? Subscription.razor         # Cost tracking
?   ?   ??? IconShowcase.razor         # Icon gallery
?   ??? Shared/
?       ??? SvgIcon.razor              # Icon component
?       ??? ServiceCard.razor          # Service cards
?       ??? InfoTooltip.razor          # Educational tooltips
?       ??? IconType.cs                # Icon enumerations
??? Models/
?   ??? SqlServer.cs                   # Server model
?   ??? SqlDatabase.cs                 # Database model
?   ??? ResourceGroup.cs               # Resource group model
?   ??? Subscription.cs                # Subscription model
?   ??? Extensions/
?       ??? ResourceGroupValidator.cs  # Validation logic
??? Services/
?   ??? AzureResourceService.cs        # Business logic
??? wwwroot/
?   ??? azure-portal.css               # Portal styling
??? Program.cs                         # Application startup
??? App.razor                          # Root component
```

### Data Flow

1. **User Interaction**: Student clicks button or fills form
2. **Blazor Component**: Handles user input with data binding
3. **Service Layer**: `AzureResourceService` manages business logic
4. **In-Memory Storage**: Data stored in singleton service
5. **UI Update**: Blazor re-renders component automatically

### Key Design Decisions

**Why Blazor Server?**
- No JavaScript required
- Easier for students to understand
- Full .NET capabilities
- Rapid development

**Why In-Memory Storage?**
- No database setup needed
- Instant deployment
- Perfect for training environments
- Data resets on app restart (clean slate)

**Why Singleton Service?**
- Simple state management
- All students share same data (good for demos)
- Easy to understand for beginners

---

## ?? Teaching Tips for Instructors

### Effective Classroom Strategies

#### **Start with Demonstrations**
1. Project the application on a screen
2. Walk through creating a SQL Server together
3. Point out tooltips and explain each option
4. Have students follow along on their computers

#### **Encourage Exploration**
- Remind students nothing is real - they can't break anything
- Encourage "what if" questions
- Let students make mistakes and learn from them
- Create competitive challenges (who can create the cheapest viable solution?)

#### **Use Real-World Scenarios**
Present scenarios like:
- "Your startup needs a database but budget is $20/month"
- "You're building a banking app - what security features do you enable?"
- "Your app only runs during business hours - how do you save money?"

#### **Assess Understanding**
Quiz questions:
- What's the difference between Standard S1 and Premium P1?
- Why would you choose Serverless over Provisioned?
- What security features are free?
- How does GRS differ from LRS backup?

### Discussion Topics

**Cost Management**:
- How do cloud costs differ from on-premise?
- When does serverless make financial sense?
- What's the total cost of ownership?

**Security**:
- What's defense in depth?
- Why is TDE free but Defender costs money?
- How do firewall rules work?

**Architecture**:
- Why separate SQL Server from databases?
- What are resource groups for?
- How do regions affect applications?

**Best Practices**:
- Naming conventions
- Environment separation
- Tagging strategies
- Cost allocation

---

## ?? Additional Learning Resources

### Included Documentation

This project includes comprehensive guides:

- **EDUCATIONAL-TOOLTIPS-GUIDE.md**: Complete tooltip documentation
- **SVGICON-GUIDE.md**: Icon system documentation
- **SQL-SERVER-WIZARD-COMPLETE.md**: SQL Server creation guide
- **SUBSCRIPTION-PAGE-GUIDE.md**: Cost tracking feature
- **CREATE-RESOURCE-GROUP-GUIDE.md**: Resource group management
- **RESOURCEGROUP-VALIDATOR-GUIDE.md**: Validation rules
- **TOOLTIP-VISUAL-EXAMPLES.md**: Visual tooltip examples
- **WIZARD-TOOLTIPS-GUIDE.md**: Wizard-specific tooltips

### External Resources

**Microsoft Learn** (official Azure documentation):
- [Azure SQL Database Documentation](https://docs.microsoft.com/azure/sql-database/)
- [Azure Pricing Calculator](https://azure.microsoft.com/pricing/calculator/)
- [Azure Free Account](https://azure.microsoft.com/free/students/)

**Recommended After Mock Training**:
1. Create a real Azure Student account (free $100 credit)
2. Try the same exercises in real Azure
3. Compare the experience
4. Remember to delete resources when done!

---

## ?? Important Disclaimers

### ?? **THIS IS A TRAINING SIMULATION**

- ? **Safe for learning**: No connection to real Azure
- ? **Zero cost**: No charges ever
- ? **No credentials needed**: No Azure account required
- ? **Unlimited experiments**: Create/delete freely

- ? **Not for production**: Don't use for real applications
- ? **No data persistence**: Restarts clear all data
- ? **No real Azure API calls**: Everything is simulated
- ? **Simplified**: Some advanced features are omitted

### Data Privacy

- All data exists only in memory
- No data is sent to external services
- No personal information is collected
- No tracking or analytics
- Restart the app to completely clear all data

### Limitations

**This training environment simulates:**
- ? Azure Portal UI and navigation
- ? SQL Server and Database creation workflows
- ? Resource management concepts
- ? Pricing information (accurate as of 2025)
- ? Configuration options

**This does NOT simulate:**
- ? Actual database functionality (no SQL queries)
- ? Real network connections
- ? Actual billing or payments
- ? Azure API responses
- ? Multi-user collaboration features
- ? Data persistence across restarts

---

## ?? Customization & Extension

### For Instructors Who Want to Modify

#### **Add New Resources**
Want to add Virtual Machines or Storage Accounts?

1. Create a new model in `Models/` (e.g., `VirtualMachine.cs`)
2. Add methods to `AzureResourceService.cs`
3. Create a wizard page in `Components/Pages/`
4. Add navigation links in `AzurePortalLayout.razor`
5. Add an icon to `IconType.cs` and `SvgIcon.razor`

#### **Modify Pricing**
Update prices in tooltip descriptions:
- Edit `CreateSqlServer.razor` tooltips
- Edit `CreateDatabase.razor` tooltips
- Keep prices realistic to teach cost awareness

#### **Change Regions**
Edit `GetLocations()` in `AzureResourceService.cs` to match your region

#### **Add New Exercises**
Create new `.md` files with custom exercises for your course

#### **Customize Styling**
Modify `azure-portal.css` to change:
- Color scheme (change CSS variables)
- Fonts and sizing
- Card layouts
- Animation speeds

---

## ?? Troubleshooting

### Common Issues

**Q: Port 5001 is already in use**
- A: Edit `Properties/launchSettings.json` to change ports

**Q: Data disappeared after restart**
- A: This is expected - the app uses in-memory storage

**Q: Multiple students see each other's resources**
- A: This is expected with the singleton service (good for demos)
- A: For isolation, each student should run their own instance

**Q: Tooltips aren't showing**
- A: Ensure browser allows hover events
- A: Try hard refresh (Ctrl+F5)

**Q: Icons aren't displaying**
- A: Check that `azure-portal.css` is referenced in `App.razor`

**Q: Build errors in Visual Studio**
- A: Ensure .NET 9 SDK is installed
- A: Clean and rebuild solution

---

## ?? Support & Community

### For Instructors

- **Issues**: Report bugs or request features on GitHub
- **Questions**: Use GitHub Discussions
- **Contributions**: Pull requests welcome!

### For Students

- **Ask your instructor first** - they know the course context
- **Read the tooltips** - most answers are there
- **Check documentation** - comprehensive guides included
- **Experiment** - you can't break anything!

---

## ?? License

This project is provided as-is for educational purposes. 

**Usage Rights:**
- ? Free to use in educational institutions
- ? Free to modify for your courses
- ? Free to share with students
- ? Not for commercial use without permission
- ? Not to be sold or monetized

---

## ?? Acknowledgments

**Built for Education**:
- Designed specifically for classroom teaching
- Focused on safe, cost-free learning
- Emphasizes understanding over memorization

**Inspired By**:
- Microsoft Azure Portal
- Real-world Azure experiences
- Student feedback and learning needs

**Technologies**:
- Built with ASP.NET Core Blazor (.NET 9)
- No external dependencies
- Modern C# best practices

---

## ?? Contact

**Project Maintainer**: [Your Name/Institution]
**Course**: [Your Course Name]
**Institution**: [Your Institution]

**GitHub**: [https://github.com/NordinsProjekt/AzureMock](https://github.com/NordinsProjekt/AzureMock)

---

<div align="center">

### ?? Education • ?? Learning • ?? Cloud Computing

**Built with ?? for students learning Azure**

*No subscription required. No costs incurred. Just learning.*

---

**Perfect for**:
Database Administration • Cloud Computing • DevOps • Azure Certification Prep • IT Training Programs

---

? **Star this project** if you find it useful for teaching!

</div>
