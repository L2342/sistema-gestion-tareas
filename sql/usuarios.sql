-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-03-2025 a las 05:10:43
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `usuarios`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiantes`
--

CREATE TABLE `estudiantes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `clave` varchar(255) NOT NULL,
  `grupo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `estudiantes`
--

INSERT INTO `estudiantes` (`id`, `nombre`, `correo`, `clave`, `grupo`) VALUES
(1, 'juanito', 'juanito@gmail.com', '0e4a4976828814092ea711ebdc7c8994df152095de73169641454de7bf8e6129', 'Grupo B'),
(2, 'pedrito', 'pedrito@gmail.com', 'e7ec0569c8b391781ee71edff60906734afd5a0d4ae4f7be99a8506283cefd5b', 'Grupo C'),
(3, 'lion', 'lion@gmail.com', '15aeca8a96522c658ab4078d26f391176f0d305a539871b05127028708f5a8d1', 'Grupo A'),
(4, 'maria', 'maria@gmail.com', '7bcd7f0daa780b23f42aac586b095bb25f195c7495ee195a62eca8e3101aad56', 'Grupo N'),
(6, 'samuel', 'samuel@gmail.com', '2db22adf093fc4a5cda4e42e0f9259a26a655561c88181443541b4654ed91294', 'Grupo B');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesores`
--

CREATE TABLE `profesores` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `clave` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `profesores`
--

