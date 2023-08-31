
select "new Estado { ID = "||  u.id  || 
       ", Nome = " ||  char(34) ||u.nome ||  char(34) || 
       ", Sigla = " ||  char(34) ||u.sigla ||   char(34) ||
       ", PaisID = " ||   u.paisid ||  "},"  as texto 
from tguf u
