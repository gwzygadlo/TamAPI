CREATE DATABASE [tam]
GO

USE [tam]
GO

CREATE TABLE [dbo].[Owner](
	[owner_id] [uniqueidentifier] NOT NULL PRIMARY KEY,
	[owner_name] [nvarchar](30) NOT NULL,
	[owner_age] int NOT NULL,
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Owner] ([owner_id], [owner_name], [owner_age])
	VALUES ('D9021EC7-52F2-41C9-9339-005890975B70', 'John', 25)
GO

INSERT INTO [dbo].[Owner] ([owner_id], [owner_name], [owner_age])
	VALUES ('99C5711E-C8C3-42F3-B1ED-378BB5A80339', 'Amanda', 52)
GO

INSERT INTO [dbo].[Owner] ([owner_id], [owner_name], [owner_age])
	VALUES ('9EF46335-7EC4-42E6-867F-6D6A02138600', 'Bobby', 39)
GO

INSERT INTO [dbo].[Owner] ([owner_id], [owner_name], [owner_age])
	VALUES ('5DCAFA4E-0CD4-4E4C-A29D-985A1D709F01', 'Tan', 37)
GO

CREATE TABLE [Health] 
(
	[health_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[health_name] nvarchar(10) NOT NULL,
	[health_scale] int NOT NULL,
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Health] ([health_id] ,[health_name], [health_scale])
	VALUES ('8EB4776C-D7B8-40F3-97AA-F8B9C054EE5F', 'Healthy', 4)
GO

INSERT INTO [dbo].[Health] ([health_id] ,[health_name], [health_scale])
	VALUES ('9AC74394-9FC6-4688-BF70-2E95A48D776A' , 'Good', 3)
GO

INSERT INTO [dbo].[Health] ([health_id] ,[health_name], [health_scale])
	VALUES ('391D7130-D3A3-4BDF-91B4-DB0521A12EA4' , 'Fair', 2)
GO

INSERT INTO [dbo].[Health] ([health_id] ,[health_name], [health_scale])
	VALUES ('F4DD2D60-76AF-4DB1-A012-6DC5B0F13329' , 'Okay', 1)
GO

INSERT INTO [dbo].[Health] ([health_id] ,[health_name], [health_scale])
	VALUES ('5B110EB0-012A-440C-8DEF-D960F349D97B' , 'Sick', 0)
GO

CREATE TABLE [Hunger] 
(
	[hunger_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[hunger_name] nvarchar(30) NOT NULL,
	[hunger_scale] int NOT NULL,
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Hunger] ([hunger_id] ,[hunger_name], [hunger_scale])
	VALUES ('A3BF8C5F-94A5-4DD9-9781-3828A90B29E1' ,'Famished', 0)
GO

INSERT INTO [dbo].[Hunger] ([hunger_id] ,[hunger_name], [hunger_scale])
	VALUES ('0F85508B-3669-4D85-8E75-950F6A2CC4DD' ,'Starving', 1)
GO

INSERT INTO [dbo].[Hunger] ([hunger_id] ,[hunger_name], [hunger_scale])
	VALUES ('550B506B-6E6B-40A4-BA0E-08D64F062B2F' ,'Hungry', 2)
GO

INSERT INTO [dbo].[Hunger] ([hunger_id] ,[hunger_name], [hunger_scale])
	VALUES ('67DA856C-8259-486A-8751-13F65FD940F6' ,'Peckish', 3)
GO

INSERT INTO [dbo].[Hunger] ([hunger_id] ,[hunger_name], [hunger_scale])
	VALUES ('D75B4C37-E223-4B96-AA4A-50037649E9BB' ,'Full', 4)
GO

CREATE TABLE [dbo].[Tama](
	[tama_id] [uniqueidentifier] NOT NULL PRIMARY KEY,
	[tama_name] [nvarchar](30) NOT NULL,
	[tama_age] int NOT NULL,
	[tama_sex] nvarchar(10) NOT NULL,
	[tama_type] nvarchar(30) NOT NULL,
	[owner_id] [uniqueidentifier] NOT NULL,
	[health_id] [uniqueidentifier] NOT NULL,
	[hunger_id] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tama]
ADD CONSTRAINT FK_tamaowner
FOREIGN KEY (owner_id) REFERENCES [Owner](owner_id)
GO

ALTER TABLE [dbo].[Tama]
ADD CONSTRAINT FK_tamahealth
FOREIGN KEY (health_id) REFERENCES Health(health_id)
GO

ALTER TABLE [dbo].[Tama]
ADD CONSTRAINT FK_tamahunger
FOREIGN KEY (hunger_id) REFERENCES Hunger(hunger_id)
GO

INSERT INTO [dbo].[Tama]
(
	[tama_id] --[uniqueidentifier] NOT NULL PRIMARY KEY,
	,[tama_name] --[nvarchar](30) NOT NULL,
	,[tama_age] --int NOT NULL,
	,[tama_sex] --nvarchar(10) NOT NULL,
	,[tama_type] --nvarchar(30) NOT NULL,
	,[owner_id] --[uniqueidentifier] NOT NULL,
	,[health_id] --[uniqueidentifier] NOT NULL,
	,[hunger_id] --[uniqueidentifier] NOT NULL
	)
	VALUES (
	'0BA79BF2-1A5E-4BD8-A35D-E21C43DB9198' 
	,'Tamaotchi 1'
	,0
	,'Female'
	,'Kuchipatchi'
	,'D9021EC7-52F2-41C9-9339-005890975B70'
	,'8EB4776C-D7B8-40F3-97AA-F8B9C054EE5F'
	,'D75B4C37-E223-4B96-AA4A-50037649E9BB')
GO

INSERT INTO [dbo].[Tama]
(
	[tama_id] --[uniqueidentifier] NOT NULL PRIMARY KEY,
	,[tama_name] --[nvarchar](30) NOT NULL,
	,[tama_age] --int NOT NULL,
	,[tama_sex] --nvarchar(10) NOT NULL,
	,[tama_type] --nvarchar(30) NOT NULL,
	,[owner_id] --[uniqueidentifier] NOT NULL,
	,[health_id] --[uniqueidentifier] NOT NULL,
	,[hunger_id] --[uniqueidentifier] NOT NULL
	)
	VALUES (
	'19779067-EDC1-479F-BAB4-4A80DA42F5DA' 
	,'Tamaotchi 2'
	,0
	,'Male'
	,'Mametchi'
	,'99C5711E-C8C3-42F3-B1ED-378BB5A80339'
	,'8EB4776C-D7B8-40F3-97AA-F8B9C054EE5F'
	,'D75B4C37-E223-4B96-AA4A-50037649E9BB')
GO

INSERT INTO [dbo].[Tama]
(
	[tama_id] --[uniqueidentifier] NOT NULL PRIMARY KEY,
	,[tama_name] --[nvarchar](30) NOT NULL,
	,[tama_age] --int NOT NULL,
	,[tama_sex] --nvarchar(10) NOT NULL,
	,[tama_type] --nvarchar(30) NOT NULL,
	,[owner_id] --[uniqueidentifier] NOT NULL,
	,[health_id] --[uniqueidentifier] NOT NULL,
	,[hunger_id] --[uniqueidentifier] NOT NULL
	)
	VALUES (
	'24E1FB36-5EC7-49F7-BF3E-412A22C474E8' 
	,'Tamaotchi 3'
	,0
	,'Female'
	,'Kuromametchi'
	,'9EF46335-7EC4-42E6-867F-6D6A02138600'
	,'8EB4776C-D7B8-40F3-97AA-F8B9C054EE5F'
	,'D75B4C37-E223-4B96-AA4A-50037649E9BB')
GO

INSERT INTO [dbo].[Tama]
(
	[tama_id] --[uniqueidentifier] NOT NULL PRIMARY KEY,
	,[tama_name] --[nvarchar](30) NOT NULL,
	,[tama_age] --int NOT NULL,
	,[tama_sex] --nvarchar(10) NOT NULL,
	,[tama_type] --nvarchar(30) NOT NULL,
	,[owner_id] --[uniqueidentifier] NOT NULL,
	,[health_id] --[uniqueidentifier] NOT NULL,
	,[hunger_id] --[uniqueidentifier] NOT NULL
	)
	VALUES (
	'C46BC941-C04F-4F5B-A09F-A2F1DDC76086' 
	,'Tamaotchi 4'
	,0
	,'Male'
	,'Gozarutchi'
	,'5DCAFA4E-0CD4-4E4C-A29D-985A1D709F01'
	,'8EB4776C-D7B8-40F3-97AA-F8B9C054EE5F'
	,'D75B4C37-E223-4B96-AA4A-50037649E9BB')
GO

CREATE TABLE [Food] 
(
	[food_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[food_name] nvarchar(30) NOT NULL,
	[owner_id] uniqueidentifier NOT NULL,
	[food_quantity] int NOT NULL,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Food]
ADD CONSTRAINT FK_foodowner
FOREIGN KEY (owner_id) REFERENCES [Owner](owner_id)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [owner_id], [food_quantity])
	VALUES ('F192476B-364D-490E-B4AD-18D7327B242F' ,'Bread', 'D9021EC7-52F2-41C9-9339-005890975B70', 10)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [owner_id], [food_quantity])
	VALUES ('CAE4D672-61E6-4864-BF4A-0DE975F935F3' ,'Apple', '99C5711E-C8C3-42F3-B1ED-378BB5A80339', 10)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [owner_id], [food_quantity])
	VALUES ('F4EE856E-05DF-4069-B448-F64160BE2614' ,'Rice', '9EF46335-7EC4-42E6-867F-6D6A02138600', 10)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [owner_id], [food_quantity])
	VALUES ('84208E58-BB1A-4227-8B6E-D24339BA9EAF' ,'Cereal', '5DCAFA4E-0CD4-4E4C-A29D-985A1D709F01', 10)
