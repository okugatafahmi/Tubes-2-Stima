Cara membuild project:
1. Buka file "Tubes 2 Stima.sln" dengan Visual Studio.
2. Install terlebih dahulu package-package yang diperlukan jika belum ada. Package yang diperlukan adalah Microsoft.Msagl.1.1.3, Microsoft.Msagl.Drawing.1.1.3, dan Microsoft.Msagl.GraphViewerGDI.1.1.3. Package-package tersebut dapat dinstall melalui NuGet package di Visual Studio.
3. Lalu jalankan dengan menekan tombol Ctrl + F5
4. Kemudian gunakan programnya

Cara menggunakan program:
1. Masukkan file input berupa info keterhubungan kota dan peluang orangnya berpindah. Format isi filenya seperti ini:
<Banyak_Jalur>
<Nama_Asal_Kota> <Nama_Target_Kota> <Peluang_Perpindahan>
2. Masukkan file input berupa info banyak penduduk tiap kota. Format isi filenya seperti ini:
<Banyak_Kota>
<Nama_Kota> <Banyak_Penduduk>
3. Tekan tombol Create Graph
4. Isi waktu total yang ingin dianalisis
5. Tekan tombol START
6. Jika ingin melihat kondisi di suatu waktu tertentu, gunakan komponen numericUpDown berlabelkan "Jump to"