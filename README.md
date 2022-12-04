# Proje Veri Tabanı Tabloları

<b>arac_kiralama Tablosu</b>

<table>
  <tr>
    <th>id</th>
    <th>kayitid</th>
    <th>arac_adi</th>
    <th>arac_fiyat</th>
    <th>alis_tarihi</th>
    <th>iade_tarihi</th>
  </tr>
  <tr>
    <td>int</td>
    <td>int</td>
    <td>nvarchar(100)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
  </tr>
</table>

<hr>

<b>arac_satis Tablosu</b>

<table>
  <tr>
    <th>id</th>
    <th>kayitid</th>
    <th>arac_adi</th>
    <th>arac_fiyat</th>
  </tr>
  <tr>
    <td>int</td>
    <td>int</td>
    <td>nvarchar(100)</td>
    <td>nvarchar(50)</td>
  </tr>
</table>

<hr>

<b>kayit Tablosu</b>

<table>
  <tr>
    <th>id</th>
    <th>ad</th>
    <th>soyad</th>
    <th>tc</th>
    <th>eposta</th>
    <th>sifre</th>
    <th>telefon</th>
    <th>adres</th>
  </tr>
  <tr>
    <td>int</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(100)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(150)</td>
  </tr>
</table>

<hr>

<b>kiralama_yorum Tablosu</b>

<table>
  <tr>
    <th>id</th>
    <th>Arac_adi</th>
    <th>Ad</th>
    <th>Soyad</th>
    <th>yorum</th>
  </tr>
  <tr>
    <td>int</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(50)</td>
    <td>nvarchar(500)</td>
  </tr>
</table>
