create database db_mahasiswa
use db_mahasiswa

INSERT INTO Jurusan VALUES
	('J001', 'Teknik Informatika', 'Aktif'),
	('J002', 'Management Informatika', 'Aktif'),
	('J003', 'Sistem Informasi', 'Non Aktif'),
	('J004', 'Sistem Komputer', 'Aktif'),
	('J005', 'Komputer Akuntansi', 'Non Aktif')

insert into Type_Dosen values
	('T001','Tetap'),
	('T002','Honorer'),
	('T003','Expertise')

INSERT INTO Dosen VALUES
	('D001', 'Prof. Dr. Retno Wahyuningsih', 'j001','T001'),
	('D002', 'Prof. Roy M. Sutikno', 'J002','T001'),
	('D003', 'Prof. Hendri A. Verburgh', 'J003','T002'),
	('D004', 'Prof. Risma Suparwata', 'J004', 'T002'),
	('D005', 'Prof. Amir Sjarifuddin Madjid, MM, MA', 'J005', 'T001')

insert into Agama values
	('A001','Islam'),
	('A002','Kristen'),
	('A003','Katolik'),
	('A004','Hindu'),
	('A005','Budha')

INSERT INTO Ujian VALUES
	('U001', 'Algoritma', 'Aktif'),
	('U002', 'Aljabar', 'Aktif'),
	('U003', 'Statistika', 'Non Aktif'),
	('U004', 'Etika Profesi', 'Non Aktif'),
	('U005', 'Bahasa Inggris', 'Aktif')

INSERT INTO Nilai VALUES
	('M004', 'U001', 90),
	('M001', 'U001', 80),
	('M002', 'U003', 85),
	('M004', 'U002', 95),
	('M005', 'U005', 70)


INSERT INTO Mahasiswa VALUES
	('M001', 'Budi Gunawan', 'Jl. Mawar No 3 RT 05 Cicalengka, Bandung', 'A001', 'J001'),
	('M002', 'Rinto Raharjo', 'Jl. Kebagusan No. 33 RT04 RW06 Bandung', 'A002', 'J002'),
	('M003', 'Asep Saepudin', 'Jl. Sumatera No. 12 RT02 RW01, Ciamis', 'A001', 'J003'),
	('M004', 'M. Hafif Isbullah', 'Jl. Jawa No 01 RT01 RW01, Jakarta Pusat', 'A001', 'J001'),
	('M005', 'Cahyono', 'Jl. Niagara No. 54 RT01 RW09, Surabaya', 'A003', 'J002')

ALTER TABLE Dosen
ALTER COLUMN Nama_Dosen Varchar(200)

select * from Mahasiswa as m join Jurusan as j 
on m.Kode_Jurusan = j.Kode_Jurusan and
j.Status_Jurusan = 'Non Aktif'

select * from Mahasiswa as m join Nilai as n  
on m.Kode_Mahasiswa = n.Kode_Mahasiswa and n.Nilai >80 
Join Ujian as u on n.Kode_Ujian = u.Kode_Ujian
and u.Status_Ujian = 'Aktif' 

select * from Jurusan where Nama_jurusan like '%Sistem%'

Select * from Mahasiswa where Kode_Mahasiswa = (SELECT Kode_Mahasiswa  
FROM Nilai
GROUP BY Kode_Mahasiswa HAVING count(Kode_Mahasiswa) > 1)

select m.Kode_Mahasiswa, m.Nama_Mahasiswa, j.Nama_jurusan, a.Deskripsi as Agama, d.Nama_Dosen, j.Status_jurusan, t.Deskripsi
 from Mahasiswa as m join Jurusan as j 
on m.Kode_Jurusan = j.Kode_Jurusan and
m.Kode_Mahasiswa = 'M001' join Agama as a on m.Kode_Agama = a.Kode_Agama
join Dosen as d on d.Kode_Jurusan = j.Kode_Jurusan join Type_Dosen as t on d.Kode_type_dosen = t.Kode_Type_Dosen

Create view Tampil as 
select 
	m.Kode_Mahasiswa, m.Nama_Mahasiswa, j.Nama_jurusan, 
	a.Deskripsi as Agama, d.Nama_Dosen, j.Status_jurusan, t.Deskripsi
from Mahasiswa as m join Jurusan as j 
on m.Kode_Jurusan = j.Kode_Jurusan and
m.Kode_Mahasiswa = 'M001' join Agama as a on m.Kode_Agama = a.Kode_Agama
join Dosen as d on d.Kode_Jurusan = j.Kode_Jurusan
join Type_Dosen as t on d.Kode_type_dosen = t.Kode_Type_Dosen

Select * from Tampil

select * from Mahasiswa full join Nilai on 
Mahasiswa.Kode_Mahasiswa = Nilai.Kode_Mahasiswa 
or 
Mahasiswa.Kode_Mahasiswa!=null

