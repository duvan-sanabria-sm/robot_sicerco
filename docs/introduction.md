➡️ [Volver a la documentación principal](../README.md)

## 📌 ¿Qué hace este robot?

Automatización desarrollada en **UiPath** para organizar, validar y subir dictámenes al sistema **Sicerco** cumpliendo las reglas del Manual Sicerco.


- Organiza los archivos de **Emisión** en carpetas diarias y subcarpetas (máx. 250 elementos cada una).
- Valida datos de acuerdo con el **Manual Sicerco** (Excel/ODBC, normalización y control de campos obligatorios).
- Genera informes por subcarpeta y comprime los archivos en formato ZIP.
- Sube los ZIPs al **portal Sicerco** y verifica el registro correcto de los dictámenes.
- Permite **diagnosticar fallas en un entorno Testing** (sin afectar Producción) cambiando las rutas desde **Assets (Variables Globales)** en Orchestrator.