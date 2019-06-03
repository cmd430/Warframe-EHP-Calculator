
Imports System.Xml.Serialization

<XmlType(TypeName:="archwing")>
Public Class Archwing
    <XmlAttribute("name")>
    Public Property Name As String
    <XmlArray("variants")>
    Public Property Variants As New List(Of [Variant])
    <XmlArray("rank_multipliers")>
    Public Property Rank_Multipliers As New List(Of Rank_Multiplier)
End Class