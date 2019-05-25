Imports System.Runtime.InteropServices

Class CustomTabControl

    Inherits TabControl
    Private Const TCM_ADJUSTRECT As Integer = &H1328

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = TCM_ADJUSTRECT Then
            Dim rect As RECT = CType(m.GetLParam(GetType(RECT)), RECT)
            rect.Left = Me.Left - Me.Margin.Left
            rect.Right = Me.Right + Me.Margin.Right
            rect.Top = Me.Top - Me.Margin.Top - 1
            rect.Bottom = Me.Bottom + Me.Margin.Bottom
            Marshal.StructureToPtr(rect, m.LParam, True)
        End If
        MyBase.WndProc(m)
    End Sub

    Private Structure RECT
        Public Left As Integer, Top As Integer, Right As Integer, Bottom As Integer
    End Structure

End Class