GO

CREATE TABLE [Snack] 
(
	[snack_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[snack_name] nvarchar(30) NOT NULL,
	[owner_id] uniqueidentifier NOT NULL,
	[snack_quantity] int NOT NULL,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Snack]
ADD CONSTRAINT FK_snackowner
FOREIGN KEY (owner_id) REFERENCES [Owner](owner_id)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [owner_id], [snack_quantity])
	VALUES ('983AD895-C042-4BBA-A1EF-5B32A808B046' ,'Candy', 'D9021EC7-52F2-41C9-9339-005890975B70', 10)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [owner_id], [snack_quantity])
	VALUES ('981CC666-0A3E-4FC1-BED2-9C4787749105' ,'Tea', '99C5711E-C8C3-42F3-B1ED-378BB5A80339', 10)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [owner_id], [snack_quantity])
	VALUES ('22C3B385-BFCC-4C0E-B592-1CDED7188D03' ,'Melon', '9EF46335-7EC4-42E6-867F-6D6A02138600', 10)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [owner_id], [snack_quantity])
	VALUES ('B5D11306-01CB-49E4-8C7C-DD4D6C2907B1' ,'Cotton Candy', '5DCAFA4E-0CD4-4E4C-A29D-985A1D709F01', 10)
GO

DROP TABLE [Food]
GO

