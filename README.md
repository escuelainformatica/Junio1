# Junio1

```sql

CREATE TABLE [dbo].[Usuarios](
	[NombreUsuario] [varchar](50) NOT NULL,
	[Clave] [varchar](70) NULL,
	[Correo] [varchar](50) NULL,
	[NombreCompleto] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

```