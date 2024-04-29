## Kullanılabilirlik Senaryoları: Kütüphane Yönetim Uygulaması

Bu belge, kütüphane yönetim uygulamasının kullanılabilirlik senaryolarını tanımlar. Kullanılabilirlik senaryoları, kullanıcıların uygulamayı etkili bir şekilde kullanmalarını sağlamak için tasarlanmıştır.

---

### Senaryo 1: Kullanıcı Girişi ve Yetkilendirme

**Kullanıcı Hikayesi:**
Kullanıcı, kütüphane sistemine erişmek istiyor ve giriş yapmalıdır. Kullanıcının yetkilendirilmiş bir hesabı varsa, giriş yapabilir ve uygulamanın tüm özelliklerine erişebilir.

**Senaryo Adımları:**
1. Kullanıcı, uygulamaya erişmek için kullanıcı adı ve şifresini girer.
2. Sistem, kullanıcı bilgilerini doğrular ve kullanıcıyı yetkilendirir.
3. Yetkilendirilmiş kullanıcı, kütüphane yönetim uygulamasına erişir ve istediği işlemi gerçekleştirir.

---

### Senaryo 2: Yeni Kitap Ekleme

**Kullanıcı Hikayesi:**
Kütüphane personeli, kütüphaneye yeni bir kitap eklemek istiyor. Bu kitap için tüm gerekli bilgileri eklemeli ve stok durumunu güncellemelidir.

**Senaryo Adımları:**
1. Personel, uygulamaya giriş yapar.
2. Yeni kitap eklemek için uygun bir form açar.
3. Kitapla ilgili bilgileri (başlık, yazar, yayınevi, ISBN vb.) doldurur.
4. Kitabın stok durumunu belirler ve gerekirse ek notlar ekler.
5. Kitap bilgilerini kaydeder ve kullanıcıya bir onay mesajı gösterir.

---

### Senaryo 3: Bir Üyenin Profilini Güncelleme

**Kullanıcı Hikayesi:**
Bir kütüphane üyesi, profil bilgilerini güncellemek istiyor. Örneğin, iletişim bilgilerini, üyelik planını veya okuma tercihlerini değiştirmek isteyebilir.

**Senaryo Adımları:**
1. Üye, uygulamaya giriş yapar.
2. Profil sayfasına gider ve güncelleme seçeneğini seçer.
3. İlgili alanları günceller (ad, soyad, e-posta, adres, telefon vb.).
4. Güncellemeleri kaydeder ve bir onay mesajı alır.

---

### Senaryo 4: Bir Kitabı Ödünç Alma

**Kullanıcı Hikayesi:**
Bir kütüphane üyesi, belirli bir kitabı ödünç almak istiyor. Kitabı bulmalı, ödünç alma işlemini tamamlamalı ve teslim tarihini hatırlamalıdır.

**Senaryo Adımları:**
1. Üye, uygulamaya giriş yapar.
2. Kitap arama fonksiyonunu kullanarak istediği kitabı bulur.
3. Kitabın mevcut olduğunu kontrol eder ve ödünç alma işlemine başlar.
4. Ödünç alma formunu doldurur (teslim tarihi, ek notlar vb.).
5. Kitabı ödünç alır ve teslim tarihini hatırlamak için bir hatırlatıcı alır.

---

### Senaryo 5: Bir Kitabı İade Etme

**Kullanıcı Hikayesi:**
Bir kütüphane üyesi, ödünç aldığı bir kitabı geri getirmek istiyor. Kitabı teslim etmeli ve gecikme ücreti gibi herhangi bir özel durumu ele almalıdır.

**Senaryo Adımları:**
1. Üye, uygulamaya giriş yapar.
2. Profilindeki ödünç aldığı kitapları kontrol eder.
3. İade edilecek kitabı seçer ve iade işlemine başlar.
4. Kitabı kütüphaneye teslim eder.
5. Varsa gecikme ücreti gibi özel durumları ele alır.

---

### Senaryo 6: Bir Kitapta Hasar Bildirme

**Kullanıcı Hikayesi:**
Bir kütüphane üyesi, ödünç aldığı bir kitapta hasar fark eder ve bunu kütüphane personeline bildirmek istiyor.

**Senaryo Adımları:**
1. Üye, uygulamaya giriş yapar.
2. Profilindeki ödünç aldığı kitapları kontrol eder.
3. Hasarlı kitabı seçer ve hasarı bildirme işlemine başlar.
4. Hasarın ne olduğunu ve nasıl meydana geldiğini açıklar.
5. Bildirimi tamamlar ve kütüphane personeline gönderir.

---

### Senaryo 7: Yeni Bir Şube Ekleme

**Kullanıcı Hikayesi:**
Kütüphane yöneticisi, yeni bir şube eklemek istiyor. Yeni şubenin bilgilerini girmeli ve gerekli tüm kayıtları oluşturmalıdır.

**Senaryo Adımları:**
1. Yönetici, uygulamaya giriş yapar.
2. Yeni şube eklemek için uygun bir form açar.
3. Şubeyle ilgili tüm bilgileri (ad, adres, telefon, açıklama vb.) girer.
4. Şube çalışma saatlerini ayarlar.
5. Yeni şubeyi kaydeder ve bir onay mesajı alır.

---

### Senaryo 8: Bir Yazar Ekleme

**Kullanıcı Hikayesi:**
Kütüphane yöneticisi, yeni bir yazar eklemek istiyor. Bu yazarın adını, biyografisini ve diğer ilgili bilgileri girmelidir.

**Senaryo Adımları:**
1. Yönetici, uygulamaya giriş yapar.
2. Yeni yazar eklemek için uygun bir form açar.
3. Yazarla ilgili tüm bilgileri (ad, soyad, doğum tarihi, biyografi vb.) girer.
4. Yeni yazarı kaydeder ve bir onay mesajı alır.


### Senaryo 9: Bir Kitaba Etiket Ekleme

**Kullanıcı Hikayesi:**
Kütüphane personeli, bir kitaba etiket eklemek istiyor. Bu etiket, kitabın türünü veya kategorisini belirlemeye yardımcı olur.

**Senaryo Adımları:**
1. Personel, uygulamaya giriş yapar.
2. Kitap listesinden etiket eklemek istediği kitabı seçer.
3. Kitabın düzenleme seçeneğini seçer.
4. Etiket alanına yeni bir etiket ekler.
5. Değişiklikleri kaydeder ve bir onay mesajı alır.

---

### Senaryo 10: Bir Kitaba Tür Ekleme

**Kullanıcı Hikayesi:**
Kütüphane personeli, bir kitaba tür eklemek istiyor. Bu tür, kitabın kategorisini belirlemeye yardımcı olur.

**Senaryo Adımları:**
1. Personel, uygulamaya giriş yapar.
2. Kitap listesinden tür eklemek istediği kitabı seçer.
3. Kitabın düzenleme seçeneğini seçer.
4. Tür alanına yeni bir tür ekler.
5. Değişiklikleri kaydeder ve bir onay mesajı alır.

---

