﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("VBNetSpeedTests.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to n.
        '''</summary>
        Friend ReadOnly Property ArticleSuffixUndefined() As String
            Get
                Return ResourceManager.GetString("ArticleSuffixUndefined", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to a.
        '''</summary>
        Friend ReadOnly Property ArticleUndefined() As String
            Get
                Return ResourceManager.GetString("ArticleUndefined", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fastest:.
        '''</summary>
        Friend ReadOnly Property LabelFastestMethod() As String
            Get
                Return ResourceManager.GetString("LabelFastestMethod", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Using.
        '''</summary>
        Friend ReadOnly Property LabelMethod() As String
            Get
                Return ResourceManager.GetString("LabelMethod", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Name.
        '''</summary>
        Friend ReadOnly Property LabelNameResource() As String
            Get
                Return ResourceManager.GetString("LabelNameResource", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Assign empty string.
        '''</summary>
        Friend ReadOnly Property NameAssignEmptyStringTest() As String
            Get
                Return ResourceManager.GetString("NameAssignEmptyStringTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Is string empty.
        '''</summary>
        Friend ReadOnly Property NameIsStringEmptyTest() As String
            Get
                Return ResourceManager.GetString("NameIsStringEmptyTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Whole number data type comparison.
        '''</summary>
        Friend ReadOnly Property NameNumberDataTypeTest() As String
            Get
                Return ResourceManager.GetString("NameNumberDataTypeTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Long string concatenation.
        '''</summary>
        Friend ReadOnly Property NameStringConcatenationLongTest() As String
            Get
                Return ResourceManager.GetString("NameStringConcatenationLongTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Short string concatenation.
        '''</summary>
        Friend ReadOnly Property NameStringConcatenationShortTest() As String
            Get
                Return ResourceManager.GetString("NameStringConcatenationShortTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Format string.
        '''</summary>
        Friend ReadOnly Property NameStringFormatTest() As String
            Get
                Return ResourceManager.GetString("NameStringFormatTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property Stopwatch() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Stopwatch", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  s.
        '''</summary>
        Friend ReadOnly Property UnitTime() As String
            Get
                Return ResourceManager.GetString("UnitTime", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
