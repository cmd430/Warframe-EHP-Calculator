
Imports System.Xml.Serialization

<XmlType(TypeName:="warframe")>
Public Class Warframe
    <XmlAttribute("name")>
    Public Property Name As String
    <XmlArray("variants")>
    Public Property Variants As New List(Of [Variant])
    <XmlArray("rank_multipliers")>
    Public Property Rank_Multipliers As New List(Of Rank_Multiplier)
End Class

<XmlType(TypeName:="variant")>
Public Class [Variant]
    <XmlAttribute("name")>
    Public Property Name As String
    <XmlAttribute("armor")>
    Public Property Armor As Decimal
    <XmlAttribute("health")>
    Public Property Health As Decimal
    <XmlAttribute("shield")>
    Public Property Shield As Decimal
    <XmlAttribute("energy")>
    Public Property Energy As Decimal
    <XmlAttribute("strength")>
    Public Property strength As Decimal
End Class

<XmlType(TypeName:="rank_multiplier")>
Public Class Rank_Multiplier
    <XmlAttribute("name")>
    Public Property Name As String
    <XmlAttribute("multiplier")>
    Public Property Multiplier As Decimal
End Class