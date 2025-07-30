➡️ [Volver a la documentación principal](../README.md)

## ⚠️ Importante — uso de rutas de *Testing*

> Si la automatización falla y es necesario hacer **pruebas**, utiliza siempre las **rutas de *Testing*** para simular el trabajo del robot.  
>
> Esto permite **descartar errores** de manera controlada **sin afectar las carpetas originales de Producción**.  
>
> 🔹 Ejecuta todas las pruebas apuntando a las rutas de *Testing* (ver tabla comparativa abajo).  
> 🔸 Una vez identificado el error, podrás corregirlo y luego usar las rutas de Producción.

### 📍 ¿Dónde cambio las rutas?
Las rutas se administran como **Variables Globales (Assets) en Orchestrator**.  
El robot está configurado para **leer estas variables desde Orchestrator al inicio** de cada ejecución.

