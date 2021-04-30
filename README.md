# JoinPDF
# Esta es una aplicacion de consola para unir varios archvos pdf .
# Se usa mergepdf.exe filename_1.pdf filename_2.pdf filename_N.pdf mergedfilename.pdf
# El codigo lee la linea de comandos y usa los nombres introducidos como los arcivos a unir y el ultimo debe ser el nombre del archivo donde se guardaran los archivos 
# ejemplo: mergepdf.exe archivo1.pdf archivo2.pdf archivo3.pdf unidos.pdf
# Se guardará en el archivo unidos.pdf los archivos1.pdf, archivos2.pdf, archivo3.pdf
Si no autuliza automaticamente el paquete de itextsharp instalar desde el Pack Manager Console
PM >Install-Package iTextSharp -Version 5.5.13.1
