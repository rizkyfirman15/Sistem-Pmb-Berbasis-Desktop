-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Mar 2020 pada 16.53
-- Versi server: 10.1.38-MariaDB
-- Versi PHP: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `spkjurusan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `pendaftar`
--

CREATE TABLE `pendaftar` (
  `no` varchar(10) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `jeniskelamin` varchar(10) NOT NULL,
  `tempatlahir` varchar(30) NOT NULL,
  `tanggallahir` date NOT NULL,
  `agama` varchar(20) NOT NULL,
  `alamat` text NOT NULL,
  `namaayah` varchar(20) NOT NULL,
  `namaibu` varchar(20) NOT NULL,
  `pekerjaanayah` varchar(50) NOT NULL,
  `pekerjaanibu` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pendaftar`
--

INSERT INTO `pendaftar` (`no`, `nama`, `jeniskelamin`, `tempatlahir`, `tanggallahir`, `agama`, `alamat`, `namaayah`, `namaibu`, `pekerjaanayah`, `pekerjaanibu`) VALUES
('1001', 'Rizky Firmansyah', 'Laki-laki', 'Serang', '2000-03-15', 'Islam', 'Kp.Bojong ', 'Marjana Murad', 'Mutmainah', 'Wiraswasta', 'Ibu Rumah Tangga'),
('1002', 'Solahudin Al-Ayyubi', 'Laki-laki', 'Tangerang', '2000-12-12', 'Islam', 'Kp.Blukbuk ', 'H.Jubaidi', 'Hj.Khairiyah', 'Penghulu', 'Ibu Rumah Tangga'),
('1003', 'Laeni Yuliani', 'Perempuan', 'Bogor', '1999-12-14', 'Islam', 'Serang', 'Alex Assalam', 'Nurhayati', 'Wiraswasta', 'Ibu rumah Tangga');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penilaian`
--

CREATE TABLE `penilaian` (
  `no_pendaftar` varchar(10) NOT NULL,
  `minatBDKMSI` varchar(20) NOT NULL,
  `minatBPB` varchar(20) NOT NULL,
  `utpBDKMSI` varchar(50) NOT NULL,
  `utpBPB` varchar(50) NOT NULL,
  `ukBDKMSI` varchar(30) NOT NULL,
  `ukBPB` varchar(30) NOT NULL,
  `w1` char(20) NOT NULL,
  `w2` char(20) NOT NULL,
  `w3` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penilaian`
--

INSERT INTO `penilaian` (`no_pendaftar`, `minatBDKMSI`, `minatBPB`, `utpBDKMSI`, `utpBPB`, `ukBDKMSI`, `ukBPB`, `w1`, `w2`, `w3`) VALUES
('1001', 't', 't', '70', '50', '75', '60', '80%', '70%', '65%');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `pendaftar`
--
ALTER TABLE `pendaftar`
  ADD PRIMARY KEY (`no`);

--
-- Indeks untuk tabel `penilaian`
--
ALTER TABLE `penilaian`
  ADD PRIMARY KEY (`no_pendaftar`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
