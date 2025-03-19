Sub ModifyExcel()
    Dim ws As Worksheet
    Dim lastRow As Long
    Dim colEsModificacion As Integer
    Dim colCodigoDepartamento As Integer
    Dim colFechaExpedicion As Integer
    Dim colInstalacion As Integer
    Dim cell As Range
    Dim fechaActual As String

    ' Definir la hoja activa
    Set ws = ActiveSheet

    ' Vaciar la celda V1
    ws.Range("V1").Value = ""

    ' Obtener la fecha actual en formato YYYY-MM-DD con comilla simple
    fechaActual = "'" & Format(Date, "yyyy-mm-dd")

    ' Encontrar la columna de esModificacion
    On Error Resume Next
    colEsModificacion = Application.WorksheetFunction.Match("esModificacion", ws.Rows(1), 0)
    If colEsModificacion = 0 Then colEsModificacion = ws.Cells(1, "L").Value ' Usar L1 si es necesario
    On Error GoTo 0

    ' Encontrar la columna de codigoDepartamento
    colCodigoDepartamento = Application.WorksheetFunction.Match("codigoDepartamento", ws.Rows(1), 0)

    ' Encontrar la columna de fechaExpedicion
    colFechaExpedicion = Application.WorksheetFunction.Match("fechaExpedicion", ws.Rows(1), 0)
    If colFechaExpedicion = 0 Then colFechaExpedicion = ws.Cells(1, "D").Value ' Usar D1 si es necesario

    ' Encontrar la columna de instalacion
    colInstalacion = Application.WorksheetFunction.Match("instalacion", ws.Rows(1), 0)
    If colInstalacion = 0 Then colInstalacion = ws.Cells(1, "T").Value ' Usar T1 si es necesario

    ' Determinar la última fila con datos
    lastRow = ws.Cells(ws.Rows.Count, colCodigoDepartamento).End(xlUp).Row

    ' Recorrer filas para modificar valores en esModificacion
    For Each cell In ws.Range(ws.Cells(2, colEsModificacion), ws.Cells(lastRow, colEsModificacion))
        cell.Value = "'false" ' Se coloca comilla simple para que lo interprete como texto
    Next cell

    ' Recorrer filas para modificar valores en codigoDepartamento
    For Each cell In ws.Range(ws.Cells(2, colCodigoDepartamento), ws.Cells(lastRow, colCodigoDepartamento))
        If IsNumeric(cell.Value) And Len(cell.Value) = 1 Then
            cell.Value = "'" & Format(cell.Value, "00") ' Agregar comilla simple al inicio
        End If
    Next cell

    ' Recorrer filas para agregar la fecha en fechaExpedicion
    For Each cell In ws.Range(ws.Cells(2, colFechaExpedicion), ws.Cells(lastRow, colFechaExpedicion))
        cell.Value = fechaActual ' Agregar la fecha actual con comilla simple
    Next cell

    ' Recorrer filas para agregar el valor "Nueva" en instalacion
    For Each cell In ws.Range(ws.Cells(2, colInstalacion), ws.Cells(lastRow, colInstalacion))
        cell.Value = "'Nueva" ' Agregar comilla simple al inicio
    Next cell
End Sub
