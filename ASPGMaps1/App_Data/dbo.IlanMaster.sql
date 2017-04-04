CREATE TABLE [dbo].[IlanMaster]
(
	[IlanId] INT NOT NULL PRIMARY KEY, 
    [IlanArea] NVARCHAR(50) NOT NULL, 
    [IlanName] NVARCHAR(50) NOT NULL, 
    [LocLat] NVARCHAR(50) NOT NULL, 
    [LocLong] NVARCHAR(50) NOT NULL, 
    [ReadMoreUrl] NVARCHAR(50) NOT NULL
)