INSERT INTO `profesores` (`id`, `nombre`, `correo`, `clave`) VALUES
(1, 'juanita', 'juanita@gmail.com', '9a91af28bfe56d5d51f9e970be6dada9d845892ee7de32fea5c6f454db09f0b9'),
(2, 'pepito', 'pepito@gmail.com', '27e913613b11b181bf947bd0353b922e7229a5962cf69054cbb17d42d90e1e74'),
(3, 'fulano', 'fulano@gmial.com', '342cfcaa0e7e16e25baeca8615f0eb206d66ffa765aaa199e4d9b8be1f8bc58c'),
(4, 'samuelProf', 'david@gmail.com', '7e964e9a5d1bd266148141770c33a58b0a5cf4200becf4aa4d56ab725e1636c5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tareas`
--

CREATE TABLE `tareas` (
  `id` int(11) NOT NULL,
  `titulo` varchar(255) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `fecha_entrega` date NOT NULL,
  `grupo_asignado` varchar(50) NOT NULL,
  `profesor_id` int(11) NOT NULL,
  `materia` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tareas`
--

INSERT INTO `tareas` (`id`, `titulo`, `descripcion`, `fecha_entrega`, `grupo_asignado`, `profesor_id`, `materia`) VALUES
(21, 'ensayo', 'ensayo carnes con normas apa juaz juaz', '2025-03-01', 'Grupo C', 1, 'Lenguas'),
(28, 'algoritmo ', 'hacer un algoritmo bien verga', '2025-03-02', 'Grupo B', 2, 'Matemáticas'),
(30, 'fisica', 'un carro se muevo mucho y luego no se muebe :0', '2025-03-03', 'Grupo A', 1, 'Fisica'),
(33, 'analisis teologico ', 'QUIEN ES EL MEJOR PAPA DE TODOS?', '2025-03-03', 'Grupo A', 2, 'Religión'),
(34, 'filosofia proposicional ', 'analisis exaustivo sobre la inversion mas viable a corto/largo plazo. una puta de 40k o 40 a 1k :0', '2025-03-03', 'Grupo N', 1, 'Filosofia'),
(35, 'mi name ', 'mi name is pensil', '2025-03-04', 'Grupo A', 3, 'Ingles'),
(36, 'Prueba de validacion', 'probar el sistema de asignacion', '2025-03-01', 'Grupo B', 4, 'Matemáticas'),
(37, 'Trabajo 2', 'proyecto de validad', '2025-04-08', 'Grupo B', 4, 'Lenguas'),
(38, 'test 3', 'test 3', '2025-05-31', 'Grupo B', 4, 'Matemáticas'),
(39, 'Examen final', 'examen de todo lo visto en la materia', '2025-03-01', 'Grupo B', 4, 'Biologia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarea_estudiante`
--

CREATE TABLE `tarea_estudiante` (
  `id` int(11) NOT NULL,
  `tarea_id` int(11) NOT NULL,
  `estudiante_id` int(11) NOT NULL,
  `estado` enum('Pendiente','En progreso','Completado') DEFAULT 'Pendiente',
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `materia` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `tarea_estudiante`
--

INSERT INTO `tarea_estudiante` (`id`, `tarea_id`, `estudiante_id`, `estado`, `fecha`, `materia`) VALUES
(6, 21, 2, 'Pendiente', '2025-03-01 05:00:00', 'Lenguas'),
(8, 30, 3, 'Pendiente', '2025-03-03 05:00:00', 'Fisica'),
(9, 34, 4, 'Pendiente', '2025-03-03 05:00:00', 'Filosofia'),
(11, 28, 3, 'Pendiente', '2025-03-02 05:00:00', 'Matemáticas'),
(13, 33, 3, 'Pendiente', '2025-03-03 05:00:00', 'Religión'),
(16, 28, 1, 'Pendiente', '2025-03-02 05:00:00', 'Matemáticas'),
(18, 33, 3, 'Pendiente', '2025-03-03 05:00:00', 'Religión'),
(22, 35, 3, 'Pendiente', '2025-03-04 05:00:00', 'Ingles'),
(23, 36, 1, 'Pendiente', '2025-03-01 05:00:00', 'Matemáticas'),
(24, 36, 6, 'Pendiente', '2025-03-01 05:00:00', 'Matemáticas'),
(25, 37, 1, 'Pendiente', '2025-04-08 05:00:00', 'Lenguas'),
(26, 37, 6, 'En progreso', '2025-04-08 05:00:00', 'Lenguas'),
(27, 38, 1, 'Pendiente', '2025-05-31 05:00:00', 'Matemáticas'),
(28, 38, 6, 'Pendiente', '2025-05-31 05:00:00', 'Matemáticas'),
(29, 39, 1, 'Pendiente', '2025-03-01 05:00:00', 'Biologia'),
(30, 39, 6, 'Pendiente', '2025-03-01 05:00:00', 'Biologia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `clave` varchar(255) NOT NULL,
  `rol` enum('Estudiante','Profesor') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre_usuario`, `email`, `clave`, `rol`) VALUES
(1, 'juan', 'juan@gmail.com', '0e4a4976828814092ea711ebdc7c8994df152095de73169641454de7bf8e6129', 'Estudiante'),
(2, 'danieala', 'daniela@gmai.com', '378fed608cc4b3d8c50fbfbe665b0965317d922d56c1f830d7a679d27dcdca8a', 'Estudiante'),
(3, 'che3ss', 'SAMUEL@ME.COM', '379915a3d467674bee168d9b15d53c00e6defc48343a333353f67f8791edd0cc', 'Estudiante');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `correo` (`correo`);

--
-- Indices de la tabla `profesores`
--
ALTER TABLE `profesores`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `correo` (`correo`);

--
-- Indices de la tabla `tareas`
--
ALTER TABLE `tareas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `profesor_id` (`profesor_id`);

--
-- Indices de la tabla `tarea_estudiante`
--
ALTER TABLE `tarea_estudiante`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tarea_id` (`tarea_id`),
  ADD KEY `estudiante_id` (`estudiante_id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre_usuario` (`nombre_usuario`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `profesores`
--
ALTER TABLE `profesores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tareas`
--
ALTER TABLE `tareas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT de la tabla `tarea_estudiante`
--
ALTER TABLE `tarea_estudiante`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tareas`
--
ALTER TABLE `tareas`
  ADD CONSTRAINT `tareas_ibfk_1` FOREIGN KEY (`profesor_id`) REFERENCES `profesores` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `tarea_estudiante`
--
ALTER TABLE `tarea_estudiante`
  ADD CONSTRAINT `tarea_estudiante_ibfk_1` FOREIGN KEY (`tarea_id`) REFERENCES `tareas` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `tarea_estudiante_ibfk_2` FOREIGN KEY (`estudiante_id`) REFERENCES `estudiantes` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
