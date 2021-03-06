USE [kitapdf]
GO
/****** Object:  Table [dbo].[kitap]    Script Date: 8.12.2018 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitap](
	[kitap_no] [int] IDENTITY(1,1) NOT NULL,
	[kitap_adi] [varchar](50) NULL,
	[kitap_yazari] [varchar](50) NULL,
	[kitap_sayfasi] [int] NULL,
	[kitap_basimyili] [varchar](50) NULL,
	[kitap_pdfadres] [varchar](150) NULL,
 CONSTRAINT [PK_kitap] PRIMARY KEY CLUSTERED 
(
	[kitap_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_kitapDuzenle]    Script Date: 8.12.2018 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_kitapDuzenle] 

@kitap_no int,
@kitap_adi varchar(50),
@kitap_yazari varchar(50),
@kitap_sayfasi int,
@kitap_basimyili varchar(50),
@kitap_pdfadres varchar(150)

AS
UPDATE kitap 
SET 
kitap_adi = @kitap_adi,
kitap_yazari = @kitap_yazari,
kitap_sayfasi = @kitap_sayfasi,
kitap_basimyili = @kitap_basimyili,
kitap_pdfadres = @kitap_pdfadres

WHERE 
kitap_no = @kitap_no
GO
/****** Object:  StoredProcedure [dbo].[sp_kitapEkle]    Script Date: 8.12.2018 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kitapEkle]
@kitap_adi varchar(50),
@kitap_yazari varchar(50),
@kitap_sayfasi int,
@kitap_basimyili varchar(50),
@kitap_pdfadres varchar(150)
AS

INSERT INTO kitap
(kitap_adi , kitap_yazari , kitap_sayfasi , kitap_basimyili , kitap_pdfadres )

VALUES
(@kitap_adi ,@kitap_yazari,@kitap_sayfasi ,@kitap_basimyili ,@kitap_pdfadres )


GO
/****** Object:  StoredProcedure [dbo].[sp_kitapListele]    Script Date: 8.12.2018 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kitapListele]
AS
SELECT * FROM kitap

GO
/****** Object:  StoredProcedure [dbo].[sp_kitapSil]    Script Date: 8.12.2018 18:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kitapSil]
@kitap_no int
AS
DELETE FROM kitap WHERE kitap_no = @kitap_no ;

GO
