-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-10-2023 a las 16:42:37
-- Versión del servidor: 10.4.27-MariaDB
-- Versión de PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_cybergear`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `dni` int(11) NOT NULL,
  `domicilio_id` int(11) NOT NULL,
  `email` varchar(40) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `telefono` bigint(15) NOT NULL,
  `baja` varchar(2) NOT NULL DEFAULT 'NO'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_cliente`, `nombre`, `apellido`, `dni`, `domicilio_id`, `email`, `fecha_nacimiento`, `sexo`, `telefono`, `baja`) VALUES
(1, 'Jorge', 'Morales', 44645555, 14, '12343234asdasd@gmail.com', '2023-09-12', 'Hombre', 123345, 'NO'),
(2, 'asd', 'asd', 44645222, 13, '1234asdasd@gmail.com', '2023-09-12', 'Hombre', 234234, 'NO'),
(3, 'Susana', 'Morales', 43264524, 8, '123234asdasd@gmail.com', '2023-09-12', 'Hombre', 123, 'NO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `domicilios`
--

CREATE TABLE `domicilios` (
  `id` int(11) NOT NULL,
  `direccion` varchar(40) NOT NULL,
  `cod_postal` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `domicilios`
--

INSERT INTO `domicilios` (`id`, `direccion`, `cod_postal`) VALUES
(6, 'B pirayui 200vv mz 21 casa 56', 3400),
(7, 'B pirayui 200vv mz 21 casa 56', 3400),
(8, 'barrio quintana', 3400),
(9, ' barrio quintana asd', 3400),
(10, ' barrio quintana asd', 3400),
(11, '  barrio quintana asd', 3400),
(12, '   barrio quintana asdasd', 3400),
(13, '    barrio quintana asdasd', 3400),
(14, 'barrio quintana123', 3400),
(15, 'B pirayui', 3400),
(16, 'barrio chiquita', 3400),
(17, '245vv asda', 3400),
(19, 'dddsssss', 111),
(20, '200vv casa 45', 111),
(21, 'andorra', 111),
(22, 'andorra', 3400);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `nombre_producto` varchar(255) DEFAULT NULL,
  `precio_producto` double(16,2) DEFAULT NULL,
  `descripcion` text DEFAULT NULL,
  `categoria_id` int(2) NOT NULL,
  `cantidad` int(100) NOT NULL,
  `activo` varchar(2) NOT NULL DEFAULT 'SI'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `products`
--

INSERT INTO `products` (`id`, `nombre_producto`, `precio_producto`, `descripcion`, `categoria_id`, `cantidad`, `activo`) VALUES
(8, 'Asseto Corsa', 3000.00, 'carrera', 2, 47, 'SI'),
(9, 'The last of us', 100.00, 'zombies', 2, 53, 'SI'),
(10, 'Dredge', 5000.00, 'asd', 2, 57, 'SI'),
(11, 'Resident Evil 4 RE', 12000.00, 'el clasico ha vuelto ', 2, 23, 'SI'),
(12, 'Sifu', 5000.00, 'sobrevive y cumple tu venganza', 2, 17, 'SI'),
(13, 'Resident Evil 2 RE', 6000.00, 'el clásico reimaginado', 1, 59, 'SI'),
(14, 'Doom Eternal', 6800.00, 'mata demonios', 1, 47, 'SI'),
(15, 'Doom ', 2000.00, 'un clasico modernizado', 1, 28, 'SI'),
(16, 'Resident Evil Village', 6000.00, 'adentrate en la villa', 2, 18, 'SI'),
(17, 'Spiderman Miles Morales', 5900.00, 'spiderman', 2, 8, 'SI'),
(18, 'Mortal Kombat X', 2000.00, 'Fatality', 2, 10, 'SI'),
(19, 'Far Cry 6', 12000.00, 'Far Cry ahora en cuba ', 2, 58, 'SI'),
(20, 'Grand Theft Auto 6', 20000.00, 'Volvemos a Vice City!', 1, 199, 'SI'),
(25, 'Jedi Survivor', 1230.00, 'asd', 2, 123, 'SI'),
(26, 'Street Fighter V', 12000.00, 'vuelve la saga favorita de luchas a la edad moderna ', 2, 100, 'SI'),
(27, 'GTA Triology', 6000.00, 'los clasicos GTA han vuelto', 1, 300, 'SI'),
(28, 'GTA 4 Complete Edition', 3000.00, 'Liberty City una ciudad oscura y llena de oportunidades', 1, 200, 'SI'),
(29, 'Call of Duty Black Ops 3', 1000.00, 'un fps donde la tecnologia es vital', 1, 250, 'SI'),
(30, 'Battlefiel 1 Revolution', 1500.00, 'un shooter lleno de destruccion', 1, 200, 'SI'),
(31, 'Dark Souls Remastered', 6000.00, 'Adentrate a esta aventura llena de dificultades', 2, 600, 'SI'),
(32, 'GTA 5', 1200.00, 'construye tu imperio del crimen', 1, 300, 'SI'),
(33, 'pc', 12.00, 'asdasd', 1, 12, 'SI'),
(34, 'ram_16g', 12444.00, 'asd', 1, 12, 'SI'),
(35, 'Mortal Kombat 1', 12000.00, 'juego de pelea', 1, 12, 'SI'),
(36, 'motherboard ASUS', 12555.00, 'DDR5', 2, 13, 'SI');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipos_usuario`
--

CREATE TABLE `tipos_usuario` (
  `id` int(11) NOT NULL,
  `tipo` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tipos_usuario`
--

INSERT INTO `tipos_usuario` (`id`, `tipo`) VALUES
(1, 'ADMIN'),
(2, 'GERENTE'),
(3, 'VENDEDOR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `dni` int(30) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `perfil_id` int(11) NOT NULL DEFAULT 2,
  `domicilio_id` int(11) DEFAULT NULL,
  `tel` bigint(15) DEFAULT NULL,
  `fecha` date NOT NULL,
  `sexo` varchar(10) NOT NULL,
  `baja` varchar(2) NOT NULL DEFAULT 'NO'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `dni`, `nombre`, `apellido`, `email`, `usuario`, `pass`, `perfil_id`, `domicilio_id`, `tel`, `fecha`, `sexo`, `baja`) VALUES
(47, 4444444, 'Samuel', 'DeLuque', 'vege777@gmail.com', 'admin1', 'admin', 1, 20, 1111444466, '2023-09-22', 'Hombre', 'NO'),
(48, 12345666, 'Willy', 'Rex', 'asdsda1234@gmail.com', 'gerente1', 'gerente1', 2, 20, 444, '1994-06-16', 'Hombre', 'NO'),
(49, 12578, 'rubius', 'doblas', 'vendeme@gmail.com', 'vendedor1', 'vendedor1', 3, 21, 12388, '1994-06-15', 'Hombre', 'NO'),
(51, 44244555, 'Sergio', 'Moles', 'eljefe@gmail.com', 'eljefe', 'admin', 1, 22, 55555111122, '1988-11-09', 'Hombre', 'NO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_cabecera`
--

CREATE TABLE `ventas_cabecera` (
  `id` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_vendedor` int(11) NOT NULL,
  `total_venta` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ventas_cabecera`
--

INSERT INTO `ventas_cabecera` (`id`, `fecha`, `id_cliente`, `id_vendedor`, `total_venta`) VALUES
(40, '2023-06-10', 1, 49, 16200),
(41, '2023-06-10', 2, 49, 3100),
(42, '2023-06-10', 1, 49, 12000),
(43, '2023-06-10', 1, 49, 100),
(44, '2023-06-10', 2, 49, 122500),
(45, '2023-06-10', 1, 49, 5000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

CREATE TABLE `ventas_detalle` (
  `id` int(11) NOT NULL,
  `venta_id` int(11) NOT NULL,
  `producto_id` int(11) NOT NULL,
  `cantidad_venta` int(11) NOT NULL,
  `precio` double NOT NULL,
  `sub_total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ventas_detalle`
--

INSERT INTO `ventas_detalle` (`id`, `venta_id`, `producto_id`, `cantidad_venta`, `precio`, `sub_total`) VALUES
(56, 40, 8, 2, 3000, 6000),
(57, 40, 9, 2, 100, 200),
(58, 40, 10, 2, 5000, 10000),
(59, 41, 8, 1, 3000, 3000),
(60, 41, 9, 1, 100, 100),
(61, 42, 11, 1, 12000, 12000),
(62, 43, 9, 1, 100, 100),
(63, 44, 9, 2, 100, 200),
(64, 44, 16, 2, 6000, 12000),
(65, 44, 14, 3, 6800, 20400),
(66, 44, 15, 2, 2000, 4000),
(67, 44, 19, 2, 12000, 24000),
(68, 44, 20, 1, 20000, 20000),
(69, 44, 12, 2, 5000, 10000),
(70, 44, 17, 1, 5900, 5900),
(71, 44, 13, 1, 6000, 6000),
(72, 44, 8, 1, 3000, 3000),
(73, 44, 10, 1, 5000, 5000),
(74, 44, 11, 1, 12000, 12000),
(75, 45, 10, 1, 5000, 5000);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `dni` (`dni`),
  ADD UNIQUE KEY `dni_2` (`dni`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `domicilio_id` (`domicilio_id`);

--
-- Indices de la tabla `domicilios`
--
ALTER TABLE `domicilios`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tipos_usuario`
--
ALTER TABLE `tipos_usuario`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`,`usuario`),
  ADD KEY `perfil_id` (`perfil_id`),
  ADD KEY `domicilio_id` (`domicilio_id`);

--
-- Indices de la tabla `ventas_cabecera`
--
ALTER TABLE `ventas_cabecera`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_vendedor` (`id_vendedor`);

--
-- Indices de la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  ADD PRIMARY KEY (`id`),
  ADD KEY `venta_id` (`venta_id`,`producto_id`),
  ADD KEY `producto_id` (`producto_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `domicilios`
--
ALTER TABLE `domicilios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT de la tabla `ventas_cabecera`
--
ALTER TABLE `ventas_cabecera`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT de la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `clientes_ibfk_2` FOREIGN KEY (`domicilio_id`) REFERENCES `domicilios` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`domicilio_id`) REFERENCES `domicilios` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `usuarios_ibfk_3` FOREIGN KEY (`perfil_id`) REFERENCES `tipos_usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `ventas_cabecera`
--
ALTER TABLE `ventas_cabecera`
  ADD CONSTRAINT `ventas_cabecera_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ventas_cabecera_ibfk_2` FOREIGN KEY (`id_vendedor`) REFERENCES `usuarios` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  ADD CONSTRAINT `ventas_detalle_ibfk_1` FOREIGN KEY (`producto_id`) REFERENCES `products` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ventas_detalle_ibfk_2` FOREIGN KEY (`venta_id`) REFERENCES `ventas_cabecera` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
