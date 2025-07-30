# 🤖 Robot Sicerco

Automatización desarrollada en **UiPath** para organizar, validar y subir dictámenes al sistema **Sicerco** cumpliendo las reglas del Manual Sicerco.

---

## 📌 ¿Qué hace este robot?

- Organiza los archivos de **Emisión** en carpetas diarias y subcarpetas (máx. 250 elementos cada una).
- Valida datos de acuerdo con el **Manual Sicerco** (Excel/ODBC, normalización y control de campos obligatorios).
- Genera informes por subcarpeta y comprime los archivos en formato ZIP.
- Sube los ZIPs al **portal Sicerco** y verifica el registro correcto de los dictámenes.
- Permite **diagnosticar fallas en un entorno Testing** (sin afectar Producción) cambiando las rutas desde **Assets (Variables Globales)** en Orchestrator.

---

## 🗂️ Documentación Sicerco

- [🗺️ Rutas](docs/routes.md)  
  Mapa de rutas para **Producción** y **Testing**.  
  - [⚠️ Notas importantes (usar rutas de Testing)](docs/routes.md#-importante--uso-de-rutas-de-testing)

- [🌟 Repositorio oficial: `robot_sicerco`](https://github.com/duvan-sanabria-sm/robot_sicerco)  
  Código fuente, gestión de **issues**, seguimiento de **releases** y documentación técnica del robot.

- [📊 Diagrama de Flujo Principal](docs/diagrams/main_diagram.png)  
  Vista general del proceso numerado paso a paso.

---

## ⚠️ Diagnóstico de fallas

Si la automatización falla:  

1. Cambiar las **rutas a Testing** desde **Assets (Variables Globales)** en Orchestrator.  
2. Ejecutar pruebas en el entorno de Testing para diagnosticar el error sin afectar Producción.  
3. Una vez corregido el error, restaurar los valores de Producción en los Assets y ejecutar nuevamente.

> Consulta: [Notas importantes (usar rutas de Testing)](docs/routes.md#-importante--uso-de-rutas-de-testing)

---
