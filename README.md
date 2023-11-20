**CompanyTaskAPI**
CompanyTaskAPI, Swagger belgeleri kullanılarak kullanıcı yönetimi sağlayan bir web API'dir.

<img align="right" alt="Coder GIF" height=250 width=350 src="[https://media.tenor.com/QWdPngpHxZ8AAAAd/family-guy-css.gif](https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.uplabs.com%2Fposts%2Fapi-animation&psig=AOvVaw3n3QfN3uq9GhJJzKO5O9Og&ust=1700556337448000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqGAoTCNiFq5eY0oIDFQAAAAAdAAAAABCpAg)" />

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
