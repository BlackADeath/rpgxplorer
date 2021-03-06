﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.312
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("DomainsSchoolsDataset"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class DomainsSchoolsDataset
    Inherits System.Data.DataSet
    
    Private tableDomainsSchools As DomainsSchoolsDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("DomainsSchools")) Is Nothing) Then
                MyBase.Tables.Add(New DomainsSchoolsDataTable(ds.Tables("DomainsSchools")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property DomainsSchools() As DomainsSchoolsDataTable
        Get
            Return Me.tableDomainsSchools
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.BrowsableAttribute(true),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As DomainsSchoolsDataset = CType(MyBase.Clone,DomainsSchoolsDataset)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("DomainsSchools")) Is Nothing) Then
                MyBase.Tables.Add(New DomainsSchoolsDataTable(ds.Tables("DomainsSchools")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Overloads Sub InitVars()
        Me.InitVars(True)
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableDomainsSchools = CType(MyBase.Tables("DomainsSchools"), DomainsSchoolsDataTable)
        If (initTable = True) Then
            If (Not (Me.tableDomainsSchools) Is Nothing) Then
                Me.tableDomainsSchools.InitVars()
            End If
        End If
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Private Sub InitClass()
        Me.DataSetName = "DomainsSchoolsDataset"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/DomainsSchoolsDataset.xsd"
        Me.EnforceConstraints = True
        Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableDomainsSchools = New DomainsSchoolsDataTable
        MyBase.Tables.Add(Me.tableDomainsSchools)
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Private Function ShouldSerializeDomainsSchools() As Boolean
        Return False
    End Function

    <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars()
        End If
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
        Dim ds As DomainsSchoolsDataset = New DomainsSchoolsDataset
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function

    Public Delegate Sub DomainsSchoolsRowChangeEventHandler(ByVal sender As Object, ByVal e As DomainsSchoolsRowChangeEvent)

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), _
     System.Serializable(), _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
    Partial Public Class DomainsSchoolsDataTable
        Inherits System.Data.DataTable
        Implements System.Collections.IEnumerable

        Private columnClassName As System.Data.DataColumn

        Private columnDomains As System.Data.DataColumn

        Private columnSpecialist As System.Data.DataColumn

        Private columnProhibited As System.Data.DataColumn

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            MyBase.New()
            Me.TableName = "DomainsSchools"
            Me.BeginInit()
            Me.InitClass()
            Me.EndInit()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(ByVal table As System.Data.DataTable)
            MyBase.New()
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property ClassNameColumn() As System.Data.DataColumn
            Get
                Return Me.columnClassName
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property DomainsColumn() As System.Data.DataColumn
            Get
                Return Me.columnDomains
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property SpecialistColumn() As System.Data.DataColumn
            Get
                Return Me.columnSpecialist
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property ProhibitedColumn() As System.Data.DataColumn
            Get
                Return Me.columnProhibited
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         System.ComponentModel.Browsable(False)> _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Default Public ReadOnly Property Item(ByVal index As Integer) As DomainsSchoolsRow
            Get
                Return CType(Me.Rows(index), DomainsSchoolsRow)
            End Get
        End Property

        Public Event DomainsSchoolsRowChanging As DomainsSchoolsRowChangeEventHandler

        Public Event DomainsSchoolsRowChanged As DomainsSchoolsRowChangeEventHandler

        Public Event DomainsSchoolsRowDeleting As DomainsSchoolsRowChangeEventHandler

        Public Event DomainsSchoolsRowDeleted As DomainsSchoolsRowChangeEventHandler

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Overloads Sub AddDomainsSchoolsRow(ByVal row As DomainsSchoolsRow)
            Me.Rows.Add(row)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Overloads Function AddDomainsSchoolsRow(ByVal ClassName As String, ByVal Domains As String, ByVal Specialist As String, ByVal Prohibited As String) As DomainsSchoolsRow
            Dim rowDomainsSchoolsRow As DomainsSchoolsRow = CType(Me.NewRow, DomainsSchoolsRow)
            rowDomainsSchoolsRow.ItemArray = New Object() {ClassName, Domains, Specialist, Prohibited}
            Me.Rows.Add(rowDomainsSchoolsRow)
            Return rowDomainsSchoolsRow
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As DomainsSchoolsDataTable = CType(MyBase.Clone, DomainsSchoolsDataTable)
            cln.InitVars()
            Return cln
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New DomainsSchoolsDataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub InitVars()
            Me.columnClassName = MyBase.Columns("ClassName")
            Me.columnDomains = MyBase.Columns("Domains")
            Me.columnSpecialist = MyBase.Columns("Specialist")
            Me.columnProhibited = MyBase.Columns("Prohibited")
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private Sub InitClass()
            Me.columnClassName = New System.Data.DataColumn("ClassName", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnClassName)
            Me.columnDomains = New System.Data.DataColumn("Domains", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnDomains)
            Me.columnSpecialist = New System.Data.DataColumn("Specialist", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSpecialist)
            Me.columnProhibited = New System.Data.DataColumn("Prohibited", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnProhibited)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Function NewDomainsSchoolsRow() As DomainsSchoolsRow
            Return CType(Me.NewRow, DomainsSchoolsRow)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New DomainsSchoolsRow(builder)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(DomainsSchoolsRow)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.DomainsSchoolsRowChangedEvent) Is Nothing) Then
                RaiseEvent DomainsSchoolsRowChanged(Me, New DomainsSchoolsRowChangeEvent(CType(e.Row, DomainsSchoolsRow), e.Action))
            End If
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.DomainsSchoolsRowChangingEvent) Is Nothing) Then
                RaiseEvent DomainsSchoolsRowChanging(Me, New DomainsSchoolsRowChangeEvent(CType(e.Row, DomainsSchoolsRow), e.Action))
            End If
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.DomainsSchoolsRowDeletedEvent) Is Nothing) Then
                RaiseEvent DomainsSchoolsRowDeleted(Me, New DomainsSchoolsRowChangeEvent(CType(e.Row, DomainsSchoolsRow), e.Action))
            End If
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.DomainsSchoolsRowDeletingEvent) Is Nothing) Then
                RaiseEvent DomainsSchoolsRowDeleting(Me, New DomainsSchoolsRowChangeEvent(CType(e.Row, DomainsSchoolsRow), e.Action))
            End If
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub RemoveDomainsSchoolsRow(ByVal row As DomainsSchoolsRow)
            Me.Rows.Remove(row)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As DomainsSchoolsDataset = New DomainsSchoolsDataset
            xs.Add(ds.GetSchemaSerializable)
            Dim any1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "DomainsSchoolsDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
    Partial Public Class DomainsSchoolsRow
        Inherits System.Data.DataRow

        Private tableDomainsSchools As DomainsSchoolsDataTable

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableDomainsSchools = CType(Me.Table, DomainsSchoolsDataTable)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property ClassName() As String
            Get
                Try
                    Return CType(Me(Me.tableDomainsSchools.ClassNameColumn), String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'ClassName' in table 'DomainsSchools' is DBNull.", e)
                End Try
            End Get
            Set(ByVal value As String)
                Me(Me.tableDomainsSchools.ClassNameColumn) = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Domains() As String
            Get
                Try
                    Return CType(Me(Me.tableDomainsSchools.DomainsColumn), String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Domains' in table 'DomainsSchools' is DBNull.", e)
                End Try
            End Get
            Set(ByVal value As String)
                Me(Me.tableDomainsSchools.DomainsColumn) = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Specialist() As String
            Get
                Try
                    Return CType(Me(Me.tableDomainsSchools.SpecialistColumn), String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Specialist' in table 'DomainsSchools' is DBNull.", e)
                End Try
            End Get
            Set(ByVal value As String)
                Me(Me.tableDomainsSchools.SpecialistColumn) = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Prohibited() As String
            Get
                Try
                    Return CType(Me(Me.tableDomainsSchools.ProhibitedColumn), String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'Prohibited' in table 'DomainsSchools' is DBNull.", e)
                End Try
            End Get
            Set(ByVal value As String)
                Me(Me.tableDomainsSchools.ProhibitedColumn) = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Function IsClassNameNull() As Boolean
            Return Me.IsNull(Me.tableDomainsSchools.ClassNameColumn)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub SetClassNameNull()
            Me(Me.tableDomainsSchools.ClassNameColumn) = System.Convert.DBNull
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Function IsDomainsNull() As Boolean
            Return Me.IsNull(Me.tableDomainsSchools.DomainsColumn)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub SetDomainsNull()
            Me(Me.tableDomainsSchools.DomainsColumn) = System.Convert.DBNull
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Function IsSpecialistNull() As Boolean
            Return Me.IsNull(Me.tableDomainsSchools.SpecialistColumn)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub SetSpecialistNull()
            Me(Me.tableDomainsSchools.SpecialistColumn) = System.Convert.DBNull
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Function IsProhibitedNull() As Boolean
            Return Me.IsNull(Me.tableDomainsSchools.ProhibitedColumn)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub SetProhibitedNull()
            Me(Me.tableDomainsSchools.ProhibitedColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class DomainsSchoolsRowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As DomainsSchoolsRow
        
        Private eventAction As System.Data.DataRowAction
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As DomainsSchoolsRow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As DomainsSchoolsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
