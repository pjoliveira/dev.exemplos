SELECT "new Municipio {ID = " || m.id || 
       ", Nome = " || char(34) || m.nome || char(34) || 
       ", EstadoID = " || m.ufid || "}," AS texto
  FROM tgmunicipio m;
