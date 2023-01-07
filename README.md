# TravelMate
TravelMate
-Sistemi ele alırken ddd kapsamubda bounded context olarak 

kullanıcılar vve ona bağlı yetkiler için Authentications,

seyehatin gerçekleştirileceği için Travels,

admin ve genel manada tüm sistemin ayarları olsaydı settings

ödeme ya da faturalandırma olsaydı Billings şeklinde belirlenebilirdi.

Bu bizim iş süreçleri ayrılmasında ve kolay okunabilirliği sağlamaktadır.


- Uygulama adı olara TravelMate yol arkadaşlığı gibi bir şey seçtim. 
Tüm katmanlı mimari bu adla oluşturulacak

- .net 7, PostgreSql veya Sqlserver olabilir, CQRS, AutoMapper,FluentValidation ve Resftul api olarak geliştirilecektir.

-Onion arhitecture olarak Domain, Application, Infrstructure ve API katmanları yer alacak.

-Sistemin geliştirilmesine göre katmanlar çoğaltılabilir mail ve sms gönderme, cache gibi. sms ve mail ileride rabbitmq message queue microservis'e dönüştürülebilir

-Test sistemi olduğu için herhangi bir Authorize ve ya Role attiribute kullanmadım

-Sistem çalışır çalışmaz ilk önce gereken migration ve sonra data seed ler otomatik olarak çalışıyor

-Yine test olduğu için boşluk, veritananında olamama ve kayıt işlemlerinde kullanıcının veritananında olma durumu gibi extra önlem eklemedim

- Search kısmında FromQuery kullandım ki aramaya girmeyecek olan alanları arkada tarafa gönderilmesine gerek yok

2- Bölüm için Location tablosuna latitude decimal, longitute decimal enlem ve boylam kullanarak
 
 ekleme sırasında alanın içinde ise IsIn kolonu true olacak Bunu sadece eklerken ve güncellerken kullanılacak
