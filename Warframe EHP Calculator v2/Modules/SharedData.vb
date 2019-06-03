Imports System.Xml.Serialization

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

<XmlType(TypeName:="rank_multipliers")>
Public Class Rank_Multipliers
    <XmlArray("warframes")>
    Public Property Warframes As New List(Of Rank_Multiplier)
    <XmlArray("companions")>
    Public Property Companions As New List(Of Rank_Multiplier)
    <XmlArray("sentinels")>
    Public Property Sentinels As New List(Of Rank_Multiplier)
End Class

<XmlType(TypeName:="rank_multiplier")>
Public Class Rank_Multiplier
    <XmlAttribute("name")>
    Public Property Name As String
    <XmlAttribute("multiplier")>
    Public Property Multiplier As Decimal
End Class