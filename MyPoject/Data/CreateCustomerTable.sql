SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CUSTOMER](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedOn] [datetimeoffset](7) NOT NULL,
	[ModifiedOn] [datetimeoffset](7) NULL,
	[Deleted] [bit] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE[dbo].[CUSTOMER] ADD CONSTRAINT [DF_CUSTOMER_Id] DEFAULT (newsequentialid()) FOR [Id]
GO

ALTER TABLE[dbo].[CUSTOMER] ADD CONSTRAINT [DF_CUSTOMER_CreatedOn] DEFAULT (sysdatetimeoffset()) FOR [CreatedOn]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Descriptions', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CUSTOMER', @level2type=N'COLUMN',@level2name=N'CreatedOn'
GO