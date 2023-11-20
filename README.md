**CompanyTaskAPI**
CompanyTaskAPI, Swagger belgeleri kullanılarak kullanıcı yönetimi sağlayan bir web API'dir.

## Başlangıç
Projeye başlamadan önce şu adımları izleyin:

Bağımlılıkları Yükleme:
npm install 

## Proje Başlatma:
npm start

*Web API şu anda http://localhost:3000 üzerinde çalışmaktadır.*

**Swagger Belgeleri:**
Swagger belgelerine erişmek için tarayıcınızda Swagger UI adresini ziyaret edin.

Kullanıcı Yönetimi
API, kullanıcılarla ilgili temel işlemleri gerçekleştirmek için Swagger belgelerini kullanır.

Kullanıcı Listesi
GET /api/users

Belirli bir kullanıcıyı almak için:
GET /api/users/{userId}

Yeni bir kullanıcı eklemek için:
POST /api/users

İstek Gövdesi:

{
"username": "john_doe",  
"email": "john@example.com",  
"password": "gizlisenifre"  
}

Kullanıcı Güncelleme
PUT /api/users/{userId}

Kullanıcı Silme
DELETE /api/users/{userId
