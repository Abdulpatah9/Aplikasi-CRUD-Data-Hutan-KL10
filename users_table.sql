-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 18 Feb 2025 pada 03.30
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `users_table`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `hutan`
--

CREATE TABLE `hutan` (
  `id_hutan` int(11) NOT NULL,
  `nama_hutan` varchar(250) NOT NULL,
  `lokasi_hutan` varchar(250) NOT NULL,
  `jml_flora` int(25) NOT NULL,
  `tgl_pencatatan` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `hutan`
--

INSERT INTO `hutan` (`id_hutan`, `nama_hutan`, `lokasi_hutan`, `jml_flora`, `tgl_pencatatan`) VALUES
(1, 'Hutan Jawaaaaa', 'Jawa Pulauuuu', 1, '2025-02-03'),
(3, 'Hutan Hujan', 'Kecamatan Bogor', 600, '2025-02-02'),
(8, 'Hutan Lindung Ajah', 'Jakarta Timur', 400, '2025-02-07'),
(9, 'Hutan Lebat', 'Amazon', 350, '2025-02-06');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pohon`
--

CREATE TABLE `tbl_pohon` (
  `id_pohon` varchar(20) NOT NULL,
  `nama_pohon` varchar(250) NOT NULL,
  `lokasi_pohon` varchar(250) NOT NULL,
  `diameter` int(11) NOT NULL,
  `tgl_ukur` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `userid` varchar(20) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `userpwd` varchar(50) DEFAULT NULL,
  `userlevel` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='Tabel User Pengguna';

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`userid`, `username`, `userpwd`, `userlevel`) VALUES
('USR001', 'admin', 'admin', '1'),
('USR002', 'izam', 'password', '2');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `hutan`
--
ALTER TABLE `hutan`
  ADD PRIMARY KEY (`id_hutan`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `hutan`
--
ALTER TABLE `hutan`
  MODIFY `id_hutan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
