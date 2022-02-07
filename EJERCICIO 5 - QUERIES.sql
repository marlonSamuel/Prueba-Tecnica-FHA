
--QUERY 1- BUSCAR CONSUMO DE CLIENTE ESPECIFICO
SELECT C.nombre,C.apellido,YEAR(V.fecha) AS ANIO, MONTH(V.fecha) AS MES, V.total, M.prefijo AS MONEDA, M.descripcion AS 'DESCRIPCION MONEDA' FROM Venta V 
INNER JOIN Cliente C ON V.cliente_id = C.id
INNER JOIN Moneda M ON V.moneda_id = M.id
WHERE cliente_id = 2 --ID PRODUCTO BUSCADO
GROUP BY C.nombre, C.apellido,YEAR(V.fecha), MONTH(V.fecha), V.total, M.prefijo,M.descripcion
ORDER BY V.total DESC

--QUERY PARA BUSCAR PRODUCTO MAS VENDIDO ORDENANDO POR LA CANTIDAD VENDIDA
SELECT P.nombre AS PRODUCTO, SUM(D.cantidad) AS 'CANTIDAD VENDIDA' FROM DetalleVenta D
INNER JOIN Producto P ON D.producto_id = P.id
INNER JOIN Venta V ON D.venta_id = V.id
WHERE YEAR(V.fecha) = 2022 --ANIO BUSCADO
GROUP BY P.nombre, YEAR(V.fecha)
ORDER BY SUM(D.cantidad) DESC
