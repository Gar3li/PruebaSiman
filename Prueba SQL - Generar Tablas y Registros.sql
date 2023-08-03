--EJERCICIO 2.1 Mostrar el salario mínimo, máximo y promedio por cada departamento.
select D.Nombre,Min(E.Salario) as Minimo,Max(E.Salario) as Maximo,
AVG(E.Salario) as Promedio  
from Departamentos D 
join Empleados E on E.DepartamentoId=D.id group by d.Nombre;

--EJERCICIO 2.2 Listar los departamentos que tienen 3 o más empleados.


select D.Nombre, NoEmpleados=COUNT(e.Nombre) 
from Departamentos D 
join Empleados E on E.DepartamentoId=D.id  group by d.Nombre  Having(Count(e.Nombre)>=3); 

--EJERCICIO 2.3 Mostrar los colaboradores que tienen al menos 1 año de haber ingresado, indicando en una columna los meses que tienen de haber ingresado.


select E.Nombre,(Month(GETDATE())+ (12-MONTH(e.FechaIngreso))) as Meses
from Empleados E  where (Month(GETDATE())+ (12-MONTH(e.FechaIngreso)))>12 ; 



