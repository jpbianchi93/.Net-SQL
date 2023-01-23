--1 
--select D.Titulo, D.FechaLanzamiento, E.Descripcion Estilo 
--from DISCOS D, ESTILOS E 
--where d.IdEstilo = e.Id

--2
--insert into ESTILOS Values ('Tango')
--insert into ESTILOS Values ('Cumbia')

--3
--insert into DISCOS values ('Clicks Modernos', 1983-11-05,9,'url',3,1)
--insert into DISCOS values ('Cantata de puentes amarillos', 1973-01-05,6,'url',3,1)

--4
--update DISCOS set FechaLanzamiento = 1973-12-31 , CantidadCanciones = 7 where id=4

--5
--delete from DISCOS where id=2

--6
--select * from DISCOS where IdEstilo = 3

--7
--select D.Titulo, E.Descripcion as Estilo, T.Descripcion as Edición 
--from DISCOS D, ESTILOS E, TIPOSEDICION T
--where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id

--8
--select * from DISCOS where Titulo like '%ho%'