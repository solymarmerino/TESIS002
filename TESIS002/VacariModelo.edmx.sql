
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/11/2018 23:07:52
-- Generated from EDMX file: C:\Users\SOLYMAR\source\repos\TESIS002\TESIS002\VacariModelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDVacari];
GO
IF SCHEMA_ID(N'dbo.gestionvacari') IS NULL EXECUTE(N'CREATE SCHEMA [dbo.gestionvacari]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PacienteContactoEmergencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente] DROP CONSTRAINT [FK_PacienteContactoEmergencia];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PacienteDiagnostico]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DiagnosticoSet] DROP CONSTRAINT [FK_PacienteDiagnostico];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_DiagnosticoEnfermedad]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DiagnosticoSet] DROP CONSTRAINT [FK_DiagnosticoEnfermedad];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PacienteSignosVitales]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[SignosVitalesSet] DROP CONSTRAINT [FK_PacienteSignosVitales];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PacienteCitaMedica]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[CitaMedicaSet] DROP CONSTRAINT [FK_PacienteCitaMedica];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_CitaMedicaTipoCitaMedica]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[CitaMedicaSet] DROP CONSTRAINT [FK_CitaMedicaTipoCitaMedica];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PacienteProcedimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[ProcedimientoSet] DROP CONSTRAINT [FK_PacienteProcedimiento];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_FacturaDetalleFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet] DROP CONSTRAINT [FK_FacturaDetalleFactura];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_DetalleFacturaProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet] DROP CONSTRAINT [FK_DetalleFacturaProducto];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PedidoExamenMedicoPaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente] DROP CONSTRAINT [FK_PedidoExamenMedicoPaciente];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_PedidoExamenMedicoDetallePedidoMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet] DROP CONSTRAINT [FK_PedidoExamenMedicoDetallePedidoMedico];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_DetallePedidoMedicoExamenMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet] DROP CONSTRAINT [FK_DetallePedidoMedicoExamenMedico];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_ClienteFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[FacturaSet] DROP CONSTRAINT [FK_ClienteFactura];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_EmpleadoCitaMedica]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PersonaSet_Empleado] DROP CONSTRAINT [FK_EmpleadoCitaMedica];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_TipoCitaMedicaDetalleFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet] DROP CONSTRAINT [FK_TipoCitaMedicaDetalleFactura];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_ProcedimientoTipoProcedimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[ProcedimientoSet] DROP CONSTRAINT [FK_ProcedimientoTipoProcedimiento];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_TipoProcedimientoDetalleFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet] DROP CONSTRAINT [FK_TipoProcedimientoDetalleFactura];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_EmpleadoPagoEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PagoEmpleadoSet] DROP CONSTRAINT [FK_EmpleadoPagoEmpleado];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_ExamenMedicoDetalleFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet] DROP CONSTRAINT [FK_ExamenMedicoDetalleFactura];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_Paciente_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente] DROP CONSTRAINT [FK_Paciente_inherits_Persona];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_Cliente_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PersonaSet_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Persona];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FK_Empleado_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo.gestionvacari].[PersonaSet_Empleado] DROP CONSTRAINT [FK_Empleado_inherits_Persona];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo.gestionvacari].[ContactoEmergenciaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[ContactoEmergenciaSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[DiagnosticoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[DiagnosticoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[EnfermedadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[EnfermedadSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[SignosVitalesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[SignosVitalesSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[CitaMedicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[CitaMedicaSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[TipoCitaMedicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[TipoCitaMedicaSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[ProcedimientoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[ProcedimientoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[FacturaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[FacturaSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[DetalleFacturaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[DetalleFacturaSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[ProductoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[ProductoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[PedidoExamenMedicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[PedidoExamenMedicoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[DetallePedidoMedicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[ExamenMedicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[ExamenMedicoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[PersonaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[PersonaSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[IngresoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[IngresoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[EgresoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[EgresoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[PagoEmpleadoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[PagoEmpleadoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[TipoProcedimientoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[TipoProcedimientoSet];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[PersonaSet_Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[PersonaSet_Paciente];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[PersonaSet_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[PersonaSet_Cliente];
GO
IF OBJECT_ID(N'[dbo.gestionvacari].[PersonaSet_Empleado]', 'U') IS NOT NULL
    DROP TABLE [dbo.gestionvacari].[PersonaSet_Empleado];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ContactoEmergenciaSet'
CREATE TABLE [dbo.gestionvacari].[ContactoEmergenciaSet] (
    [IdContactoEmergencia] int IDENTITY(1,1) NOT NULL,
    [NombreContactoEmergencia] nvarchar(max)  NOT NULL,
    [AfinidadContactoEmergencia] nvarchar(max)  NOT NULL,
    [TelefonoContactoEmergencia] int  NOT NULL
);
GO

-- Creating table 'DiagnosticoSet'
CREATE TABLE [dbo.gestionvacari].[DiagnosticoSet] (
    [IdDiagnostico] int IDENTITY(1,1) NOT NULL,
    [FechaDiagnostico] datetime  NOT NULL,
    [SubjetivoDiagnostico] nvarchar(max)  NOT NULL,
    [ObjetivoDiagnostico] nvarchar(max)  NOT NULL,
    [AnalisisDiagnostico] nvarchar(max)  NOT NULL,
    [PlanDiagnostico] nvarchar(max)  NOT NULL,
    [DiasReposoDiagnostico] int  NOT NULL,
    [Paciente_IdPersona] int  NOT NULL,
    [Enfermedad_IdEnfermedad] int  NOT NULL
);
GO

-- Creating table 'EnfermedadSet'
CREATE TABLE [dbo.gestionvacari].[EnfermedadSet] (
    [IdEnfermedad] int IDENTITY(1,1) NOT NULL,
    [NombreEnfermedad] nvarchar(max)  NOT NULL,
    [CIE10Enfermedad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SignosVitalesSet'
CREATE TABLE [dbo.gestionvacari].[SignosVitalesSet] (
    [IdSignosVitales] int IDENTITY(1,1) NOT NULL,
    [FechaSignosVitales] datetime  NOT NULL,
    [Temperatura] int  NOT NULL,
    [Peso] decimal(18,0)  NOT NULL,
    [PresionArterial] nvarchar(max)  NOT NULL,
    [FrecuenciaCardiaca] int  NOT NULL,
    [FrecuenciaRespiratoria] int  NOT NULL,
    [Talla] decimal(18,0)  NOT NULL,
    [Paciente_IdPersona] int  NOT NULL
);
GO

-- Creating table 'CitaMedicaSet'
CREATE TABLE [dbo.gestionvacari].[CitaMedicaSet] (
    [IdCitaMedica] int IDENTITY(1,1) NOT NULL,
    [FechaCitaMedica] datetime  NOT NULL,
    [EstadoEnfermeriCItaMedica] bit  NOT NULL,
    [EstadoAtencionEnfermeria] bit  NOT NULL,
    [EstadoPagadoCitaMedica] bit  NOT NULL,
    [Paciente_IdPersona] int  NOT NULL,
    [TipoCitaMedica_IdTipoCitaMedica] int  NOT NULL
);
GO

-- Creating table 'TipoCitaMedicaSet'
CREATE TABLE [dbo.gestionvacari].[TipoCitaMedicaSet] (
    [IdTipoCitaMedica] int IDENTITY(1,1) NOT NULL,
    [NombreTipoCitaMedica] nvarchar(max)  NOT NULL,
    [ValorTipoCita] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'ProcedimientoSet'
CREATE TABLE [dbo.gestionvacari].[ProcedimientoSet] (
    [IdProcedimiento] int IDENTITY(1,1) NOT NULL,
    [FechaProcedimiento] datetime  NOT NULL,
    [Paciente_IdPersona] int  NOT NULL,
    [TipoProcedimiento_IdTipoProcedimeinto] int  NOT NULL
);
GO

-- Creating table 'FacturaSet'
CREATE TABLE [dbo.gestionvacari].[FacturaSet] (
    [IdFactura] int IDENTITY(1,1) NOT NULL,
    [NumeroFactura] int  NOT NULL,
    [FechaFactura] datetime  NOT NULL,
    [Cliente_IdPersona] int  NOT NULL
);
GO

-- Creating table 'DetalleFacturaSet'
CREATE TABLE [dbo.gestionvacari].[DetalleFacturaSet] (
    [IdDetalleFactura] int IDENTITY(1,1) NOT NULL,
    [Cantidad] int  NOT NULL,
    [Precio] float  NOT NULL,
    [Factura_IdFactura] int  NOT NULL,
    [Producto_IdProducto] int  NOT NULL,
    [TipoCitaMedica_IdTipoCitaMedica] int  NOT NULL,
    [TipoProcedimiento_IdTipoProcedimeinto] int  NOT NULL,
    [ExamenMedico_IdExamenMedico] int  NOT NULL
);
GO

-- Creating table 'ProductoSet'
CREATE TABLE [dbo.gestionvacari].[ProductoSet] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [NombreProducto] nvarchar(max)  NOT NULL,
    [TipoProducto] nvarchar(max)  NOT NULL,
    [CantdadProducto] int  NOT NULL,
    [LoteProducto4] nvarchar(max)  NOT NULL,
    [FechaVencimientoProducto] datetime  NOT NULL,
    [PrecioProducto] decimal(18,0)  NOT NULL,
    [PresentacionProducto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PedidoExamenMedicoSet'
CREATE TABLE [dbo.gestionvacari].[PedidoExamenMedicoSet] (
    [IdPedidoExamenMedico] int IDENTITY(1,1) NOT NULL,
    [NumeroPedidoExamenMedico] int  NOT NULL,
    [FechaPedidoExamenMedico] datetime  NOT NULL
);
GO

-- Creating table 'DetallePedidoMedicoSet'
CREATE TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet] (
    [IdDetallePedidoMedico] int IDENTITY(1,1) NOT NULL,
    [PagadoDetallePedidoMedico] bit  NOT NULL,
    [RealizadoDetalleMedico] bit  NOT NULL,
    [ResultadosDetalleMedico] nvarchar(max)  NOT NULL,
    [PedidoExamenMedico_IdPedidoExamenMedico] int  NOT NULL,
    [ExamenMedico_IdExamenMedico] int  NOT NULL
);
GO

-- Creating table 'ExamenMedicoSet'
CREATE TABLE [dbo.gestionvacari].[ExamenMedicoSet] (
    [IdExamenMedico] int IDENTITY(1,1) NOT NULL,
    [NombreExamenMedico] nvarchar(max)  NOT NULL,
    [TipoExamenMedico] nvarchar(max)  NOT NULL,
    [PrecioExamenMedico] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'PersonaSet'
CREATE TABLE [dbo.gestionvacari].[PersonaSet] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [NombrePersona] nvarchar(max)  NOT NULL,
    [CedulaPersona] int  NOT NULL,
    [TelefonoPersona] int  NOT NULL,
    [DireccionPersona] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'IngresoSet'
CREATE TABLE [dbo.gestionvacari].[IngresoSet] (
    [IdIngreso] int IDENTITY(1,1) NOT NULL,
    [ProveedorIngreso] nvarchar(max)  NOT NULL,
    [DetalleIngreso] nvarchar(max)  NOT NULL,
    [ValorIngreso] float  NOT NULL,
    [FechaIngreso] datetime  NOT NULL
);
GO

-- Creating table 'EgresoSet'
CREATE TABLE [dbo.gestionvacari].[EgresoSet] (
    [IdEgreso] int IDENTITY(1,1) NOT NULL,
    [ProveedorEgreso] nvarchar(max)  NOT NULL,
    [DetalleEgreso] nvarchar(max)  NOT NULL,
    [ValorEgreso] float  NOT NULL,
    [FechaEgreso] datetime  NOT NULL
);
GO

-- Creating table 'PagoEmpleadoSet'
CREATE TABLE [dbo.gestionvacari].[PagoEmpleadoSet] (
    [IdPagoEmpleado] int IDENTITY(1,1) NOT NULL,
    [NombrePagoEmpleado] nvarchar(max)  NOT NULL,
    [ValorPagoEmpleado] float  NOT NULL,
    [Empleado_IdPersona] int  NOT NULL
);
GO

-- Creating table 'TipoProcedimientoSet'
CREATE TABLE [dbo.gestionvacari].[TipoProcedimientoSet] (
    [IdTipoProcedimeinto] int IDENTITY(1,1) NOT NULL,
    [NombreTipoProcedimiento] nvarchar(max)  NOT NULL,
    [ValorTipoProcedimiento] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'PersonaSet_Paciente'
CREATE TABLE [dbo.gestionvacari].[PersonaSet_Paciente] (
    [IdPaciente] int IDENTITY(1,1) NOT NULL,
    [FechaNacimientoPaciente] datetime  NULL,
    [EstadoCivilPaciente] nvarchar(max)  NULL,
    [GeneroPaciente] nvarchar(max)  NULL,
    [TipoSangrePaciente] nvarchar(max)  NULL,
    [AlergiasPaciente] nvarchar(max)  NULL,
    [HistoriaClinicaPaciente] int  NOT NULL,
    [IdPersona] int  NOT NULL,
    [ContactoEmergencia_IdContactoEmergencia] int  NOT NULL,
    [PedidoExamenMedico_IdPedidoExamenMedico] int  NOT NULL
);
GO

-- Creating table 'PersonaSet_Cliente'
CREATE TABLE [dbo.gestionvacari].[PersonaSet_Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [EmailCliente] nvarchar(max)  NOT NULL,
    [IdPersona] int  NOT NULL
);
GO

-- Creating table 'PersonaSet_Empleado'
CREATE TABLE [dbo.gestionvacari].[PersonaSet_Empleado] (
    [IdEmpleado] int IDENTITY(1,1) NOT NULL,
    [CargoEmpleado] nvarchar(max)  NOT NULL,
    [UsuarioEmpleado] nvarchar(max)  NOT NULL,
    [ContrasenaEmpleado] nvarchar(max)  NOT NULL,
    [IdPersona] int  NOT NULL,
    [CitaMedica_IdCitaMedica] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdContactoEmergencia] in table 'ContactoEmergenciaSet'
ALTER TABLE [dbo.gestionvacari].[ContactoEmergenciaSet]
ADD CONSTRAINT [PK_ContactoEmergenciaSet]
    PRIMARY KEY CLUSTERED ([IdContactoEmergencia] ASC);
GO

-- Creating primary key on [IdDiagnostico] in table 'DiagnosticoSet'
ALTER TABLE [dbo.gestionvacari].[DiagnosticoSet]
ADD CONSTRAINT [PK_DiagnosticoSet]
    PRIMARY KEY CLUSTERED ([IdDiagnostico] ASC);
GO

-- Creating primary key on [IdEnfermedad] in table 'EnfermedadSet'
ALTER TABLE [dbo.gestionvacari].[EnfermedadSet]
ADD CONSTRAINT [PK_EnfermedadSet]
    PRIMARY KEY CLUSTERED ([IdEnfermedad] ASC);
GO

-- Creating primary key on [IdSignosVitales] in table 'SignosVitalesSet'
ALTER TABLE [dbo.gestionvacari].[SignosVitalesSet]
ADD CONSTRAINT [PK_SignosVitalesSet]
    PRIMARY KEY CLUSTERED ([IdSignosVitales] ASC);
GO

-- Creating primary key on [IdCitaMedica] in table 'CitaMedicaSet'
ALTER TABLE [dbo.gestionvacari].[CitaMedicaSet]
ADD CONSTRAINT [PK_CitaMedicaSet]
    PRIMARY KEY CLUSTERED ([IdCitaMedica] ASC);
GO

-- Creating primary key on [IdTipoCitaMedica] in table 'TipoCitaMedicaSet'
ALTER TABLE [dbo.gestionvacari].[TipoCitaMedicaSet]
ADD CONSTRAINT [PK_TipoCitaMedicaSet]
    PRIMARY KEY CLUSTERED ([IdTipoCitaMedica] ASC);
GO

-- Creating primary key on [IdProcedimiento] in table 'ProcedimientoSet'
ALTER TABLE [dbo.gestionvacari].[ProcedimientoSet]
ADD CONSTRAINT [PK_ProcedimientoSet]
    PRIMARY KEY CLUSTERED ([IdProcedimiento] ASC);
GO

-- Creating primary key on [IdFactura] in table 'FacturaSet'
ALTER TABLE [dbo.gestionvacari].[FacturaSet]
ADD CONSTRAINT [PK_FacturaSet]
    PRIMARY KEY CLUSTERED ([IdFactura] ASC);
GO

-- Creating primary key on [IdDetalleFactura] in table 'DetalleFacturaSet'
ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet]
ADD CONSTRAINT [PK_DetalleFacturaSet]
    PRIMARY KEY CLUSTERED ([IdDetalleFactura] ASC);
GO

-- Creating primary key on [IdProducto] in table 'ProductoSet'
ALTER TABLE [dbo.gestionvacari].[ProductoSet]
ADD CONSTRAINT [PK_ProductoSet]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdPedidoExamenMedico] in table 'PedidoExamenMedicoSet'
ALTER TABLE [dbo.gestionvacari].[PedidoExamenMedicoSet]
ADD CONSTRAINT [PK_PedidoExamenMedicoSet]
    PRIMARY KEY CLUSTERED ([IdPedidoExamenMedico] ASC);
GO

-- Creating primary key on [IdDetallePedidoMedico] in table 'DetallePedidoMedicoSet'
ALTER TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet]
ADD CONSTRAINT [PK_DetallePedidoMedicoSet]
    PRIMARY KEY CLUSTERED ([IdDetallePedidoMedico] ASC);
GO

-- Creating primary key on [IdExamenMedico] in table 'ExamenMedicoSet'
ALTER TABLE [dbo.gestionvacari].[ExamenMedicoSet]
ADD CONSTRAINT [PK_ExamenMedicoSet]
    PRIMARY KEY CLUSTERED ([IdExamenMedico] ASC);
GO

-- Creating primary key on [IdPersona] in table 'PersonaSet'
ALTER TABLE [dbo.gestionvacari].[PersonaSet]
ADD CONSTRAINT [PK_PersonaSet]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IdIngreso] in table 'IngresoSet'
ALTER TABLE [dbo.gestionvacari].[IngresoSet]
ADD CONSTRAINT [PK_IngresoSet]
    PRIMARY KEY CLUSTERED ([IdIngreso] ASC);
GO

-- Creating primary key on [IdEgreso] in table 'EgresoSet'
ALTER TABLE [dbo.gestionvacari].[EgresoSet]
ADD CONSTRAINT [PK_EgresoSet]
    PRIMARY KEY CLUSTERED ([IdEgreso] ASC);
GO

-- Creating primary key on [IdPagoEmpleado] in table 'PagoEmpleadoSet'
ALTER TABLE [dbo.gestionvacari].[PagoEmpleadoSet]
ADD CONSTRAINT [PK_PagoEmpleadoSet]
    PRIMARY KEY CLUSTERED ([IdPagoEmpleado] ASC);
GO

-- Creating primary key on [IdTipoProcedimeinto] in table 'TipoProcedimientoSet'
ALTER TABLE [dbo.gestionvacari].[TipoProcedimientoSet]
ADD CONSTRAINT [PK_TipoProcedimientoSet]
    PRIMARY KEY CLUSTERED ([IdTipoProcedimeinto] ASC);
GO

-- Creating primary key on [IdPersona] in table 'PersonaSet_Paciente'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente]
ADD CONSTRAINT [PK_PersonaSet_Paciente]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IdPersona] in table 'PersonaSet_Cliente'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Cliente]
ADD CONSTRAINT [PK_PersonaSet_Cliente]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IdPersona] in table 'PersonaSet_Empleado'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Empleado]
ADD CONSTRAINT [PK_PersonaSet_Empleado]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ContactoEmergencia_IdContactoEmergencia] in table 'PersonaSet_Paciente'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente]
ADD CONSTRAINT [FK_PacienteContactoEmergencia]
    FOREIGN KEY ([ContactoEmergencia_IdContactoEmergencia])
    REFERENCES [dbo.gestionvacari].[ContactoEmergenciaSet]
        ([IdContactoEmergencia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteContactoEmergencia'
CREATE INDEX [IX_FK_PacienteContactoEmergencia]
ON [dbo.gestionvacari].[PersonaSet_Paciente]
    ([ContactoEmergencia_IdContactoEmergencia]);
GO

-- Creating foreign key on [Paciente_IdPersona] in table 'DiagnosticoSet'
ALTER TABLE [dbo.gestionvacari].[DiagnosticoSet]
ADD CONSTRAINT [FK_PacienteDiagnostico]
    FOREIGN KEY ([Paciente_IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet_Paciente]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteDiagnostico'
CREATE INDEX [IX_FK_PacienteDiagnostico]
ON [dbo.gestionvacari].[DiagnosticoSet]
    ([Paciente_IdPersona]);
GO

-- Creating foreign key on [Enfermedad_IdEnfermedad] in table 'DiagnosticoSet'
ALTER TABLE [dbo.gestionvacari].[DiagnosticoSet]
ADD CONSTRAINT [FK_DiagnosticoEnfermedad]
    FOREIGN KEY ([Enfermedad_IdEnfermedad])
    REFERENCES [dbo.gestionvacari].[EnfermedadSet]
        ([IdEnfermedad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagnosticoEnfermedad'
CREATE INDEX [IX_FK_DiagnosticoEnfermedad]
ON [dbo.gestionvacari].[DiagnosticoSet]
    ([Enfermedad_IdEnfermedad]);
GO

-- Creating foreign key on [Paciente_IdPersona] in table 'SignosVitalesSet'
ALTER TABLE [dbo.gestionvacari].[SignosVitalesSet]
ADD CONSTRAINT [FK_PacienteSignosVitales]
    FOREIGN KEY ([Paciente_IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet_Paciente]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteSignosVitales'
CREATE INDEX [IX_FK_PacienteSignosVitales]
ON [dbo.gestionvacari].[SignosVitalesSet]
    ([Paciente_IdPersona]);
GO

-- Creating foreign key on [Paciente_IdPersona] in table 'CitaMedicaSet'
ALTER TABLE [dbo.gestionvacari].[CitaMedicaSet]
ADD CONSTRAINT [FK_PacienteCitaMedica]
    FOREIGN KEY ([Paciente_IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet_Paciente]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteCitaMedica'
CREATE INDEX [IX_FK_PacienteCitaMedica]
ON [dbo.gestionvacari].[CitaMedicaSet]
    ([Paciente_IdPersona]);
GO

-- Creating foreign key on [TipoCitaMedica_IdTipoCitaMedica] in table 'CitaMedicaSet'
ALTER TABLE [dbo.gestionvacari].[CitaMedicaSet]
ADD CONSTRAINT [FK_CitaMedicaTipoCitaMedica]
    FOREIGN KEY ([TipoCitaMedica_IdTipoCitaMedica])
    REFERENCES [dbo.gestionvacari].[TipoCitaMedicaSet]
        ([IdTipoCitaMedica])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CitaMedicaTipoCitaMedica'
CREATE INDEX [IX_FK_CitaMedicaTipoCitaMedica]
ON [dbo.gestionvacari].[CitaMedicaSet]
    ([TipoCitaMedica_IdTipoCitaMedica]);
GO

-- Creating foreign key on [Paciente_IdPersona] in table 'ProcedimientoSet'
ALTER TABLE [dbo.gestionvacari].[ProcedimientoSet]
ADD CONSTRAINT [FK_PacienteProcedimiento]
    FOREIGN KEY ([Paciente_IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet_Paciente]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteProcedimiento'
CREATE INDEX [IX_FK_PacienteProcedimiento]
ON [dbo.gestionvacari].[ProcedimientoSet]
    ([Paciente_IdPersona]);
GO

-- Creating foreign key on [Factura_IdFactura] in table 'DetalleFacturaSet'
ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet]
ADD CONSTRAINT [FK_FacturaDetalleFactura]
    FOREIGN KEY ([Factura_IdFactura])
    REFERENCES [dbo.gestionvacari].[FacturaSet]
        ([IdFactura])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaDetalleFactura'
CREATE INDEX [IX_FK_FacturaDetalleFactura]
ON [dbo.gestionvacari].[DetalleFacturaSet]
    ([Factura_IdFactura]);
GO

-- Creating foreign key on [Producto_IdProducto] in table 'DetalleFacturaSet'
ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet]
ADD CONSTRAINT [FK_DetalleFacturaProducto]
    FOREIGN KEY ([Producto_IdProducto])
    REFERENCES [dbo.gestionvacari].[ProductoSet]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleFacturaProducto'
CREATE INDEX [IX_FK_DetalleFacturaProducto]
ON [dbo.gestionvacari].[DetalleFacturaSet]
    ([Producto_IdProducto]);
GO

-- Creating foreign key on [PedidoExamenMedico_IdPedidoExamenMedico] in table 'PersonaSet_Paciente'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente]
ADD CONSTRAINT [FK_PedidoExamenMedicoPaciente]
    FOREIGN KEY ([PedidoExamenMedico_IdPedidoExamenMedico])
    REFERENCES [dbo.gestionvacari].[PedidoExamenMedicoSet]
        ([IdPedidoExamenMedico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoExamenMedicoPaciente'
CREATE INDEX [IX_FK_PedidoExamenMedicoPaciente]
ON [dbo.gestionvacari].[PersonaSet_Paciente]
    ([PedidoExamenMedico_IdPedidoExamenMedico]);
GO

-- Creating foreign key on [PedidoExamenMedico_IdPedidoExamenMedico] in table 'DetallePedidoMedicoSet'
ALTER TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet]
ADD CONSTRAINT [FK_PedidoExamenMedicoDetallePedidoMedico]
    FOREIGN KEY ([PedidoExamenMedico_IdPedidoExamenMedico])
    REFERENCES [dbo.gestionvacari].[PedidoExamenMedicoSet]
        ([IdPedidoExamenMedico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoExamenMedicoDetallePedidoMedico'
CREATE INDEX [IX_FK_PedidoExamenMedicoDetallePedidoMedico]
ON [dbo.gestionvacari].[DetallePedidoMedicoSet]
    ([PedidoExamenMedico_IdPedidoExamenMedico]);
GO

-- Creating foreign key on [ExamenMedico_IdExamenMedico] in table 'DetallePedidoMedicoSet'
ALTER TABLE [dbo.gestionvacari].[DetallePedidoMedicoSet]
ADD CONSTRAINT [FK_DetallePedidoMedicoExamenMedico]
    FOREIGN KEY ([ExamenMedico_IdExamenMedico])
    REFERENCES [dbo.gestionvacari].[ExamenMedicoSet]
        ([IdExamenMedico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetallePedidoMedicoExamenMedico'
CREATE INDEX [IX_FK_DetallePedidoMedicoExamenMedico]
ON [dbo.gestionvacari].[DetallePedidoMedicoSet]
    ([ExamenMedico_IdExamenMedico]);
GO

-- Creating foreign key on [Cliente_IdPersona] in table 'FacturaSet'
ALTER TABLE [dbo.gestionvacari].[FacturaSet]
ADD CONSTRAINT [FK_ClienteFactura]
    FOREIGN KEY ([Cliente_IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet_Cliente]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFactura'
CREATE INDEX [IX_FK_ClienteFactura]
ON [dbo.gestionvacari].[FacturaSet]
    ([Cliente_IdPersona]);
GO

-- Creating foreign key on [CitaMedica_IdCitaMedica] in table 'PersonaSet_Empleado'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Empleado]
ADD CONSTRAINT [FK_EmpleadoCitaMedica]
    FOREIGN KEY ([CitaMedica_IdCitaMedica])
    REFERENCES [dbo.gestionvacari].[CitaMedicaSet]
        ([IdCitaMedica])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoCitaMedica'
CREATE INDEX [IX_FK_EmpleadoCitaMedica]
ON [dbo.gestionvacari].[PersonaSet_Empleado]
    ([CitaMedica_IdCitaMedica]);
GO

-- Creating foreign key on [TipoCitaMedica_IdTipoCitaMedica] in table 'DetalleFacturaSet'
ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet]
ADD CONSTRAINT [FK_TipoCitaMedicaDetalleFactura]
    FOREIGN KEY ([TipoCitaMedica_IdTipoCitaMedica])
    REFERENCES [dbo.gestionvacari].[TipoCitaMedicaSet]
        ([IdTipoCitaMedica])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoCitaMedicaDetalleFactura'
CREATE INDEX [IX_FK_TipoCitaMedicaDetalleFactura]
ON [dbo.gestionvacari].[DetalleFacturaSet]
    ([TipoCitaMedica_IdTipoCitaMedica]);
GO

-- Creating foreign key on [TipoProcedimiento_IdTipoProcedimeinto] in table 'ProcedimientoSet'
ALTER TABLE [dbo.gestionvacari].[ProcedimientoSet]
ADD CONSTRAINT [FK_ProcedimientoTipoProcedimiento]
    FOREIGN KEY ([TipoProcedimiento_IdTipoProcedimeinto])
    REFERENCES [dbo.gestionvacari].[TipoProcedimientoSet]
        ([IdTipoProcedimeinto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProcedimientoTipoProcedimiento'
CREATE INDEX [IX_FK_ProcedimientoTipoProcedimiento]
ON [dbo.gestionvacari].[ProcedimientoSet]
    ([TipoProcedimiento_IdTipoProcedimeinto]);
GO

-- Creating foreign key on [TipoProcedimiento_IdTipoProcedimeinto] in table 'DetalleFacturaSet'
ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet]
ADD CONSTRAINT [FK_TipoProcedimientoDetalleFactura]
    FOREIGN KEY ([TipoProcedimiento_IdTipoProcedimeinto])
    REFERENCES [dbo.gestionvacari].[TipoProcedimientoSet]
        ([IdTipoProcedimeinto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProcedimientoDetalleFactura'
CREATE INDEX [IX_FK_TipoProcedimientoDetalleFactura]
ON [dbo.gestionvacari].[DetalleFacturaSet]
    ([TipoProcedimiento_IdTipoProcedimeinto]);
GO

-- Creating foreign key on [Empleado_IdPersona] in table 'PagoEmpleadoSet'
ALTER TABLE [dbo.gestionvacari].[PagoEmpleadoSet]
ADD CONSTRAINT [FK_EmpleadoPagoEmpleado]
    FOREIGN KEY ([Empleado_IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet_Empleado]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoPagoEmpleado'
CREATE INDEX [IX_FK_EmpleadoPagoEmpleado]
ON [dbo.gestionvacari].[PagoEmpleadoSet]
    ([Empleado_IdPersona]);
GO

-- Creating foreign key on [ExamenMedico_IdExamenMedico] in table 'DetalleFacturaSet'
ALTER TABLE [dbo.gestionvacari].[DetalleFacturaSet]
ADD CONSTRAINT [FK_ExamenMedicoDetalleFactura]
    FOREIGN KEY ([ExamenMedico_IdExamenMedico])
    REFERENCES [dbo.gestionvacari].[ExamenMedicoSet]
        ([IdExamenMedico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamenMedicoDetalleFactura'
CREATE INDEX [IX_FK_ExamenMedicoDetalleFactura]
ON [dbo.gestionvacari].[DetalleFacturaSet]
    ([ExamenMedico_IdExamenMedico]);
GO

-- Creating foreign key on [IdPersona] in table 'PersonaSet_Paciente'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Paciente]
ADD CONSTRAINT [FK_Paciente_inherits_Persona]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet]
        ([IdPersona])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPersona] in table 'PersonaSet_Cliente'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Persona]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet]
        ([IdPersona])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPersona] in table 'PersonaSet_Empleado'
ALTER TABLE [dbo.gestionvacari].[PersonaSet_Empleado]
ADD CONSTRAINT [FK_Empleado_inherits_Persona]
    FOREIGN KEY ([IdPersona])
    REFERENCES [dbo.gestionvacari].[PersonaSet]
        ([IdPersona])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------