DROP TABLE [Snack]
GO

CREATE TABLE [Food] 
(
	[food_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[food_name] nvarchar(30) NOT NULL,
	[cost] int NOT NULL,
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [cost])
	VALUES ('F192476B-364D-490E-B4AD-18D7327B242F' ,'Bread', 10)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [cost])
	VALUES ('CAE4D672-61E6-4864-BF4A-0DE975F935F3' ,'Apple', 10)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [cost])
	VALUES ('F4EE856E-05DF-4069-B448-F64160BE2614' ,'Rice', 10)
GO

INSERT INTO [dbo].[Food] ([food_id], [food_name], [cost])
	VALUES ('84208E58-BB1A-4227-8B6E-D24339BA9EAF' ,'Cereal', 10)
GO

CREATE TABLE [Snack] 
(
	[snack_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[snack_name] nvarchar(30) NOT NULL,
	[cost] int NOT NULL
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [cost])
	VALUES ('983AD895-C042-4BBA-A1EF-5B32A808B046' ,'Candy', 10)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [cost])
	VALUES ('981CC666-0A3E-4FC1-BED2-9C4787749105' ,'Tea', 10)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [cost])
	VALUES ('22C3B385-BFCC-4C0E-B592-1CDED7188D03' ,'Melon', 10)
