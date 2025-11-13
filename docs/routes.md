➡️ [Volver a la documentación principal](../README.md)

# 🌐 Variables de rutas — Comparativo

<table>
  <thead>
    <tr>
      <th style="width:50%">🔹 <span style="font-size:1.1em">**Testing** 🧪</span></th>
      <th style="width:50%">🔸 <span style="font-size:1.1em">**Producción** 🚀</span></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>
        <b>📄 Ruta emisión 2025 (DSN)</b>
        <pre><code>🗂️ Dsn=Emisión 2025;
📂 dbq=\\10.10.10.1\Comunicados\TICS\Pruebas software\Uipath\cargue-sicerco\3. EMISIÓN\Emisión 2025\EMISION 2025;
⚙️ driverid=1046;
📑 fil=excel 12.0;
💾 maxbuffersize=2048;
⏱️ pagetimeout=5</code></pre>
      </td>
      <td>
        <b>📄 Ruta emisión 2025 (DSN)</b>
        <pre><code>🗂️ Dsn=Emisión 2025;
📂 dbq=\\10.10.15.120\DatosRetie\RETIEDICTAMENES\3. EMISIÓN\Emisión 2025\EMISION 2025.xlsm;
📁 defaultdir=\\10.10.15.120\DatosRetie\RETIEDICTAMENES\3. EMISIÓN\Emisión 2025;
⚙️ driverid=1046;
📑 fil=excel 12.0;
💾 maxbuffersize=2048;
⏱️ pagetimeout=5</code></pre>
      </td>
    </tr>
    <tr>
      <td>
        <b>📦 Ruta extracción de dictámenes</b>
        <pre><code>\\10.10.10.1\Comunicados\TICS\Pruebas software\Uipath\cargue-sicerco\4. ORIGINAL Y COPIA\COPIA</code></pre>
      </td>
      <td>
        <b>📦 Ruta extracción de dictámenes</b>
        <pre><code>\\10.10.15.120\DatosRetie\RETIEDICTAMENES\4. ORIGINAL Y COPIA\COPIA\</code></pre>
      </td>
    </tr>
    <tr>
      <td>
        <b>🗃️ Ruta estructura cargue masivo (DSN)</b>
        <pre><code>🗂️ Dsn=codigosCargueMasivo;
📂 dbq=\\10.10.10.1\Comunicados\TICS\Pruebas software\Uipath\cargue-sicerco\0. CargueMasivo\estructuraCargueMasivo.xlsx;
📁 defaultdir=\\10.10.10.1\Comunicados\TICS\Pruebas software\Uipath\cargue-sicerco\0. CargueMasivo;
⚙️ driverid=1046;
📑 fil=excel 12.0;
💾 maxbuffersize=2048;
⏱️ pagetimeout=5</code></pre>
      </td>
      <td>
        <b>🗃️ Ruta estructura cargue masivo (DSN)</b>
        <pre><code>🗂️ Dsn=codigosCargueMasivo;
📂 dbq=\\10.10.15.120\DatosRetie\RETIEDICTAMENES\1. SICERCO RETIE\2. CARGUE A SICERCO\2025\0. CargueMasivo\codigosCargueMasivo.xlsx;
📁 defaultdir=\\10.10.15.120\DatosRetie\RETIEDICTAMENES\1. SICERCO RETIE\2. CARGUE A SICERCO\2025\0. CargueMasivo;
⚙️ driverid=1046;
📑 fil=excel 12.0;
💾 maxbuffersize=2048;
⏱️ pagetimeout=5</code></pre>
      </td>
    </tr>
  </tbody>
</table>
