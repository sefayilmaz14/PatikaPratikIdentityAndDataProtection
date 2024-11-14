# PatikaPratikIdentityAndDataProtection
Kullanıcı kimlik doğrulama ve veri koruma işlevleri sağlayan, kullanıcı kaydı, veri şifreleme ve güvenli veri işlemleri özelliklerini içeren bir .NET Core projesidir.

## İçindekiler
Kurulum
Yapılandırma
Kullanım


## Kurulum
- Depoyu Klonlayın:


```git clone https://github.com/kullanici-adi/PatikaPratikIdentityAndDataProtection.git cd PatikaPratikIdentityAndDataProtection ```
- Bağımlılıkları Yükleyin: Çözümü Visual Studio'da açın veya aşağıdaki komutla bağımlılıkları yükleyin:
```dotnet restore```
- Çözümü Derleyin:
```dotnet build```
## Yapılandırma
appsettings.json: Veritabanı bağlantı dizesini, kimlik doğrulama ayarlarını ve diğer gerekli ayarları appsettings.json dosyasında yapılandırın.
- Veri Koruma Yapılandırması: IDataProtection servisi, DataProtection sınıfında bir koruyucu ile yapılandırılmıştır. Bu koruyucu ayarlar isteğe göre düzenlenebilir.
## Kullanım
- Kullanıcı Kaydı
Uygulamada, kullanıcı kaydı için AuthController içinde bir endpoint bulunur. Yeni bir kullanıcı kaydetmek için /auth/register adresine, RegisterRequest veri yapısını içeren bir POST isteği gönderin.

- Örnek İstek
```json
POST /auth/register
{
"email": "user@example.com",
"password": "YourPassword123!"
}
```
## Veri Koruma
DataProtection sınıfı, hassas bilgileri güvenli bir şekilde işlemek için Protect ve UnProtect yöntemlerini sağlar.

### Örnek Kullanım
```csharp
var protector = new DataProtection(dataProtectionProvider);
string protectedText = protector.Protect("HassasVeri");
string unprotectedText = protector.UnProtect(protectedText);
```
