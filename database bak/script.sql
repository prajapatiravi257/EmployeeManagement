USE [master]
GO
/****** Object:  Database [EmployeeManagement]    Script Date: 4/28/2017 2:01:57 PM ******/
CREATE DATABASE [EmployeeManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSERVER\MSSQL\DATA\EmployeeManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSERVER\MSSQL\DATA\EmployeeManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EmployeeManagement] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [EmployeeManagement] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeeManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EmployeeManagement', N'ON'
GO
ALTER DATABASE [EmployeeManagement] SET QUERY_STORE = OFF
GO
USE [EmployeeManagement]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [EmployeeManagement]
GO
/****** Object:  Table [dbo].[Contact_person_info]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact_person_info](
	[emp_id] [int] NOT NULL,
	[c_firstname] [varchar](15) NOT NULL,
	[c_lastname] [varchar](15) NOT NULL,
	[c_email] [varchar](30) NOT NULL,
	[c_mob] [varchar](10) NOT NULL,
	[c_city] [varchar](20) NOT NULL,
	[c_address] [varchar](50) NOT NULL,
	[c_zipcode] [int] NOT NULL,
 CONSTRAINT [PK_Contact_person_info] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Emp_basic_details]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_basic_details](
	[emp_id] [int] IDENTITY(1,100) NOT NULL,
	[firstname] [varchar](15) NOT NULL,
	[lastname] [varchar](15) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[dob] [varchar](10) NOT NULL,
	[mob] [varchar](10) NOT NULL,
	[city] [varchar](20) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[zipcode] [int] NOT NULL,
	[qualification] [varchar](50) NOT NULL,
	[curr_exp] [int] NOT NULL,
	[start_date] [varchar](10) NOT NULL,
	[end_date] [varchar](10) NULL,
	[gender] [varchar](10) NOT NULL,
	[marital_status] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Emp_basic_details] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Emp_leaves]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_leaves](
	[emp_id] [int] NOT NULL,
	[emp_name] [varchar](15) NOT NULL,
	[leave_date] [varchar](50) NOT NULL,
	[numOfDays] [int] NOT NULL,
	[leave_reason] [varchar](max) NOT NULL,
	[paid_leave] [int] NULL,
	[total_leave] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Events]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event_name] [varchar](20) NOT NULL,
	[event_date] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Holiday_info]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holiday_info](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[holiday_name] [varchar](20) NOT NULL,
	[holiday_date] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Holiday_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login_users]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_users](
	[emp_id] [int] NOT NULL,
	[usertype] [varchar](5) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[passwd] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Login_users1] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salary_information]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary_information](
	[emp_id] [int] NOT NULL,
	[firstname] [varchar](20) NOT NULL,
	[lastname] [varchar](20) NOT NULL,
	[monthly_sal] [int] NOT NULL,
	[monthly_taxes] [int] NOT NULL,
	[monthly_allowance] [int] NOT NULL,
	[monthly_insurances] [int] NOT NULL,
 CONSTRAINT [PK_Salary_information] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Timing_details]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timing_details](
	[emp_id] [int] NOT NULL,
	[worked_hours] [int] NOT NULL,
	[off_hours] [int] NULL,
	[over_time] [int] NULL,
	[extra_days] [int] NULL,
	[work_state_date] [date] NOT NULL,
	[work_end_date] [date] NULL,
 CONSTRAINT [PK_Timing_details] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Work_history]    Script Date: 4/28/2017 2:01:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Work_history](
	[emp_id] [int] NOT NULL,
	[comp_name] [varchar](15) NOT NULL,
	[emp_name] [varchar](15) NOT NULL,
	[p_start_date] [varchar](10) NOT NULL,
	[p_end_date] [varchar](10) NOT NULL,
	[post] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Work_history] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Emp_leaves] ADD  CONSTRAINT [DF_Emp_leaves_total_leave]  DEFAULT ((25)) FOR [total_leave]
GO
ALTER TABLE [dbo].[Contact_person_info]  WITH CHECK ADD  CONSTRAINT [FK_Contact_person_info_Emp_basic_details] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Emp_basic_details] ([emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contact_person_info] CHECK CONSTRAINT [FK_Contact_person_info_Emp_basic_details]
GO
ALTER TABLE [dbo].[Emp_leaves]  WITH CHECK ADD  CONSTRAINT [FK_Emp_leaves_Emp_basic_details] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Emp_basic_details] ([emp_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Emp_leaves] CHECK CONSTRAINT [FK_Emp_leaves_Emp_basic_details]
GO
ALTER TABLE [dbo].[Login_users]  WITH CHECK ADD  CONSTRAINT [FK_Login_users_Emp_basic_details] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Emp_basic_details] ([emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Login_users] CHECK CONSTRAINT [FK_Login_users_Emp_basic_details]
GO
ALTER TABLE [dbo].[Salary_information]  WITH CHECK ADD  CONSTRAINT [FK_Salary_information_Emp_basic_details] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Emp_basic_details] ([emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Salary_information] CHECK CONSTRAINT [FK_Salary_information_Emp_basic_details]
GO
ALTER TABLE [dbo].[Timing_details]  WITH CHECK ADD  CONSTRAINT [FK_Timing_details_Emp_basic_details] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Emp_basic_details] ([emp_id])
GO
ALTER TABLE [dbo].[Timing_details] CHECK CONSTRAINT [FK_Timing_details_Emp_basic_details]
GO
ALTER TABLE [dbo].[Work_history]  WITH CHECK ADD  CONSTRAINT [FK_Work_history_Emp_basic_details] FOREIGN KEY([emp_id])
REFERENCES [dbo].[Emp_basic_details] ([emp_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Work_history] CHECK CONSTRAINT [FK_Work_history_Emp_basic_details]
GO
USE [master]
GO
ALTER DATABASE [EmployeeManagement] SET  READ_WRITE 
GO
