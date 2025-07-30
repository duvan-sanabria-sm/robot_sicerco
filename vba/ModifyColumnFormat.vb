Sub ModifyExcel()
    Dim ws As Worksheet
    Dim lastRow As Long
    Dim cell As Range
    Dim fechaActual As String
 
    ' Definir la hoja activa
    Set ws = ActiveSheet
 
    ' Obtener la fecha actual en formato YYYY-MM-DD con comilla simple
    fechaActual = "'" & Format(Date, "yyyy-mm-dd")
 
    ' Determinar la última fila con datos en la columna B
    lastRow = ws.Cells(ws.Rows.Count, "B").End(xlUp).Row
 
    ' Recorrer filas para agregar la fecha en la columna B (fechaExpedicion)
    For Each cell In ws.Range("B4:B" & lastRow)
        cell.Value = fechaActual
    Next cell
End Sub
 