GO

INSERT INTO [dbo].[Snack] ([snack_id], [snack_name], [cost])
	VALUES ('B5D11306-01CB-49E4-8C7C-DD4D6C2907B1' ,'Cotton Candy', 10)
GO

ALTER TABLE [Owner]
ADD [owner_points] int
GO

UPDATE [Owner]
SET [owner_points] = 0
WHERE [owner_points] is NULL
GO

CREATE TABLE [OwnerFood] 
(
	[ownerfood_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[food_id] uniqueidentifier NOT NULL,
	[owner_id] uniqueidentifier NOT NULL,
	[food_quantity] int NOT NULL,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OwnerFood]
ADD CONSTRAINT FK_foodowner
FOREIGN KEY (owner_id) REFERENCES [Owner](owner_id)
GO

ALTER TABLE [dbo].[OwnerFood]
ADD CONSTRAINT FK_ownerfood
FOREIGN KEY (food_id) REFERENCES [Food](food_id)
GO

INSERT INTO [dbo].[OwnerFood] ([ownerfood_id], [food_id], [owner_id], [food_quantity])
	VALUES ('A4F72A58-4958-4A07-9CF5-9483D1BE4A77', 'F192476B-364D-490E-B4AD-18D7327B242F', 'D9021EC7-52F2-41C9-9339-005890975B70', 10)
GO

INSERT INTO [dbo].[OwnerFood] ([ownerfood_id], [food_id], [owner_id], [food_quantity])
	VALUES ('142AB4B2-1690-4731-89FC-163DE681AEAC', 'CAE4D672-61E6-4864-BF4A-0DE975F935F3' , '99C5711E-C8C3-42F3-B1ED-378BB5A80339', 10)
GO

INSERT INTO [dbo].[OwnerFood] ([ownerfood_id], [food_id], [owner_id], [food_quantity])
	VALUES ('8D0250CF-C651-40D3-B499-B689041CE2FB', 'F4EE856E-05DF-4069-B448-F64160BE2614' , '9EF46335-7EC4-42E6-867F-6D6A02138600', 10)
GO

INSERT INTO [dbo].[OwnerFood] ([ownerfood_id], [food_id], [owner_id], [food_quantity])
	VALUES ('51179AD4-EA9E-481D-8CB2-809DC311021A', '84208E58-BB1A-4227-8B6E-D24339BA9EAF' , '5DCAFA4E-0CD4-4E4C-A29D-985A1D709F01', 10)
GO

CREATE TABLE [OwnerSnack] 
(
	[ownersnack_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[snack_id] uniqueidentifier NOT NULL,
	[owner_id] uniqueidentifier NOT NULL,
	[snack_quantity] int NOT NULL,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OwnerSnack]
ADD CONSTRAINT FK_snackowner
FOREIGN KEY (owner_id) REFERENCES [Owner](owner_id)
GO

ALTER TABLE [dbo].[OwnerSnack]
ADD CONSTRAINT FK_ownersnack
FOREIGN KEY (snack_id) REFERENCES [Snack](snack_id)
GO

INSERT INTO [dbo].[OwnerSnack] ([ownersnack_id], [snack_id], [owner_id], [snack_quantity])
	VALUES ('9770CF96-E962-400E-A208-8970A0336B04', '983AD895-C042-4BBA-A1EF-5B32A808B046' ,'D9021EC7-52F2-41C9-9339-005890975B70', 10)
GO

INSERT INTO [dbo].[OwnerSnack] ([ownersnack_id], [snack_id], [owner_id], [snack_quantity])
	VALUES ('7BA3D93F-E3A0-478A-A9D7-9BD16D8E1DAF', '981CC666-0A3E-4FC1-BED2-9C4787749105' , '99C5711E-C8C3-42F3-B1ED-378BB5A80339', 10)
GO

INSERT INTO [dbo].[OwnerSnack] ([ownersnack_id], [snack_id], [owner_id], [snack_quantity])
	VALUES ('75ECFDE7-F20F-46F7-914F-D71F16BD7997', '22C3B385-BFCC-4C0E-B592-1CDED7188D03' ,'9EF46335-7EC4-42E6-867F-6D6A02138600', 10)
GO

INSERT INTO [dbo].[OwnerSnack] ([ownersnack_id], [snack_id], [owner_id], [snack_quantity])
	VALUES ('7697563A-CE2F-43A1-86FA-DB0C896637C0', 'B5D11306-01CB-49E4-8C7C-DD4D6C2907B1' , '5DCAFA4E-0CD4-4E4C-A29D-985A1D709F01', 10)
GO

CREATE TABLE [Happiness] 
(
	[happiness_id] uniqueidentifier NOT NULL PRIMARY KEY,
	[happiness_name] nvarchar(30) NOT NULL,
	[happiness_scale] int NOT NULL,
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Happiness] ([happiness_id] ,[happiness_name], [happiness_scale])
	VALUES ('034EE82A-4B66-48E0-8629-1CBBE7599AEC' ,'Very Unhappy', 0)
GO

INSERT INTO [dbo].[Happiness] ([happiness_id] ,[happiness_name], [happiness_scale])
	VALUES ('87DF2756-F8CF-4153-B825-9A2485220A93' ,'Unhappy', 1)
GO

INSERT INTO [dbo].[Happiness] ([happiness_id] ,[happiness_name], [happiness_scale])
	VALUES ('7068E4FC-DE6A-4645-9354-B29FD80EAC6F' ,'Neutral', 2)
GO

INSERT INTO [dbo].[Happiness] ([happiness_id] ,[happiness_name], [happiness_scale])
	VALUES ('A8B57350-7D6A-473D-AECE-D2E8FEA89056' ,'Happy', 3)
GO

INSERT INTO [dbo].[Happiness] ([happiness_id] ,[happiness_name], [happiness_scale])
	VALUES ('4E8C3165-23AE-4614-8180-183E27EFAC14' ,'Very Happy', 4)
GO

ALTER TABLE [Tama]
ADD [happiness_id] uniqueidentifier
GO

ALTER TABLE [dbo].[Tama]
ADD CONSTRAINT FK_tamahappiness
FOREIGN KEY (happiness_id) REFERENCES [Happiness](happiness_id)
GO

UPDATE [Tama]
SET [happiness_id] = '4E8C3165-23AE-4614-8180-183E27EFAC14'
WHERE [happiness_id] is NULL

ALTER TABLE [Tama]
ALTER COLUMN [happiness_id] uniqueidentifier not null
GO

ALTER TABLE [Owner]
ALTER COLUMN [owner_points] int not null
GO

sp_rename 'Tama.tama_sex', 'tama_gender', 'COLUMN';
GO