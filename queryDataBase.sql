create database sipDataBase;
use sipDatabase; 

CREATE TABLE `t_usuarios` (
  `idUsuario` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `area` varchar(255) DEFAULT NULL,
  `correo` varchar(255) DEFAULT NULL,
  `extension` varchar(255) DEFAULT NULL,  
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;

CREATE TABLE `t_inventarios` (
  `idInventario` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `equipo` varchar(255) DEFAULT NULL,
  `fechaCompra` varchar(255) DEFAULT NULL,
  `factura` varchar(255) DEFAULT NULL,  
  PRIMARY KEY (`idInventario`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;


CREATE TABLE `t_reportes` (
  `idReporte` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `id_categoria` varchar(255) DEFAULT NULL,
  `extension` varchar(255) DEFAULT NULL,
  `num_inventario` varchar(255) DEFAULT NULL,
  `problema` varchar(255) DEFAULT NULL,  
  `fecha_repo` varchar(255) DEFAULT NULL,  
  `fecha_cierra` varchar(255) DEFAULT NULL,  
  `solucion` varchar(255) DEFAULT NULL,  
  `calificacion` varchar(255) DEFAULT NULL, 
  `abierto` bool default true, 
  PRIMARY KEY (`idReporte`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
	
CREATE TABLE `t_categorias` (
  `idCategoria` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(255) DEFAULT NULL,  
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;