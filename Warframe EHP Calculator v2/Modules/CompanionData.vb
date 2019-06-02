
Imports System.Xml.Serialization

<XmlType(TypeName:="companion")>
Public Class Companion
    <XmlAttribute("name")>
    Public Property Name As String
    <XmlAttribute("type")>
    Public Property Type As String
    <XmlAttribute("sort")>
    Public Property Sort As Integer
    <XmlArray("variants")>
    Public Property Variants As New List(Of [Variant])
    <XmlArray("rank_multipliers")>
    Public Property Rank_Multipliers As New List(Of Rank_Multiplier)
End Class