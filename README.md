# Öğrenci Bilgi Sistemi

**Öğrenci Bilgi Sistemi**, öğrenci yönetimi için geliştirilmiş bir Windows Forms uygulamasıdır. Bu sistem, öğrenciler, dersler, öğretmenler ve kulüplerle ilgili CRUD (Create, Read, Update, Delete) işlemleri yapmayı sağlar. Kullanıcılar, öğrenci ekleme, silme, güncelleme ve listeleme işlemleri gerçekleştirebilir. Ayrıca, dersler, öğretmenler ve kulüpler ile ilgili de benzer işlemler yapılabilir.

## Özellikler
- **Öğrenci Yönetimi**: Öğrencilerin bilgilerini (isim, soyad, numara, kulüp) sisteme ekleyebilir, güncelleyebilir ve silebilirsiniz.
- **Ders Yönetimi**: Dersler eklenebilir, düzenlenebilir ve silinebilir.
- **Kulüp Yönetimi**: Öğrencilere kulüp ataması yapılabilir, kulüp bilgileri yönetilebilir.
- **Öğretmen Yönetimi**: Öğretmen bilgileri eklenebilir, düzenlenebilir ve silinebilir.
- **Kullanıcı Girişi**: Sisteme giriş yapmak için kullanıcı adı ve şifre gereklidir.

## Kullanıcı Arayüzü

### 1. **Login Form** 

![Login](https://github.com/user-attachments/assets/69d4cdad-a32a-45b5-b6fc-f496895c52c4)

Giriş yapabilmek için kullanıcı adı ve şifre ile sisteme giriş yapılır. Bu ekran, uygulamanın başlangıç noktasıdır.

### 2. **Öğrenci Formu**

![Student](https://github.com/user-attachments/assets/533072a4-2102-487a-9cf4-624f50a1f3a2)

Öğrenci eklemek, güncellemek, silmek ve listelemek için kullanılan formdur. Öğrencinin adı, soyadı, numarası ve kulübü gibi bilgileri içerir.

### 3. **Ders Formu** 

![LessonForm](https://github.com/user-attachments/assets/460f255c-d852-4432-be45-ac7cba3d573d)

Derslerin eklenmesi, güncellenmesi ve silinmesi işlemlerini gerçekleştiren formdur. Öğrencilerin derslerle olan ilişkileri yönetilebilir.

### 4. **Kulüp Formu** 

![ClubForm](https://github.com/user-attachments/assets/db81e950-92e8-4a68-a466-436f462a6b3e)

Kulüp ekleme, güncelleme ve silme işlemleri yapılabilir. Kulüp üyeleri öğrencilere atanabilir ve kulüp bilgileri yönetilebilir.

### 5. **Öğretmen Formu** 

![TeacherForm](https://github.com/user-attachments/assets/e73a5b69-c6bb-486e-86b9-3b3cd540dd0f)

Öğretmenlerin görevli olduğu işlemler yapılır.

## Gereksinimler
- **.NET Framework**
- **SQL Server** (Veritabanı için)
- **Visual Studio** (Projeyi çalıştırmak için)

## Kurulum

1. **Veritabanı Kurulumu**:
   - SQL Server kullanarak `OgrenciBilgiSistemi` adlı bir veritabanı oluşturun.
   - Veritabanında gerekli tabloları ve ilişkileri oluşturun.

2. **Bağlantı Dizesi**:
   - Bağlantı dizesini `SqlConnection` üzerinden SQL Server’a bağlanacak şekilde yapılandırın.

3. **Projeyi Çalıştırma**:
   - Visual Studio kullanarak projeyi açın ve çalıştırın.

## Kullanım

### 1. **Öğrenci İşlemleri**
Öğrenciler, adı, soyadı, numarası ve kulüp bilgisi ile sisteme eklenebilir. Öğrencilerin kulüp atamaları yapılabilir.

### 2. **Ders İşlemleri**
Yeni dersler eklenebilir, mevcut dersler düzenlenebilir veya silinebilir.

### 3. **Kulüp İşlemleri**
Yeni kulüpler oluşturulabilir. Öğrenciler bu kulüplere atanabilir.
